/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

namespace Controls
{
    partial class Dress
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeViewItems = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.LayerSort = new System.Windows.Forms.CheckBox();
            this.checkBoxElve = new System.Windows.Forms.CheckBox();
            this.checkBoxfemale = new System.Windows.Forms.CheckBox();
            this.buttonDress = new System.Windows.Forms.Button();
            this.pictureBoxDress = new System.Windows.Forms.PictureBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.checkedListBoxWear = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unDressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBoxAnimate = new System.Windows.Forms.GroupBox();
            this.ActionBar = new System.Windows.Forms.TrackBar();
            this.FacingBar = new System.Windows.Forms.TrackBar();
            this.DressPic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDress)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBoxAnimate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DressPic)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(619, 324);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeViewItems);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(279, 324);
            this.splitContainer2.SplitterDistance = 169;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeViewItems
            // 
            this.treeViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewItems.Location = new System.Drawing.Point(0, 0);
            this.treeViewItems.Name = "treeViewItems";
            this.treeViewItems.Size = new System.Drawing.Size(169, 324);
            this.treeViewItems.TabIndex = 0;
            this.treeViewItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfterSelectTreeView);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.LayerSort);
            this.splitContainer3.Panel1.Controls.Add(this.checkBoxElve);
            this.splitContainer3.Panel1.Controls.Add(this.checkBoxfemale);
            this.splitContainer3.Panel1.Controls.Add(this.buttonDress);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBoxDress);
            this.splitContainer3.Size = new System.Drawing.Size(106, 324);
            this.splitContainer3.SplitterDistance = 111;
            this.splitContainer3.TabIndex = 0;
            // 
            // LayerSort
            // 
            this.LayerSort.AutoSize = true;
            this.LayerSort.Location = new System.Drawing.Point(15, 91);
            this.LayerSort.Name = "LayerSort";
            this.LayerSort.Size = new System.Drawing.Size(74, 17);
            this.LayerSort.TabIndex = 3;
            this.LayerSort.Text = "Layer Sort";
            this.LayerSort.UseVisualStyleBackColor = true;
            this.LayerSort.CheckedChanged += new System.EventHandler(this.OnChangeSort);
            // 
            // checkBoxElve
            // 
            this.checkBoxElve.AutoSize = true;
            this.checkBoxElve.Location = new System.Drawing.Point(15, 71);
            this.checkBoxElve.Name = "checkBoxElve";
            this.checkBoxElve.Size = new System.Drawing.Size(38, 17);
            this.checkBoxElve.TabIndex = 2;
            this.checkBoxElve.Text = "Elf";
            this.checkBoxElve.UseVisualStyleBackColor = true;
            this.checkBoxElve.CheckedChanged += new System.EventHandler(this.OnChangeElve);
            // 
            // checkBoxfemale
            // 
            this.checkBoxfemale.AutoSize = true;
            this.checkBoxfemale.Location = new System.Drawing.Point(15, 47);
            this.checkBoxfemale.Name = "checkBoxfemale";
            this.checkBoxfemale.Size = new System.Drawing.Size(60, 17);
            this.checkBoxfemale.TabIndex = 1;
            this.checkBoxfemale.Text = "Female";
            this.checkBoxfemale.UseVisualStyleBackColor = true;
            this.checkBoxfemale.CheckedChanged += new System.EventHandler(this.OnChangeFemale);
            // 
            // buttonDress
            // 
            this.buttonDress.Location = new System.Drawing.Point(15, 17);
            this.buttonDress.Name = "buttonDress";
            this.buttonDress.Size = new System.Drawing.Size(75, 23);
            this.buttonDress.TabIndex = 0;
            this.buttonDress.Text = "Dress Item";
            this.buttonDress.UseVisualStyleBackColor = true;
            this.buttonDress.Click += new System.EventHandler(this.OnClick_Dress);
            // 
            // pictureBoxDress
            // 
            this.pictureBoxDress.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDress.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDress.Name = "pictureBoxDress";
            this.pictureBoxDress.Size = new System.Drawing.Size(106, 209);
            this.pictureBoxDress.TabIndex = 0;
            this.pictureBoxDress.TabStop = false;
            this.pictureBoxDress.SizeChanged += new System.EventHandler(this.OnResizepictureDress);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.checkedListBoxWear);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(336, 324);
            this.splitContainer4.SplitterDistance = 139;
            this.splitContainer4.TabIndex = 1;
            // 
            // checkedListBoxWear
            // 
            this.checkedListBoxWear.ContextMenuStrip = this.contextMenuStrip1;
            this.checkedListBoxWear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxWear.FormattingEnabled = true;
            this.checkedListBoxWear.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxWear.Name = "checkedListBoxWear";
            this.checkedListBoxWear.Size = new System.Drawing.Size(139, 319);
            this.checkedListBoxWear.TabIndex = 0;
            this.checkedListBoxWear.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Change);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unDressToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 26);
            // 
            // unDressToolStripMenuItem
            // 
            this.unDressToolStripMenuItem.Name = "unDressToolStripMenuItem";
            this.unDressToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.unDressToolStripMenuItem.Text = "UnDress";
            this.unDressToolStripMenuItem.Click += new System.EventHandler(this.OnClick_UnDress);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBoxAnimate);
            this.splitContainer5.Panel1.Controls.Add(this.DressPic);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.TextBox);
            this.splitContainer5.Size = new System.Drawing.Size(193, 324);
            this.splitContainer5.SplitterDistance = 250;
            this.splitContainer5.TabIndex = 1;
            // 
            // groupBoxAnimate
            // 
            this.groupBoxAnimate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAnimate.Controls.Add(this.ActionBar);
            this.groupBoxAnimate.Controls.Add(this.FacingBar);
            this.groupBoxAnimate.Location = new System.Drawing.Point(0, 150);
            this.groupBoxAnimate.Name = "groupBoxAnimate";
            this.groupBoxAnimate.Size = new System.Drawing.Size(190, 97);
            this.groupBoxAnimate.TabIndex = 1;
            this.groupBoxAnimate.TabStop = false;
            this.groupBoxAnimate.Text = "Facing/Action";
            // 
            // ActionBar
            // 
            this.ActionBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionBar.AutoSize = false;
            this.ActionBar.Location = new System.Drawing.Point(2, 53);
            this.ActionBar.Maximum = 34;
            this.ActionBar.Name = "ActionBar";
            this.ActionBar.Size = new System.Drawing.Size(185, 35);
            this.ActionBar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ActionBar, "0 Walk_01");
            this.ActionBar.Scroll += new System.EventHandler(this.OnScroll_Action);
            // 
            // FacingBar
            // 
            this.FacingBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FacingBar.AutoSize = false;
            this.FacingBar.Location = new System.Drawing.Point(2, 20);
            this.FacingBar.Maximum = 7;
            this.FacingBar.Name = "FacingBar";
            this.FacingBar.Size = new System.Drawing.Size(185, 36);
            this.FacingBar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.FacingBar, "1");
            this.FacingBar.Scroll += new System.EventHandler(this.OnScroll_Facing);
            // 
            // DressPic
            // 
            this.DressPic.ContextMenuStrip = this.contextMenuStrip2;
            this.DressPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DressPic.Location = new System.Drawing.Point(0, 0);
            this.DressPic.Name = "DressPic";
            this.DressPic.Size = new System.Drawing.Size(193, 250);
            this.DressPic.TabIndex = 0;
            this.DressPic.TabStop = false;
            this.DressPic.SizeChanged += new System.EventHandler(this.OnResizeDressPic);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAnimationToolStripMenuItem,
            this.animateToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(162, 48);
            // 
            // showAnimationToolStripMenuItem
            // 
            this.showAnimationToolStripMenuItem.Name = "showAnimationToolStripMenuItem";
            this.showAnimationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showAnimationToolStripMenuItem.Text = "Show Animation";
            this.showAnimationToolStripMenuItem.Click += new System.EventHandler(this.OnClick_ChangeDisplay);
            // 
            // animateToolStripMenuItem
            // 
            this.animateToolStripMenuItem.Name = "animateToolStripMenuItem";
            this.animateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.animateToolStripMenuItem.Text = "Animate";
            this.animateToolStripMenuItem.Click += new System.EventHandler(this.OnClick_Animate);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(193, 70);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // Dress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Dress";
            this.Size = new System.Drawing.Size(619, 324);
            this.Load += new System.EventHandler(this.OnLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDress)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.groupBoxAnimate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DressPic)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox DressPic;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeViewItems;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pictureBoxDress;
        private System.Windows.Forms.CheckBox checkBoxfemale;
        private System.Windows.Forms.Button buttonDress;
        private System.Windows.Forms.CheckBox checkBoxElve;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.CheckedListBox checkedListBoxWear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unDressToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.CheckBox LayerSort;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animateToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxAnimate;
        private System.Windows.Forms.TrackBar FacingBar;
        private System.Windows.Forms.TrackBar ActionBar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
