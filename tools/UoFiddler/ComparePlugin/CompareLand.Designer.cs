﻿/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

namespace ComparePlugin
{
    partial class CompareLand
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxOrg = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSec = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrg = new System.Windows.Forms.PictureBox();
            this.textBoxSecondDir = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxSec = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asBmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asTiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOrg
            // 
            this.listBoxOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOrg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxOrg.FormattingEnabled = true;
            this.listBoxOrg.IntegralHeight = false;
            this.listBoxOrg.Location = new System.Drawing.Point(3, 3);
            this.listBoxOrg.Name = "listBoxOrg";
            this.listBoxOrg.Size = new System.Drawing.Size(160, 321);
            this.listBoxOrg.TabIndex = 0;
            this.listBoxOrg.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawitemOrg);
            this.listBoxOrg.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MeasureOrg);
            this.listBoxOrg.SelectedIndexChanged += new System.EventHandler(this.OnIndexChangedOrg);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxSec, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxOrg, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(169, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 321);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBoxSec
            // 
            this.pictureBoxSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSec.Location = new System.Drawing.Point(4, 164);
            this.pictureBoxSec.Name = "pictureBoxSec";
            this.pictureBoxSec.Size = new System.Drawing.Size(264, 153);
            this.pictureBoxSec.TabIndex = 3;
            this.pictureBoxSec.TabStop = false;
            // 
            // pictureBoxOrg
            // 
            this.pictureBoxOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOrg.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxOrg.Name = "pictureBoxOrg";
            this.pictureBoxOrg.Size = new System.Drawing.Size(264, 153);
            this.pictureBoxOrg.TabIndex = 2;
            this.pictureBoxOrg.TabStop = false;
            // 
            // textBoxSecondDir
            // 
            this.textBoxSecondDir.Location = new System.Drawing.Point(124, 11);
            this.textBoxSecondDir.Name = "textBoxSecondDir";
            this.textBoxSecondDir.Size = new System.Drawing.Size(145, 20);
            this.textBoxSecondDir.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxOrg, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxSec, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(612, 327);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // listBoxSec
            // 
            this.listBoxSec.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxSec.FormattingEnabled = true;
            this.listBoxSec.IntegralHeight = false;
            this.listBoxSec.Location = new System.Drawing.Point(447, 3);
            this.listBoxSec.Name = "listBoxSec";
            this.listBoxSec.Size = new System.Drawing.Size(162, 321);
            this.listBoxSec.TabIndex = 1;
            this.listBoxSec.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItemSec);
            this.listBoxSec.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MeasureSec);
            this.listBoxSec.SelectedIndexChanged += new System.EventHandler(this.OnIndexChangedSec);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(362, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show only Differences";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.OnChangeShowDiff);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(275, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load Second";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickLoadSecond);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSecondDir);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(612, 372);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportImageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 26);
            // 
            // exportImageToolStripMenuItem
            // 
            this.exportImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asBmpToolStripMenuItem,
            this.asTiffToolStripMenuItem});
            this.exportImageToolStripMenuItem.Name = "exportImageToolStripMenuItem";
            this.exportImageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportImageToolStripMenuItem.Text = "Export Image..";
            // 
            // asBmpToolStripMenuItem
            // 
            this.asBmpToolStripMenuItem.Name = "asBmpToolStripMenuItem";
            this.asBmpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asBmpToolStripMenuItem.Text = "As Bmp";
            this.asBmpToolStripMenuItem.Click += new System.EventHandler(this.ExportAsBmp);
            // 
            // asTiffToolStripMenuItem
            // 
            this.asTiffToolStripMenuItem.Name = "asTiffToolStripMenuItem";
            this.asTiffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asTiffToolStripMenuItem.Text = "As Tiff";
            this.asTiffToolStripMenuItem.Click += new System.EventHandler(this.ExportAsTiff);
            // 
            // CompareLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CompareLand";
            this.Size = new System.Drawing.Size(612, 372);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxSec;
        private System.Windows.Forms.PictureBox pictureBoxOrg;
        private System.Windows.Forms.TextBox textBoxSecondDir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxSec;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asBmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asTiffToolStripMenuItem;
    }
}
