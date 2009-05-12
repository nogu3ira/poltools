﻿/***************************************************************************
 *
 * $Author: MuadDib & Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Ultima;

namespace MultiEditor
{
    public partial class MultiEditor : UserControl
    {
		#region Fields (11) 

        private MultiEditorComponentList compList;
        private ArrayList DrawTilesList = new ArrayList();
        private bool Loaded = false;
        private int m_DrawFloorZ;
        private MultiTile m_DrawTile;
        private MultiTile m_HoverTile;
        private MultiTile m_SelectedTile;
        /// <summary>
        /// Current MouseLoc + Scrollbar values (for hover effect)
        /// </summary>
        private Point MouseLoc;
        private int pictureboxDrawTilescol;
        private int pictureboxDrawTilesrow;
        private static MultiEditor refMarkerMulti = null;
        private const int DrawTileSizeWidth = 45;
        private const int DrawTileSizeHeight = 45;

        private static double CoordinateTransform = Math.Sqrt(2) / 2; //Sin/Cos(45°)

		#endregion Fields 

		#region Constructors (1) 

        public MultiEditor()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            InitializeComponent();
            refMarkerMulti = this;
            XML_InitializeToolBox();
            MouseLoc = new Point();
            m_DrawTile = new MultiTile();
            Selectedpanel.Visible = false;
            FloatingPreviewPanel.Visible = false;
            FloatingPreviewPanel.Tag = -1;
            BTN_Select.Checked = true;
            pictureBoxDrawTiles.MouseWheel += new MouseEventHandler(pictureBoxDrawTiles_OnMouseWheel);
        }

		#endregion Constructors 

		#region Properties (3) 

        /// <summary>
        /// Floor Z level
        /// </summary>
        public int DrawFloorZ { get { return m_DrawFloorZ; } }

        /// <summary>
        /// Current Hovered Tile (set inside MultiComponentList)
        /// </summary>
        public MultiTile HoverTile
        {
            get { return m_HoverTile; }
            set
            {
                m_HoverTile = value;
                if (value != null)
                    toolTip1.SetToolTip(pictureBoxMulti, String.Format("ID: 0x{0:X} Z: {1}", m_HoverTile.ID, m_HoverTile.Z));
            }
        }

        /// <summary>
        /// Current Selected Tile (set OnMouseUp)
        /// </summary>
        public MultiTile SelectedTile
        {
            get { return m_SelectedTile; }
            set
            {
                m_SelectedTile = value;
                if (value != null)
                {
                    SelectedTileLabel.Text = String.Format("ID: 0x{0:X} Z: {1}", value.ID, value.Z);
                    Point point = compList.TileGetCoords(value);
                    if (point != Point.Empty)
                    {
                        numericUpDown_Selected_X.Value = point.X;
                        numericUpDown_Selected_Y.Value = point.Y;
                        numericUpDown_Selected_Z.Value = value.Z;
                    }
                }
                else
                    SelectedTileLabel.Text = "ID:";
            }
        }

		#endregion Properties 

		#region Methods (27) 

		// Private Methods (27) 

        /// <summary>
        /// Draw Button activate
        /// </summary>
        private void BTN_Draw_Click(object sender, EventArgs e)
        {
            BTN_Select.Checked = false;
            BTN_Draw.Checked = true;
            BTN_Remove.Checked = false;
            BTN_Z.Checked = false;
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Virtual Floor clicked (check on click)
        /// </summary>
        private void BTN_Floor_Clicked(object sender, EventArgs e)
        {
            m_DrawFloorZ = (int)numericUpDown_Z.Value;
            ScrollbarsSetValue();
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Remove Button activate
        /// </summary>
        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            BTN_Select.Checked = false;
            BTN_Draw.Checked = false;
            BTN_Remove.Checked = true;
            BTN_Z.Checked = false;
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Resize Multi Button clicked
        /// </summary>
        private void BTN_ResizeMulti_Click(object sender, EventArgs e)
        {
            if (compList != null)
            {
                int width = (int)numericUpDown_Size_Width.Value;
                int height = (int)numericUpDown_Size_Height.Value;
                compList.Resize(width, height);
                MaxHeightTrackBar.Minimum = compList.zMin;
                MaxHeightTrackBar.Maximum = compList.zMax;
                MaxHeightTrackBar.Value = compList.zMax;
                numericUpDown_Selected_X.Maximum = compList.Width - 1;
                numericUpDown_Selected_Y.Maximum = compList.Height - 1;
                ScrollbarsSetValue();
                pictureBoxMulti.Refresh();
            }
        }

        /// <summary>
        /// Save Button clicked
        /// </summary>
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(textBox_SaveToID.Text, out id))
                compList.AddToSDKComponentList(id); //fires MultiChangeEvent
        }

        /// <summary>
        /// Select Button activate
        /// </summary>
        private void BTN_Select_Click(object sender, EventArgs e)
        {
            BTN_Select.Checked = true;
            BTN_Draw.Checked = false;
            BTN_Remove.Checked = false;
            BTN_Z.Checked = false;
            pictureBoxMulti.Refresh();
        }

        private void BTN_Toolbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox thisBox = (CheckBox)sender;
            switch (thisBox.Name)
            {
                case "BTN_Select": thisBox.ImageKey = (thisBox.Checked) ? "SelectButton_Selected.bmp" : "SelectButton.bmp"; break;
                case "BTN_Draw": thisBox.ImageKey = (thisBox.Checked) ? "DrawButton_Selected.bmp" : "DrawButton.bmp"; break;
                case "BTN_Remove": thisBox.ImageKey = (thisBox.Checked) ? "RemoveButton_Selected.bmp" : "RemoveButton.bmp"; break;
                case "BTN_Z": thisBox.ImageKey = (thisBox.Checked) ? "AltitudeButton_Selected.bmp" : "AltitudeButton.bmp"; break;
            }
        }

        /// <summary>
        /// Z Button activate
        /// </summary>
        private void BTN_Z_Click(object sender, EventArgs e)
        {
            BTN_Select.Checked = false;
            BTN_Draw.Checked = false;
            BTN_Remove.Checked = false;
            BTN_Z.Checked = true;
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Converts pictureBox coords to Multicoords
        /// </summary>
        private void ConvertCoords(Point point, out int x, out int y, out int z)
        {
            //first check if current Tile matches
            if (HoverTile != null)
            {
                //visible?
                if ((!BTN_Floor.Checked) || (HoverTile.Z >= DrawFloorZ))
                {
                    for (int x_ = 0; x_ < compList.Width; x_++)
                    {
                        for (int y_ = 0; y_ < compList.Height; y_++)
                        {
                            for (int i = 0; i < compList.Tiles[x_][y_].Count; i++)
                            {
                                if (HoverTile == compList.Tiles[x_][y_][i])
                                {
                                    x = x_;
                                    y = y_;
                                    z = HoverTile.Z + HoverTile.Height;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            //damn the hard way
            z = 0;

            int cx = 0; //Get MouseCoords for (0/0)
            int cy = 0;
            if (BTN_Floor.Checked)
            {
                cy -= DrawFloorZ * 4;
                z = DrawFloorZ;
            }
            cy -= 44;
            cx -= compList.xMin;
            cy -= compList.yMin;
            cy += 22; //Mod for a bit of gap
            cx += 44;

            double mx = point.X - cx;
            double my = point.Y - cy;
            double xx = mx;
            double yy = my;
            my = xx * CoordinateTransform - yy * CoordinateTransform; //Rotate 45° Coordinate system
            mx = yy * CoordinateTransform + xx * CoordinateTransform;
            mx /= Math.Sqrt(2) * 22;
            my /= Math.Sqrt(2) * 22;
            my *= -1;
            x = (int)mx;
            y = (int)my;
        }

        /// <summary>
        /// Value of TrackBar changed (for displayed MaxHeight)
        /// </summary>
        private void MaxHeightTrackBarOnValueChanged(object sender, EventArgs e)
        {
            ScrollbarsSetValue();
            toolTip1.SetToolTip(MaxHeightTrackBar, MaxHeightTrackBar.Value.ToString());
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Virtual Floor zValue changed
        /// </summary>
        private void numericUpDown_Floor_Changed(object sender, EventArgs e)
        {
            m_DrawFloorZ = (int)numericUpDown_Floor.Value;
            if (BTN_Floor.Checked)
            {
                ScrollbarsSetValue();
                pictureBoxMulti.Refresh();
            }
        }

        /// <summary>
        /// SelectedTile panel X value changed 
        /// </summary>
        private void numericUpDown_Selected_X_Changed(object sender, EventArgs e)
        {
            if (compList != null)
            {
                if (SelectedTile != null)
                {
                    Point point = compList.TileGetCoords(SelectedTile);
                    if (point != Point.Empty)
                    {
                        if ((int)numericUpDown_Selected_X.Value != point.X)
                        {
                            compList.TileMove(SelectedTile, (int)numericUpDown_Selected_X.Value, point.Y);
                            pictureBoxMulti.Refresh();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// SelectedTile panel Y value changed 
        /// </summary>
        private void numericUpDown_Selected_Y_Changed(object sender, EventArgs e)
        {
            if (compList != null)
            {
                if (SelectedTile != null)
                {
                    Point point = compList.TileGetCoords(SelectedTile);
                    if (point != Point.Empty)
                    {
                        if ((int)numericUpDown_Selected_Y.Value != point.Y)
                        {
                            compList.TileMove(SelectedTile, point.X, (int)numericUpDown_Selected_Y.Value);
                            pictureBoxMulti.Refresh();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// SelectedTile panel Z value changed 
        /// </summary>
        private void numericUpDown_Selected_Z_Changed(object sender, EventArgs e)
        {
            if (compList != null)
            {
                if (SelectedTile != null)
                {
                    if ((int)numericUpDown_Selected_Z.Value != SelectedTile.Z)
                    {
                        compList.TileZSet(SelectedTile, (int)numericUpDown_Selected_Z.Value);
                        MaxHeightTrackBar.Minimum = compList.zMin;
                        MaxHeightTrackBar.Maximum = compList.zMax;
                        if (MaxHeightTrackBar.Value < SelectedTile.Z)
                            MaxHeightTrackBar.Value = SelectedTile.Z;
                        pictureBoxMulti.Refresh();
                    }
                }
            }
        }

        private void OnAfterSelectTreeViewTilesXML(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag!=null)
            {
                DrawTilesList = (ArrayList)e.Node.Tag;
                vScrollBarDrawTiles.Maximum = DrawTilesList.Count / pictureboxDrawTilescol + 1;
                vScrollBarDrawTiles.Minimum = 1;
                vScrollBarDrawTiles.SmallChange = 1;
                vScrollBarDrawTiles.LargeChange = 1;
                vScrollBarDrawTiles.Value = 1;
                pictureBoxDrawTiles.Refresh();
            }
        }

        /// <summary>
        /// Event Ultima FilePathes changed
        /// </summary>
        private void OnFilePathChangeEvent()
        {
            if (Loaded)
                OnLoad(null, null);
        }

        /// <summary>
        /// Load of Usercontrol
        /// </summary>
        private void OnLoad(object sender, EventArgs e)
        {
            FiddlerControls.Options.LoadedUltimaClass["TileData"] = true;
            FiddlerControls.Options.LoadedUltimaClass["Art"] = true;
            FiddlerControls.Options.LoadedUltimaClass["Multis"] = true;
            FiddlerControls.Options.LoadedUltimaClass["Hues"] = true;
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

            string FileName = Path.Combine(path, "Multilist.xml");
            XmlDocument dom = null;
            XmlElement xMultis = null;
            if ((File.Exists(FileName)))
            {
                dom = new XmlDocument();
                dom.Load(FileName);
                xMultis = dom["Multis"];
            }
            treeViewMultiList.BeginUpdate();
            treeViewMultiList.Nodes.Clear();
            for (int i = 0; i < 0x2000; i++)
            {
                if (Ultima.Multis.GetComponents(i) != MultiComponentList.Empty)
                {
                    TreeNode node;
                    if (dom == null)
                    {
                        node = new TreeNode(String.Format("{0,5} (0x{0:X})", i));
                    }
                    else
                    {
                        XmlNodeList xMultiNodeList = xMultis.SelectNodes("/Multis/Multi[@id='" + i + "']");
                        string j = "";
                        foreach (XmlNode xMultiNode in xMultiNodeList)
                        {
                            j = xMultiNode.Attributes["name"].Value;
                        }
                        node = new TreeNode(String.Format("{0,5} (0x{0:X}) {1}", i, j));
                    }
                    node.Tag = i;
                    node.Name = i.ToString();
                    treeViewMultiList.Nodes.Add(node);
                }
            }
            treeViewMultiList.EndUpdate();
            if (!Loaded)
            {
                FiddlerControls.Options.FilePathChangeEvent += new FiddlerControls.Options.FilePathChangeHandler(OnFilePathChangeEvent);
                FiddlerControls.Options.MultiChangeEvent += new FiddlerControls.Options.MultiChangeHandler(OnMultiChangeEvent);
            }

            Loaded = true;
        }

        private void OnMultiChangeEvent(object sender, int id)
        {
            if (!Loaded)
                return;
            if (sender.Equals(this))
                return;
            bool done = false;
            bool remove = (Ultima.Multis.GetComponents(id) == MultiComponentList.Empty);
            for (int i = 0; i < treeViewMultiList.Nodes.Count; i++)
            {
                if (id == (int)treeViewMultiList.Nodes[i].Tag)
                {
                    done = true;
                    if (remove)
                        treeViewMultiList.Nodes.RemoveAt(i);
                    break;
                }
                else if (id < (int)treeViewMultiList.Nodes[i].Tag)
                {
                    if (!remove)
                    {
                        TreeNode node = new TreeNode(String.Format("{0,5} (0x{0:X})", id));
                        node.Tag = id;
                        node.Name = id.ToString();
                        treeViewMultiList.Nodes.Insert(i, node);
                    }
                    done = true;
                    break;
                }
            }
            if ((!remove) && (!done))
            {
                TreeNode node = new TreeNode(String.Format("{0,5} (0x{0:X})", id));
                node.Tag = id;
                node.Name = id.ToString();
                treeViewMultiList.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Hover effect
        /// </summary>
        private void PictureBoxMultiOnMouseMove(object sender, MouseEventArgs e)
        {
            MouseLoc = e.Location;
            MouseLoc.X += hScrollBar.Value;
            MouseLoc.Y += vScrollBar.Value;
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Select/Draw/Remove/Z a Tile
        /// </summary>
        private void PictureBoxMultiOnMouseUp(object sender, MouseEventArgs e)
        {
            if (compList == null)
                return;
            if (BTN_Select.Checked)
            {
                SelectedTile = m_HoverTile;
            }
            else if (BTN_Draw.Checked)
            {
                if (m_DrawTile.ID >= 0)
                {
                    int x, y, z;
                    ConvertCoords(MouseLoc, out x, out y, out z);
                    if ((x >= 0) && (x < compList.Width) && (y >= 0) && (y < compList.Height))
                    {
                        compList.TileAdd(x, y, z, m_DrawTile.ID);
                        MaxHeightTrackBar.Minimum = compList.zMin;
                        MaxHeightTrackBar.Maximum = compList.zMax;
                        if (MaxHeightTrackBar.Value < z)
                            MaxHeightTrackBar.Value = z;
                    }
                }
            }
            else if (BTN_Remove.Checked)
            {
                if (m_HoverTile != null)
                    compList.TileRemove(m_HoverTile);
                MaxHeightTrackBar.Minimum = compList.zMin;
                MaxHeightTrackBar.Maximum = compList.zMax;
            }
            else if (BTN_Z.Checked)
            {
                if (m_HoverTile != null)
                {
                    int z = (int)numericUpDown_Z.Value;
                    compList.TileZMod(m_HoverTile, z);
                    MaxHeightTrackBar.Minimum = compList.zMin;
                    MaxHeightTrackBar.Maximum = compList.zMax;
                    if (MaxHeightTrackBar.Value < m_HoverTile.Z)
                        MaxHeightTrackBar.Value = m_HoverTile.Z;
                }
            }
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Draw Image
        /// </summary>
        private void PictureBoxMultiOnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Bitmap bit = null;
            if (compList != null)
            {
                bit = compList.GetImage(MaxHeightTrackBar.Value, MouseLoc, BTN_Floor.Checked);
            }
            if (bit != null)
            {
                e.Graphics.DrawImageUnscaled(bit, -hScrollBar.Value, -vScrollBar.Value);
                int x, y, z;
                ConvertCoords(MouseLoc, out x, out y, out z);
                if ((x >= 0) && (x < compList.Width) && (y >= 0) && (y < compList.Height))
                    toolStripLabelCoord.Text = String.Format("{0},{1},{2}", x, y, z);

                if (BTN_Draw.Checked)
                {
                    if (m_DrawTile.ID >= 0)
                    {
                        if ((x >= 0) && (x < compList.Width) && (y >= 0) && (y < compList.Height))
                        {
                            toolStripLabelCoord.Text = String.Format("{0},{1},{2}", x, y, z);
                            Bitmap bmp = Art.GetStatic(m_DrawTile.ID);

                            if (bmp == null)
                                return;
                            int px = (x - y) * 22;
                            int py = (x + y) * 22;

                            px -= (bmp.Width / 2);
                            py -= z * 4;
                            py -= bmp.Height;
                            px -= compList.xMin;
                            py -= compList.yMin;
                            py += 22; //Mod for a bit of gap
                            px += 44;
                            e.Graphics.DrawImage(bmp, new Rectangle(px, py, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, MultiTile.DrawColor);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// PictureBox size changed
        /// </summary>
        private void PictureBoxMultiOnResize(object sender, EventArgs e)
        {
            ScrollbarsSetValue();
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Does the Multi fit inside the PictureBox
        /// </summary>
        private void ScrollbarsSetValue()
        {
            if (compList == null)
                return;
            Bitmap bit = compList.GetImage(MaxHeightTrackBar.Value, Point.Empty, BTN_Floor.Checked);
            if (bit == null)
                return;
            if (bit.Height <= pictureBoxMulti.Height + hScrollBar.Height)
            {
                vScrollBar.Enabled = false;
                vScrollBar.Value = 0;
            }
            else
            {
                vScrollBar.Enabled = true;
                vScrollBar.Maximum = bit.Height - pictureBoxMulti.Height + 10;
            }
            if (bit.Width <= pictureBoxMulti.Width + vScrollBar.Width)
            {
                hScrollBar.Enabled = false;
                vScrollBar.Value = 0;
            }
            else
            {
                hScrollBar.Enabled = true;
                hScrollBar.Maximum = bit.Width - pictureBoxMulti.Width + 10;
            }
        }

        /// <summary>
        /// Scrollbars changed
        /// </summary>
        private void ScrollBarsValueChanged(object sender, EventArgs e)
        {
            pictureBoxMulti.Refresh();
        }

        /// <summary>
        /// Doubleclick Node of Import treeview
        /// </summary>
        private void treeViewMultiList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (MessageBox.Show("Do you want to open selected Multi?", "Open", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                compList = new MultiEditorComponentList(Ultima.Multis.GetComponents((int)e.Node.Tag), this);
                MaxHeightTrackBar.Minimum = compList.zMin;
                MaxHeightTrackBar.Maximum = compList.zMax;
                MaxHeightTrackBar.Value = compList.zMax;
                textBox_SaveToID.Text = e.Node.Tag.ToString();
                numericUpDown_Size_Width.Value = compList.Width;
                numericUpDown_Size_Height.Value = compList.Height;
                numericUpDown_Selected_X.Maximum = compList.Width - 1;
                numericUpDown_Selected_Y.Maximum = compList.Height - 1;
                ScrollbarsSetValue();
                pictureBoxMulti.Refresh();
            }
        }

        private void XML_AddChildren(TreeNode node, XmlElement mainNode)
        {
            foreach (XmlElement e in mainNode)
            {
                TreeNode tempNode = new TreeNode();

                tempNode.Text = e.GetAttribute("name");
                if (e.Name == "subgroup")
                {
                    tempNode.ImageIndex = 0;
                    if (e.HasChildNodes)
                    {
                        ArrayList list = new ArrayList();
                        foreach (XmlElement elem in e.ChildNodes)
                        {
                            int i = Int32.Parse(elem.GetAttribute("index"));
                            if (Ultima.Art.IsValidStatic(i))
                                list.Add(i);
                        }
                        tempNode.Tag = list;
                    }
                }

                node.Nodes.Add(tempNode);
            }
        }

        private void XML_InitializeToolBox()
        {
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string FileName = Path.Combine(path, @"plugins/multieditor.xml");
            if (!File.Exists(FileName))
                return;

            XmlDocument dom = new XmlDocument();
            dom.Load(FileName);
            XmlElement xTiles = dom["TileGroups"];

            foreach (XmlElement xRootGroup in xTiles)
            {
                TreeNode mainNode = new TreeNode();
                mainNode.Text = xRootGroup.GetAttribute("name");
                mainNode.Tag = null;

                mainNode.ImageIndex = 0;

                XML_AddChildren(mainNode, xRootGroup);

                treeViewTilesXML.Nodes.Add(mainNode);
            }
        }

		#endregion Methods 

        #region DrawTilesPictureBox Stuff
        private int GetIndex(int x, int y)
        {
            if (x >= pictureboxDrawTilescol)
                return -1;
            int value = Math.Max(0, ((pictureboxDrawTilescol * (vScrollBarDrawTiles.Value - 1)) + (x + (y * pictureboxDrawTilescol))));
            if (DrawTilesList.Count > value)
                return (int)DrawTilesList[value];
            else
                return -1;
        }

        private void pictureBoxDrawTiles_OnMouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxDrawTiles.Focus();
            int x = e.X / (DrawTileSizeWidth - 1);
            int y = e.Y / (DrawTileSizeHeight - 1);
            int index = GetIndex(x, y);
            if (index >= 0)
            {
                m_DrawTile.Set(index, 0);
                pictureBoxDrawTiles.Refresh();
            }
        }

        private void pictureBoxDrawTilesMouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / (DrawTileSizeWidth - 1);
            int y = e.Y / (DrawTileSizeHeight - 1);
            int index = GetIndex(x, y);
            if (index >= 0)
            {
                if (index != (int)FloatingPreviewPanel.Tag)
                {
                    FloatingPreviewPanel.BackgroundImage = Ultima.Art.GetStatic(index);
                    FloatingPreviewPanel.Size = new Size(Ultima.Art.GetStatic(index).Width + 10, Ultima.Art.GetStatic(index).Height + 10);
                }
                FloatingPreviewPanel.Left = PointToClient(MousePosition).X;
                FloatingPreviewPanel.Top = PointToClient(MousePosition).Y - FloatingPreviewPanel.Size.Height;
                FloatingPreviewPanel.Visible = true;
                FloatingPreviewPanel.Tag = index;
                toolTip1.SetToolTip(pictureBoxDrawTiles, String.Format("0x{0:X} ({0})", index));
            }
            else
            {
                FloatingPreviewPanel.Visible = false;
                toolTip1.RemoveAll();
            }
        }

        private void pictureBoxDrawTilesMouseLeave(object sender, EventArgs e)
        {
            FloatingPreviewPanel.Visible = false;
        }

        private void pictureBoxDrawTiles_OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (int y = 0; y < pictureboxDrawTilesrow; y++)
            {
                for (int x = 0; x < pictureboxDrawTilescol; x++)
                {
                    int index = GetIndex(x, y);
                    if (index >= 0)
                    {
                        Bitmap b = Art.GetStatic(index);

                        if (b != null)
                        {
                            Point loc = new Point((x * DrawTileSizeWidth) + 1, (y * DrawTileSizeHeight) + 1);
                            Size size = new Size(DrawTileSizeWidth - 1, DrawTileSizeHeight - 1);
                            Rectangle rect = new Rectangle(loc, size);

                            e.Graphics.Clip = new Region(rect);

                            if (index == m_DrawTile.ID)
                                e.Graphics.FillRectangle(Brushes.LightBlue, rect);

                            int width = b.Width;
                            int height = b.Height;
                            if (width > size.Width)
                            {
                                width = size.Width;
                                height = size.Height * b.Height / b.Width;
                            }
                            if (height > size.Height)
                            {
                                height = size.Height;
                                width = size.Width * b.Width / b.Height;
                            }
                            e.Graphics.DrawImage(b, new Rectangle(loc, new Size(width, height)));
                        }
                    }
                }
            }
        }

        private void pictureBoxDrawTiles_OnResize(object sender, EventArgs e)
        {
            if ((pictureBoxDrawTiles.Height == 0) || (pictureBoxDrawTiles.Width == 0))
                return;
            pictureboxDrawTilescol = pictureBoxDrawTiles.Width / DrawTileSizeWidth;
            pictureboxDrawTilesrow = pictureBoxDrawTiles.Height / DrawTileSizeHeight + 1;
            vScrollBarDrawTiles.Maximum = DrawTilesList.Count / pictureboxDrawTilescol + 1;
            vScrollBarDrawTiles.Minimum = 1;
            vScrollBarDrawTiles.SmallChange = 1;
            vScrollBarDrawTiles.LargeChange = pictureboxDrawTilesrow;
            pictureBoxDrawTiles.Refresh();
        }

        private void vScrollBarDrawTiles_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBoxDrawTiles.Refresh();
        }

        private void pictureBoxDrawTiles_OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                if (vScrollBarDrawTiles.Value < vScrollBarDrawTiles.Maximum)
                {
                    vScrollBarDrawTiles.Value++;
                    pictureBoxDrawTiles.Refresh();
                }
            }
            else
            {
                if (vScrollBarDrawTiles.Value > 1)
                {
                    vScrollBarDrawTiles.Value--;
                    pictureBoxDrawTiles.Refresh();
                }
            }
        }
        #endregion
    }
}