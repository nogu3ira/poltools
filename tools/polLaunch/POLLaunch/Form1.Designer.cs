﻿namespace POLLaunch
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CB_StraightToPOL = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_RunTests = new System.Windows.Forms.Button();
            this.TB_RunTests = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BTN_UOConvert = new System.Windows.Forms.Button();
            this.UOConvertGroupBox = new System.Windows.Forms.GroupBox();
            this.PNL_UOCSettings = new System.Windows.Forms.Panel();
            this.BTN_MULBrowse = new System.Windows.Forms.Button();
            this.TB_MULFilePath = new System.Windows.Forms.TextBox();
            this.LBL_UOCMulFilePath = new System.Windows.Forms.Label();
            this.LBL_UOCSettingsHeader = new System.Windows.Forms.Label();
            this.PNL_UOCConfigFiles = new System.Windows.Forms.Panel();
            this.CB_TileData = new System.Windows.Forms.CheckBox();
            this.CB_LandTiles = new System.Windows.Forms.CheckBox();
            this.CB_Multis = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_TokDif = new System.Windows.Forms.CheckBox();
            this.CB_MalDif = new System.Windows.Forms.CheckBox();
            this.CB_IlshDif = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_TramDif = new System.Windows.Forms.CheckBox();
            this.CB_BritMLDif = new System.Windows.Forms.CheckBox();
            this.CB_BritT2ADif = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_MalMap = new System.Windows.Forms.CheckBox();
            this.CB_TokMap = new System.Windows.Forms.CheckBox();
            this.CB_IlshMap = new System.Windows.Forms.CheckBox();
            this.CB_TramMap = new System.Windows.Forms.CheckBox();
            this.CB_BritT2AMap = new System.Windows.Forms.CheckBox();
            this.CB_BritMLMap = new System.Windows.Forms.CheckBox();
            this.TB_UOCOutput = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BTN_ECompile = new System.Windows.Forms.Button();
            this.TB_ECompile = new System.Windows.Forms.TextBox();
            this.GB_PackageRootEditor = new System.Windows.Forms.GroupBox();
            this.DGV_PackageRoot = new System.Windows.Forms.DataGridView();
            this.BTN_ECompilePackageRootEditorFinished = new System.Windows.Forms.Button();
            this.GB_ECompile = new System.Windows.Forms.GroupBox();
            this.PNL_ECompilePaths = new System.Windows.Forms.Panel();
            this.TB_ECompilePolScriptRoot = new System.Windows.Forms.TextBox();
            this.TB_ECompileIncludeDirectory = new System.Windows.Forms.TextBox();
            this.TB_ECompileModuleDirectory = new System.Windows.Forms.TextBox();
            this.LBL_ECompileFlags = new System.Windows.Forms.Label();
            this.PNL_ECompileLoadSave = new System.Windows.Forms.Panel();
            this.BTN_ECompileSave = new System.Windows.Forms.Button();
            this.BTN_EcompileLoad = new System.Windows.Forms.Button();
            this.LBL_ECompileLoadSave = new System.Windows.Forms.Label();
            this.PNL_ECompileSave = new System.Windows.Forms.Panel();
            this.BTN_ECompilePathsEdit = new System.Windows.Forms.Button();
            this.LBL_ECompilePackageRoots = new System.Windows.Forms.Label();
            this.BTN_ECompilePackageRoots = new System.Windows.Forms.Button();
            this.PNL_ECompileFlags = new System.Windows.Forms.Panel();
            this.CB_ECompileFlagDisplayUpToDateScripts = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagGenerateDependencyInfo = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagDisplaySummary = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagOnlyCompileUpdatedScripts = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagAutoCompileByDefault = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagCompileAspPages = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagDisplayWarnings = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagGenerateDebugTextInfo = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagGenerateListing = new System.Windows.Forms.CheckBox();
            this.CB_ECompileFlagGenerateDebugInfo = new System.Windows.Forms.CheckBox();
            this.GB_ECompilePathsEdit = new System.Windows.Forms.GroupBox();
            this.BTN_ECompileEditPathsScripts = new System.Windows.Forms.Button();
            this.BTN_ECompileEditPathsIncludes = new System.Windows.Forms.Button();
            this.BTN_ECompileEditPathsModules = new System.Windows.Forms.Button();
            this.PNL_ECompilePathsEditTBS = new System.Windows.Forms.Panel();
            this.TB_ECompilePathsEditPolScriptRoot = new System.Windows.Forms.TextBox();
            this.TB_ECompilePathsEditIncludeDirectory = new System.Windows.Forms.TextBox();
            this.TB_ECompilePathsEditModuleDirectory = new System.Windows.Forms.TextBox();
            this.LBL_ECompilePathsEditScriptRoot = new System.Windows.Forms.Label();
            this.LBL_ECompilePathsEditIncludes = new System.Windows.Forms.Label();
            this.LBL_ECompilePathsEditModules = new System.Windows.Forms.Label();
            this.BTN_ECompilePathsEditDone = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BTN_StopPOL = new System.Windows.Forms.Button();
            this.CB_POLScrollBar = new System.Windows.Forms.CheckBox();
            this.BTN_StartPOL = new System.Windows.Forms.Button();
            this.txtPOLConsole = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.GB_DataBackup = new System.Windows.Forms.GroupBox();
            this.GB_ModifyAccount = new System.Windows.Forms.GroupBox();
            this.GB_AuxSvcSettings = new System.Windows.Forms.GroupBox();
            this.TB_ModifyAuxPassword = new System.Windows.Forms.TextBox();
            this.TB_ModifyPort = new System.Windows.Forms.TextBox();
            this.LBL_ModifyPassword = new System.Windows.Forms.Label();
            this.LBL_ModifyPort = new System.Windows.Forms.Label();
            this.TB_CreateAuxPassword = new System.Windows.Forms.TextBox();
            this.LBL_AuxSvcPassword = new System.Windows.Forms.Label();
            this.TB_CreateAccountPort = new System.Windows.Forms.TextBox();
            this.LBL_CreatePort = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LBL_AccountsHeader2 = new System.Windows.Forms.Label();
            this.LBL_AccountsHeader1 = new System.Windows.Forms.Label();
            this.GB_CreateAccount = new System.Windows.Forms.GroupBox();
            this.BTN_CreateAccount = new System.Windows.Forms.Button();
            this.TB_CreateEmail = new System.Windows.Forms.TextBox();
            this.LBL_CreateEmail = new System.Windows.Forms.Label();
            this.LBX_CreateExpansion = new System.Windows.Forms.ListBox();
            this.LBL_CreateExpansion = new System.Windows.Forms.Label();
            this.LBL_CreateCmdlevel = new System.Windows.Forms.Label();
            this.LBX_CreateCmdlevel = new System.Windows.Forms.ListBox();
            this.TB_CreatePassword = new System.Windows.Forms.TextBox();
            this.LBL_CreatePassword = new System.Windows.Forms.Label();
            this.TB_CreateUsername = new System.Windows.Forms.TextBox();
            this.LBL_CreateUsername = new System.Windows.Forms.Label();
            this.PackageRootPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageRootBrowseButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PackageRootDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PackageRootAddButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BTN_ECompilePackageRootEditorCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.UOConvertGroupBox.SuspendLayout();
            this.PNL_UOCSettings.SuspendLayout();
            this.PNL_UOCConfigFiles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.GB_PackageRootEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PackageRoot)).BeginInit();
            this.GB_ECompile.SuspendLayout();
            this.PNL_ECompilePaths.SuspendLayout();
            this.PNL_ECompileLoadSave.SuspendLayout();
            this.PNL_ECompileSave.SuspendLayout();
            this.PNL_ECompileFlags.SuspendLayout();
            this.GB_ECompilePathsEdit.SuspendLayout();
            this.PNL_ECompilePathsEditTBS.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.GB_AuxSvcSettings.SuspendLayout();
            this.panel3.SuspendLayout();
            this.GB_CreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "POL Launcher";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(679, 16);
            this.ProgressBar.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 418);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.CB_StraightToPOL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Introduction";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(9, 7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(659, 341);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // CB_StraightToPOL
            // 
            this.CB_StraightToPOL.AutoSize = true;
            this.CB_StraightToPOL.Location = new System.Drawing.Point(9, 362);
            this.CB_StraightToPOL.Name = "CB_StraightToPOL";
            this.CB_StraightToPOL.Size = new System.Drawing.Size(243, 17);
            this.CB_StraightToPOL.TabIndex = 1;
            this.CB_StraightToPOL.Text = "In future instances, go straight to the POL tab.";
            this.CB_StraightToPOL.UseVisualStyleBackColor = true;
            this.CB_StraightToPOL.CheckStateChanged += new System.EventHandler(this.CB_StraightToPOL_CheckStateChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.tabPage2.Controls.Add(this.BTN_RunTests);
            this.tabPage2.Controls.Add(this.TB_RunTests);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Initial Checks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_RunTests
            // 
            this.BTN_RunTests.Location = new System.Drawing.Point(301, 363);
            this.BTN_RunTests.Name = "BTN_RunTests";
            this.BTN_RunTests.Size = new System.Drawing.Size(75, 23);
            this.BTN_RunTests.TabIndex = 1;
            this.BTN_RunTests.Text = "Run Tests";
            this.BTN_RunTests.UseVisualStyleBackColor = true;
            this.BTN_RunTests.Click += new System.EventHandler(this.BTN_RunTests_Click);
            // 
            // TB_RunTests
            // 
            this.TB_RunTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.TB_RunTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_RunTests.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.TB_RunTests.ForeColor = System.Drawing.Color.Black;
            this.TB_RunTests.Location = new System.Drawing.Point(7, 6);
            this.TB_RunTests.Multiline = true;
            this.TB_RunTests.Name = "TB_RunTests";
            this.TB_RunTests.Size = new System.Drawing.Size(661, 351);
            this.TB_RunTests.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.tabPage3.Controls.Add(this.BTN_UOConvert);
            this.tabPage3.Controls.Add(this.UOConvertGroupBox);
            this.tabPage3.Controls.Add(this.TB_UOCOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(676, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UOConvert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BTN_UOConvert
            // 
            this.BTN_UOConvert.Location = new System.Drawing.Point(301, 363);
            this.BTN_UOConvert.Name = "BTN_UOConvert";
            this.BTN_UOConvert.Size = new System.Drawing.Size(75, 23);
            this.BTN_UOConvert.TabIndex = 4;
            this.BTN_UOConvert.Text = "Convert";
            this.BTN_UOConvert.UseVisualStyleBackColor = true;
            this.BTN_UOConvert.Click += new System.EventHandler(this.BTN_UOConvert_Click);
            // 
            // UOConvertGroupBox
            // 
            this.UOConvertGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.UOConvertGroupBox.Controls.Add(this.PNL_UOCSettings);
            this.UOConvertGroupBox.Controls.Add(this.PNL_UOCConfigFiles);
            this.UOConvertGroupBox.Controls.Add(this.panel1);
            this.UOConvertGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UOConvertGroupBox.Location = new System.Drawing.Point(7, 225);
            this.UOConvertGroupBox.Name = "UOConvertGroupBox";
            this.UOConvertGroupBox.Size = new System.Drawing.Size(661, 132);
            this.UOConvertGroupBox.TabIndex = 3;
            this.UOConvertGroupBox.TabStop = false;
            this.UOConvertGroupBox.Text = "UOConvert Controls";
            // 
            // PNL_UOCSettings
            // 
            this.PNL_UOCSettings.Controls.Add(this.BTN_MULBrowse);
            this.PNL_UOCSettings.Controls.Add(this.TB_MULFilePath);
            this.PNL_UOCSettings.Controls.Add(this.LBL_UOCMulFilePath);
            this.PNL_UOCSettings.Controls.Add(this.LBL_UOCSettingsHeader);
            this.PNL_UOCSettings.Location = new System.Drawing.Point(414, 73);
            this.PNL_UOCSettings.Name = "PNL_UOCSettings";
            this.PNL_UOCSettings.Size = new System.Drawing.Size(239, 54);
            this.PNL_UOCSettings.TabIndex = 8;
            // 
            // BTN_MULBrowse
            // 
            this.BTN_MULBrowse.Location = new System.Drawing.Point(162, 19);
            this.BTN_MULBrowse.Name = "BTN_MULBrowse";
            this.BTN_MULBrowse.Size = new System.Drawing.Size(75, 23);
            this.BTN_MULBrowse.TabIndex = 3;
            this.BTN_MULBrowse.Text = "Browse";
            this.BTN_MULBrowse.UseVisualStyleBackColor = true;
            this.BTN_MULBrowse.Click += new System.EventHandler(this.BTN_MULBrowse_Click);
            // 
            // TB_MULFilePath
            // 
            this.TB_MULFilePath.Location = new System.Drawing.Point(41, 19);
            this.TB_MULFilePath.Name = "TB_MULFilePath";
            this.TB_MULFilePath.Size = new System.Drawing.Size(115, 20);
            this.TB_MULFilePath.TabIndex = 2;
            this.TB_MULFilePath.TextChanged += new System.EventHandler(this.TB_MULFilePath_TextChanged);
            // 
            // LBL_UOCMulFilePath
            // 
            this.LBL_UOCMulFilePath.AutoSize = true;
            this.LBL_UOCMulFilePath.Location = new System.Drawing.Point(3, 21);
            this.LBL_UOCMulFilePath.Name = "LBL_UOCMulFilePath";
            this.LBL_UOCMulFilePath.Size = new System.Drawing.Size(32, 13);
            this.LBL_UOCMulFilePath.TabIndex = 1;
            this.LBL_UOCMulFilePath.Text = "Path:";
            // 
            // LBL_UOCSettingsHeader
            // 
            this.LBL_UOCSettingsHeader.AutoSize = true;
            this.LBL_UOCSettingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UOCSettingsHeader.Location = new System.Drawing.Point(52, 5);
            this.LBL_UOCSettingsHeader.Name = "LBL_UOCSettingsHeader";
            this.LBL_UOCSettingsHeader.Size = new System.Drawing.Size(137, 13);
            this.LBL_UOCSettingsHeader.TabIndex = 0;
            this.LBL_UOCSettingsHeader.Text = "Path to UO Client Data";
            // 
            // PNL_UOCConfigFiles
            // 
            this.PNL_UOCConfigFiles.Controls.Add(this.CB_TileData);
            this.PNL_UOCConfigFiles.Controls.Add(this.CB_LandTiles);
            this.PNL_UOCConfigFiles.Controls.Add(this.CB_Multis);
            this.PNL_UOCConfigFiles.Controls.Add(this.label2);
            this.PNL_UOCConfigFiles.Location = new System.Drawing.Point(414, 19);
            this.PNL_UOCConfigFiles.Name = "PNL_UOCConfigFiles";
            this.PNL_UOCConfigFiles.Size = new System.Drawing.Size(239, 51);
            this.PNL_UOCConfigFiles.TabIndex = 7;
            // 
            // CB_TileData
            // 
            this.CB_TileData.AutoSize = true;
            this.CB_TileData.Location = new System.Drawing.Point(15, 31);
            this.CB_TileData.Name = "CB_TileData";
            this.CB_TileData.Size = new System.Drawing.Size(69, 17);
            this.CB_TileData.TabIndex = 3;
            this.CB_TileData.Text = "Tile Data";
            this.CB_TileData.UseVisualStyleBackColor = true;
            // 
            // CB_LandTiles
            // 
            this.CB_LandTiles.AutoSize = true;
            this.CB_LandTiles.Location = new System.Drawing.Point(149, 31);
            this.CB_LandTiles.Name = "CB_LandTiles";
            this.CB_LandTiles.Size = new System.Drawing.Size(75, 17);
            this.CB_LandTiles.TabIndex = 2;
            this.CB_LandTiles.Text = "Land Tiles";
            this.CB_LandTiles.UseVisualStyleBackColor = true;
            // 
            // CB_Multis
            // 
            this.CB_Multis.AutoSize = true;
            this.CB_Multis.Location = new System.Drawing.Point(90, 31);
            this.CB_Multis.Name = "CB_Multis";
            this.CB_Multis.Size = new System.Drawing.Size(53, 17);
            this.CB_Multis.TabIndex = 1;
            this.CB_Multis.Text = "Multis";
            this.CB_Multis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Config Files to Generate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CB_TokDif);
            this.panel1.Controls.Add(this.CB_MalDif);
            this.panel1.Controls.Add(this.CB_IlshDif);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CB_TramDif);
            this.panel1.Controls.Add(this.CB_BritMLDif);
            this.panel1.Controls.Add(this.CB_BritT2ADif);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_MalMap);
            this.panel1.Controls.Add(this.CB_TokMap);
            this.panel1.Controls.Add(this.CB_IlshMap);
            this.panel1.Controls.Add(this.CB_TramMap);
            this.panel1.Controls.Add(this.CB_BritT2AMap);
            this.panel1.Controls.Add(this.CB_BritMLMap);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 107);
            this.panel1.TabIndex = 6;
            // 
            // CB_TokDif
            // 
            this.CB_TokDif.AutoSize = true;
            this.CB_TokDif.Enabled = false;
            this.CB_TokDif.Location = new System.Drawing.Point(247, 73);
            this.CB_TokDif.Name = "CB_TokDif";
            this.CB_TokDif.Size = new System.Drawing.Size(63, 17);
            this.CB_TokDif.TabIndex = 16;
            this.CB_TokDif.Text = "Tokuno";
            this.CB_TokDif.UseVisualStyleBackColor = true;
            // 
            // CB_MalDif
            // 
            this.CB_MalDif.AutoSize = true;
            this.CB_MalDif.Enabled = false;
            this.CB_MalDif.Location = new System.Drawing.Point(247, 54);
            this.CB_MalDif.Name = "CB_MalDif";
            this.CB_MalDif.Size = new System.Drawing.Size(54, 17);
            this.CB_MalDif.TabIndex = 15;
            this.CB_MalDif.Text = "Malas";
            this.CB_MalDif.UseVisualStyleBackColor = true;
            // 
            // CB_IlshDif
            // 
            this.CB_IlshDif.AutoSize = true;
            this.CB_IlshDif.Enabled = false;
            this.CB_IlshDif.Location = new System.Drawing.Point(247, 34);
            this.CB_IlshDif.Name = "CB_IlshDif";
            this.CB_IlshDif.Size = new System.Drawing.Size(63, 17);
            this.CB_IlshDif.TabIndex = 14;
            this.CB_IlshDif.Text = "Ilshenar";
            this.CB_IlshDif.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "UseDif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Map";
            // 
            // CB_TramDif
            // 
            this.CB_TramDif.AutoSize = true;
            this.CB_TramDif.Enabled = false;
            this.CB_TramDif.Location = new System.Drawing.Point(41, 74);
            this.CB_TramDif.Name = "CB_TramDif";
            this.CB_TramDif.Size = new System.Drawing.Size(66, 17);
            this.CB_TramDif.TabIndex = 11;
            this.CB_TramDif.Text = "Trammel";
            this.CB_TramDif.UseVisualStyleBackColor = true;
            // 
            // CB_BritMLDif
            // 
            this.CB_BritMLDif.AutoSize = true;
            this.CB_BritMLDif.Enabled = false;
            this.CB_BritMLDif.Location = new System.Drawing.Point(41, 53);
            this.CB_BritMLDif.Name = "CB_BritMLDif";
            this.CB_BritMLDif.Size = new System.Drawing.Size(138, 17);
            this.CB_BritMLDif.TabIndex = 10;
            this.CB_BritMLDif.Text = "Britannia (ML Size Map)";
            this.CB_BritMLDif.UseVisualStyleBackColor = true;
            // 
            // CB_BritT2ADif
            // 
            this.CB_BritT2ADif.AutoSize = true;
            this.CB_BritT2ADif.Enabled = false;
            this.CB_BritT2ADif.Location = new System.Drawing.Point(41, 34);
            this.CB_BritT2ADif.Name = "CB_BritT2ADif";
            this.CB_BritT2ADif.Size = new System.Drawing.Size(143, 17);
            this.CB_BritT2ADif.TabIndex = 9;
            this.CB_BritT2ADif.Text = "Britannia (T2A Size Map)";
            this.CB_BritT2ADif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "UseDif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Map";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maps To Convert";
            // 
            // CB_MalMap
            // 
            this.CB_MalMap.AutoSize = true;
            this.CB_MalMap.Location = new System.Drawing.Point(213, 53);
            this.CB_MalMap.Name = "CB_MalMap";
            this.CB_MalMap.Size = new System.Drawing.Size(15, 14);
            this.CB_MalMap.TabIndex = 4;
            this.CB_MalMap.UseVisualStyleBackColor = true;
            this.CB_MalMap.CheckedChanged += new System.EventHandler(this.CB_MalMap_CheckedChanged);
            // 
            // CB_TokMap
            // 
            this.CB_TokMap.AutoSize = true;
            this.CB_TokMap.Location = new System.Drawing.Point(213, 73);
            this.CB_TokMap.Name = "CB_TokMap";
            this.CB_TokMap.Size = new System.Drawing.Size(15, 14);
            this.CB_TokMap.TabIndex = 5;
            this.CB_TokMap.UseVisualStyleBackColor = true;
            this.CB_TokMap.CheckedChanged += new System.EventHandler(this.CB_TokMap_CheckedChanged);
            // 
            // CB_IlshMap
            // 
            this.CB_IlshMap.AutoSize = true;
            this.CB_IlshMap.Location = new System.Drawing.Point(213, 34);
            this.CB_IlshMap.Name = "CB_IlshMap";
            this.CB_IlshMap.Size = new System.Drawing.Size(15, 14);
            this.CB_IlshMap.TabIndex = 3;
            this.CB_IlshMap.UseVisualStyleBackColor = true;
            this.CB_IlshMap.CheckedChanged += new System.EventHandler(this.CB_IlshMap_CheckedChanged);
            // 
            // CB_TramMap
            // 
            this.CB_TramMap.AutoSize = true;
            this.CB_TramMap.Location = new System.Drawing.Point(7, 74);
            this.CB_TramMap.Name = "CB_TramMap";
            this.CB_TramMap.Size = new System.Drawing.Size(15, 14);
            this.CB_TramMap.TabIndex = 2;
            this.CB_TramMap.UseVisualStyleBackColor = true;
            this.CB_TramMap.CheckedChanged += new System.EventHandler(this.CB_TramMap_CheckedChanged);
            // 
            // CB_BritT2AMap
            // 
            this.CB_BritT2AMap.AutoSize = true;
            this.CB_BritT2AMap.Location = new System.Drawing.Point(7, 34);
            this.CB_BritT2AMap.Name = "CB_BritT2AMap";
            this.CB_BritT2AMap.Size = new System.Drawing.Size(15, 14);
            this.CB_BritT2AMap.TabIndex = 0;
            this.CB_BritT2AMap.UseVisualStyleBackColor = true;
            this.CB_BritT2AMap.CheckedChanged += new System.EventHandler(this.CB_BritT2AMap_CheckedChanged);
            // 
            // CB_BritMLMap
            // 
            this.CB_BritMLMap.AutoSize = true;
            this.CB_BritMLMap.Location = new System.Drawing.Point(7, 54);
            this.CB_BritMLMap.Name = "CB_BritMLMap";
            this.CB_BritMLMap.Size = new System.Drawing.Size(15, 14);
            this.CB_BritMLMap.TabIndex = 1;
            this.CB_BritMLMap.UseVisualStyleBackColor = true;
            this.CB_BritMLMap.CheckedChanged += new System.EventHandler(this.CB_BritMLMap_CheckedChanged);
            // 
            // TB_UOCOutput
            // 
            this.TB_UOCOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.TB_UOCOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_UOCOutput.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.TB_UOCOutput.ForeColor = System.Drawing.Color.Black;
            this.TB_UOCOutput.Location = new System.Drawing.Point(7, 6);
            this.TB_UOCOutput.Multiline = true;
            this.TB_UOCOutput.Name = "TB_UOCOutput";
            this.TB_UOCOutput.ReadOnly = true;
            this.TB_UOCOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_UOCOutput.Size = new System.Drawing.Size(661, 213);
            this.TB_UOCOutput.TabIndex = 2;
            this.TB_UOCOutput.TextChanged += new System.EventHandler(this.TB_UOCOutput_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.tabPage4.Controls.Add(this.BTN_ECompile);
            this.tabPage4.Controls.Add(this.TB_ECompile);
            this.tabPage4.Controls.Add(this.GB_PackageRootEditor);
            this.tabPage4.Controls.Add(this.GB_ECompile);
            this.tabPage4.Controls.Add(this.GB_ECompilePathsEdit);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(676, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ECompile";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // BTN_ECompile
            // 
            this.BTN_ECompile.Location = new System.Drawing.Point(301, 360);
            this.BTN_ECompile.Name = "BTN_ECompile";
            this.BTN_ECompile.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompile.TabIndex = 5;
            this.BTN_ECompile.Text = "Compile";
            this.BTN_ECompile.UseVisualStyleBackColor = true;
            this.BTN_ECompile.Click += new System.EventHandler(this.BTN_ECompile_Click);
            // 
            // TB_ECompile
            // 
            this.TB_ECompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.TB_ECompile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ECompile.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.TB_ECompile.ForeColor = System.Drawing.Color.Black;
            this.TB_ECompile.Location = new System.Drawing.Point(7, 3);
            this.TB_ECompile.Multiline = true;
            this.TB_ECompile.Name = "TB_ECompile";
            this.TB_ECompile.ReadOnly = true;
            this.TB_ECompile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_ECompile.Size = new System.Drawing.Size(661, 169);
            this.TB_ECompile.TabIndex = 3;
            // 
            // GB_PackageRootEditor
            // 
            this.GB_PackageRootEditor.Controls.Add(this.BTN_ECompilePackageRootEditorCancel);
            this.GB_PackageRootEditor.Controls.Add(this.DGV_PackageRoot);
            this.GB_PackageRootEditor.Controls.Add(this.BTN_ECompilePackageRootEditorFinished);
            this.GB_PackageRootEditor.Location = new System.Drawing.Point(7, 178);
            this.GB_PackageRootEditor.Name = "GB_PackageRootEditor";
            this.GB_PackageRootEditor.Size = new System.Drawing.Size(661, 176);
            this.GB_PackageRootEditor.TabIndex = 7;
            this.GB_PackageRootEditor.TabStop = false;
            this.GB_PackageRootEditor.Text = "Package Root Editor";
            this.GB_PackageRootEditor.Visible = false;
            // 
            // DGV_PackageRoot
            // 
            this.DGV_PackageRoot.AllowUserToAddRows = false;
            this.DGV_PackageRoot.AllowUserToDeleteRows = false;
            this.DGV_PackageRoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PackageRoot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageRootPath,
            this.PackageRootBrowseButton,
            this.PackageRootDeleteButton,
            this.PackageRootAddButton});
            this.DGV_PackageRoot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_PackageRoot.Location = new System.Drawing.Point(9, 17);
            this.DGV_PackageRoot.MultiSelect = false;
            this.DGV_PackageRoot.Name = "DGV_PackageRoot";
            this.DGV_PackageRoot.ReadOnly = true;
            this.DGV_PackageRoot.Size = new System.Drawing.Size(643, 121);
            this.DGV_PackageRoot.TabIndex = 1;
            this.DGV_PackageRoot.TabStop = false;
            this.DGV_PackageRoot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PackageRoot_CellClick);
            // 
            // BTN_ECompilePackageRootEditorFinished
            // 
            this.BTN_ECompilePackageRootEditorFinished.Location = new System.Drawing.Point(577, 144);
            this.BTN_ECompilePackageRootEditorFinished.Name = "BTN_ECompilePackageRootEditorFinished";
            this.BTN_ECompilePackageRootEditorFinished.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompilePackageRootEditorFinished.TabIndex = 0;
            this.BTN_ECompilePackageRootEditorFinished.Text = "Finished";
            this.BTN_ECompilePackageRootEditorFinished.UseVisualStyleBackColor = true;
            this.BTN_ECompilePackageRootEditorFinished.Click += new System.EventHandler(this.BTN_ECompilePackageRootEditorFinished_Click);
            // 
            // GB_ECompile
            // 
            this.GB_ECompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.GB_ECompile.Controls.Add(this.PNL_ECompilePaths);
            this.GB_ECompile.Controls.Add(this.LBL_ECompileFlags);
            this.GB_ECompile.Controls.Add(this.PNL_ECompileLoadSave);
            this.GB_ECompile.Controls.Add(this.PNL_ECompileSave);
            this.GB_ECompile.Controls.Add(this.PNL_ECompileFlags);
            this.GB_ECompile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_ECompile.Location = new System.Drawing.Point(7, 178);
            this.GB_ECompile.Name = "GB_ECompile";
            this.GB_ECompile.Size = new System.Drawing.Size(661, 176);
            this.GB_ECompile.TabIndex = 4;
            this.GB_ECompile.TabStop = false;
            this.GB_ECompile.Text = "ECompile Controls";
            // 
            // PNL_ECompilePaths
            // 
            this.PNL_ECompilePaths.Controls.Add(this.TB_ECompilePolScriptRoot);
            this.PNL_ECompilePaths.Controls.Add(this.TB_ECompileIncludeDirectory);
            this.PNL_ECompilePaths.Controls.Add(this.TB_ECompileModuleDirectory);
            this.PNL_ECompilePaths.Location = new System.Drawing.Point(6, 133);
            this.PNL_ECompilePaths.Name = "PNL_ECompilePaths";
            this.PNL_ECompilePaths.Size = new System.Drawing.Size(649, 37);
            this.PNL_ECompilePaths.TabIndex = 10;
            // 
            // TB_ECompilePolScriptRoot
            // 
            this.TB_ECompilePolScriptRoot.BackColor = System.Drawing.SystemColors.Window;
            this.TB_ECompilePolScriptRoot.Location = new System.Drawing.Point(471, 11);
            this.TB_ECompilePolScriptRoot.Name = "TB_ECompilePolScriptRoot";
            this.TB_ECompilePolScriptRoot.ReadOnly = true;
            this.TB_ECompilePolScriptRoot.Size = new System.Drawing.Size(175, 20);
            this.TB_ECompilePolScriptRoot.TabIndex = 5;
            // 
            // TB_ECompileIncludeDirectory
            // 
            this.TB_ECompileIncludeDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.TB_ECompileIncludeDirectory.Location = new System.Drawing.Point(239, 11);
            this.TB_ECompileIncludeDirectory.Name = "TB_ECompileIncludeDirectory";
            this.TB_ECompileIncludeDirectory.ReadOnly = true;
            this.TB_ECompileIncludeDirectory.Size = new System.Drawing.Size(175, 20);
            this.TB_ECompileIncludeDirectory.TabIndex = 2;
            // 
            // TB_ECompileModuleDirectory
            // 
            this.TB_ECompileModuleDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.TB_ECompileModuleDirectory.Location = new System.Drawing.Point(3, 11);
            this.TB_ECompileModuleDirectory.Name = "TB_ECompileModuleDirectory";
            this.TB_ECompileModuleDirectory.ReadOnly = true;
            this.TB_ECompileModuleDirectory.Size = new System.Drawing.Size(175, 20);
            this.TB_ECompileModuleDirectory.TabIndex = 0;
            // 
            // LBL_ECompileFlags
            // 
            this.LBL_ECompileFlags.AutoSize = true;
            this.LBL_ECompileFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ECompileFlags.Location = new System.Drawing.Point(157, 7);
            this.LBL_ECompileFlags.Name = "LBL_ECompileFlags";
            this.LBL_ECompileFlags.Size = new System.Drawing.Size(89, 13);
            this.LBL_ECompileFlags.TabIndex = 6;
            this.LBL_ECompileFlags.Text = "Compiler Flags";
            // 
            // PNL_ECompileLoadSave
            // 
            this.PNL_ECompileLoadSave.Controls.Add(this.BTN_ECompileSave);
            this.PNL_ECompileLoadSave.Controls.Add(this.BTN_EcompileLoad);
            this.PNL_ECompileLoadSave.Controls.Add(this.LBL_ECompileLoadSave);
            this.PNL_ECompileLoadSave.Location = new System.Drawing.Point(414, 19);
            this.PNL_ECompileLoadSave.Name = "PNL_ECompileLoadSave";
            this.PNL_ECompileLoadSave.Size = new System.Drawing.Size(239, 54);
            this.PNL_ECompileLoadSave.TabIndex = 9;
            // 
            // BTN_ECompileSave
            // 
            this.BTN_ECompileSave.Location = new System.Drawing.Point(139, 21);
            this.BTN_ECompileSave.Name = "BTN_ECompileSave";
            this.BTN_ECompileSave.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompileSave.TabIndex = 3;
            this.BTN_ECompileSave.Text = "Save";
            this.BTN_ECompileSave.UseVisualStyleBackColor = true;
            this.BTN_ECompileSave.Click += new System.EventHandler(this.BTN_ECompileSave_Click);
            // 
            // BTN_EcompileLoad
            // 
            this.BTN_EcompileLoad.Location = new System.Drawing.Point(28, 21);
            this.BTN_EcompileLoad.Name = "BTN_EcompileLoad";
            this.BTN_EcompileLoad.Size = new System.Drawing.Size(75, 23);
            this.BTN_EcompileLoad.TabIndex = 3;
            this.BTN_EcompileLoad.Text = "Load";
            this.BTN_EcompileLoad.UseVisualStyleBackColor = true;
            this.BTN_EcompileLoad.Click += new System.EventHandler(this.BTN_EcompileLoad_Click);
            // 
            // LBL_ECompileLoadSave
            // 
            this.LBL_ECompileLoadSave.AutoSize = true;
            this.LBL_ECompileLoadSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ECompileLoadSave.Location = new System.Drawing.Point(7, 5);
            this.LBL_ECompileLoadSave.Name = "LBL_ECompileLoadSave";
            this.LBL_ECompileLoadSave.Size = new System.Drawing.Size(224, 13);
            this.LBL_ECompileLoadSave.TabIndex = 0;
            this.LBL_ECompileLoadSave.Text = "Load/Save settings from ECompile.cfg";
            // 
            // PNL_ECompileSave
            // 
            this.PNL_ECompileSave.Controls.Add(this.BTN_ECompilePathsEdit);
            this.PNL_ECompileSave.Controls.Add(this.LBL_ECompilePackageRoots);
            this.PNL_ECompileSave.Controls.Add(this.BTN_ECompilePackageRoots);
            this.PNL_ECompileSave.Location = new System.Drawing.Point(414, 73);
            this.PNL_ECompileSave.Name = "PNL_ECompileSave";
            this.PNL_ECompileSave.Size = new System.Drawing.Size(239, 54);
            this.PNL_ECompileSave.TabIndex = 8;
            // 
            // BTN_ECompilePathsEdit
            // 
            this.BTN_ECompilePathsEdit.Location = new System.Drawing.Point(139, 21);
            this.BTN_ECompilePathsEdit.Name = "BTN_ECompilePathsEdit";
            this.BTN_ECompilePathsEdit.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompilePathsEdit.TabIndex = 4;
            this.BTN_ECompilePathsEdit.Text = "Paths";
            this.BTN_ECompilePathsEdit.UseVisualStyleBackColor = true;
            this.BTN_ECompilePathsEdit.Click += new System.EventHandler(this.BTN_ECompilePathsEdit_Click);
            // 
            // LBL_ECompilePackageRoots
            // 
            this.LBL_ECompilePackageRoots.AutoSize = true;
            this.LBL_ECompilePackageRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ECompilePackageRoots.Location = new System.Drawing.Point(26, 5);
            this.LBL_ECompilePackageRoots.Name = "LBL_ECompilePackageRoots";
            this.LBL_ECompilePackageRoots.Size = new System.Drawing.Size(187, 13);
            this.LBL_ECompilePackageRoots.TabIndex = 0;
            this.LBL_ECompilePackageRoots.Text = "Edit Ecompile.Cfg Path Settings";
            // 
            // BTN_ECompilePackageRoots
            // 
            this.BTN_ECompilePackageRoots.Location = new System.Drawing.Point(28, 21);
            this.BTN_ECompilePackageRoots.Name = "BTN_ECompilePackageRoots";
            this.BTN_ECompilePackageRoots.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompilePackageRoots.TabIndex = 3;
            this.BTN_ECompilePackageRoots.Text = "PKG Roots";
            this.BTN_ECompilePackageRoots.UseVisualStyleBackColor = true;
            this.BTN_ECompilePackageRoots.Click += new System.EventHandler(this.BTN_ECompilePackageRoots_Click);
            // 
            // PNL_ECompileFlags
            // 
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagDisplayUpToDateScripts);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagGenerateDependencyInfo);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagDisplaySummary);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagOnlyCompileUpdatedScripts);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagUpdateOnlyOnAutoCompile);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagAutoCompileByDefault);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagCompileAspPages);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagDisplayWarnings);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagGenerateDebugTextInfo);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagGenerateListing);
            this.PNL_ECompileFlags.Controls.Add(this.CB_ECompileFlagGenerateDebugInfo);
            this.PNL_ECompileFlags.Location = new System.Drawing.Point(6, 19);
            this.PNL_ECompileFlags.Name = "PNL_ECompileFlags";
            this.PNL_ECompileFlags.Size = new System.Drawing.Size(402, 107);
            this.PNL_ECompileFlags.TabIndex = 6;
            // 
            // CB_ECompileFlagDisplayUpToDateScripts
            // 
            this.CB_ECompileFlagDisplayUpToDateScripts.AutoSize = true;
            this.CB_ECompileFlagDisplayUpToDateScripts.Location = new System.Drawing.Point(194, 54);
            this.CB_ECompileFlagDisplayUpToDateScripts.Name = "CB_ECompileFlagDisplayUpToDateScripts";
            this.CB_ECompileFlagDisplayUpToDateScripts.Size = new System.Drawing.Size(154, 17);
            this.CB_ECompileFlagDisplayUpToDateScripts.TabIndex = 14;
            this.CB_ECompileFlagDisplayUpToDateScripts.Text = "Display Up To Date Scripts";
            this.CB_ECompileFlagDisplayUpToDateScripts.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagGenerateDependencyInfo
            // 
            this.CB_ECompileFlagGenerateDependencyInfo.AutoSize = true;
            this.CB_ECompileFlagGenerateDependencyInfo.Location = new System.Drawing.Point(7, 54);
            this.CB_ECompileFlagGenerateDependencyInfo.Name = "CB_ECompileFlagGenerateDependencyInfo";
            this.CB_ECompileFlagGenerateDependencyInfo.Size = new System.Drawing.Size(183, 17);
            this.CB_ECompileFlagGenerateDependencyInfo.TabIndex = 13;
            this.CB_ECompileFlagGenerateDependencyInfo.Text = "Generate Dependency File (.dep)";
            this.CB_ECompileFlagGenerateDependencyInfo.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagDisplaySummary
            // 
            this.CB_ECompileFlagDisplaySummary.AutoSize = true;
            this.CB_ECompileFlagDisplaySummary.Location = new System.Drawing.Point(194, 86);
            this.CB_ECompileFlagDisplaySummary.Name = "CB_ECompileFlagDisplaySummary";
            this.CB_ECompileFlagDisplaySummary.Size = new System.Drawing.Size(106, 17);
            this.CB_ECompileFlagDisplaySummary.TabIndex = 12;
            this.CB_ECompileFlagDisplaySummary.Text = "Display Summary";
            this.CB_ECompileFlagDisplaySummary.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagOnlyCompileUpdatedScripts
            // 
            this.CB_ECompileFlagOnlyCompileUpdatedScripts.AutoSize = true;
            this.CB_ECompileFlagOnlyCompileUpdatedScripts.Location = new System.Drawing.Point(194, 38);
            this.CB_ECompileFlagOnlyCompileUpdatedScripts.Name = "CB_ECompileFlagOnlyCompileUpdatedScripts";
            this.CB_ECompileFlagOnlyCompileUpdatedScripts.Size = new System.Drawing.Size(166, 17);
            this.CB_ECompileFlagOnlyCompileUpdatedScripts.TabIndex = 11;
            this.CB_ECompileFlagOnlyCompileUpdatedScripts.Text = "Only Compile Updated Scripts";
            this.CB_ECompileFlagOnlyCompileUpdatedScripts.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagUpdateOnlyOnAutoCompile
            // 
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile.AutoSize = true;
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile.Location = new System.Drawing.Point(194, 22);
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile.Name = "CB_ECompileFlagUpdateOnlyOnAutoCompile";
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile.Size = new System.Drawing.Size(167, 17);
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile.TabIndex = 10;
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile.Text = "Update Only On Auto Compile";
            this.CB_ECompileFlagUpdateOnlyOnAutoCompile.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagAutoCompileByDefault
            // 
            this.CB_ECompileFlagAutoCompileByDefault.AutoSize = true;
            this.CB_ECompileFlagAutoCompileByDefault.Location = new System.Drawing.Point(194, 6);
            this.CB_ECompileFlagAutoCompileByDefault.Name = "CB_ECompileFlagAutoCompileByDefault";
            this.CB_ECompileFlagAutoCompileByDefault.Size = new System.Drawing.Size(140, 17);
            this.CB_ECompileFlagAutoCompileByDefault.TabIndex = 9;
            this.CB_ECompileFlagAutoCompileByDefault.Text = "Auto Compile By Default";
            this.CB_ECompileFlagAutoCompileByDefault.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagCompileAspPages
            // 
            this.CB_ECompileFlagCompileAspPages.AutoSize = true;
            this.CB_ECompileFlagCompileAspPages.Location = new System.Drawing.Point(7, 70);
            this.CB_ECompileFlagCompileAspPages.Name = "CB_ECompileFlagCompileAspPages";
            this.CB_ECompileFlagCompileAspPages.Size = new System.Drawing.Size(123, 17);
            this.CB_ECompileFlagCompileAspPages.TabIndex = 8;
            this.CB_ECompileFlagCompileAspPages.Text = "Compile .ASP Pages";
            this.CB_ECompileFlagCompileAspPages.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagDisplayWarnings
            // 
            this.CB_ECompileFlagDisplayWarnings.AutoSize = true;
            this.CB_ECompileFlagDisplayWarnings.Location = new System.Drawing.Point(194, 70);
            this.CB_ECompileFlagDisplayWarnings.Name = "CB_ECompileFlagDisplayWarnings";
            this.CB_ECompileFlagDisplayWarnings.Size = new System.Drawing.Size(108, 17);
            this.CB_ECompileFlagDisplayWarnings.TabIndex = 7;
            this.CB_ECompileFlagDisplayWarnings.Text = "Display Warnings";
            this.CB_ECompileFlagDisplayWarnings.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagGenerateDebugTextInfo
            // 
            this.CB_ECompileFlagGenerateDebugTextInfo.AutoSize = true;
            this.CB_ECompileFlagGenerateDebugTextInfo.Location = new System.Drawing.Point(7, 38);
            this.CB_ECompileFlagGenerateDebugTextInfo.Name = "CB_ECompileFlagGenerateDebugTextInfo";
            this.CB_ECompileFlagGenerateDebugTextInfo.Size = new System.Drawing.Size(171, 17);
            this.CB_ECompileFlagGenerateDebugTextInfo.TabIndex = 2;
            this.CB_ECompileFlagGenerateDebugTextInfo.Text = "Generate Debug Text File (.txt)";
            this.CB_ECompileFlagGenerateDebugTextInfo.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagGenerateListing
            // 
            this.CB_ECompileFlagGenerateListing.AutoSize = true;
            this.CB_ECompileFlagGenerateListing.Location = new System.Drawing.Point(7, 6);
            this.CB_ECompileFlagGenerateListing.Name = "CB_ECompileFlagGenerateListing";
            this.CB_ECompileFlagGenerateListing.Size = new System.Drawing.Size(130, 17);
            this.CB_ECompileFlagGenerateListing.TabIndex = 0;
            this.CB_ECompileFlagGenerateListing.Text = "Generate List File (.lst)";
            this.CB_ECompileFlagGenerateListing.UseVisualStyleBackColor = true;
            // 
            // CB_ECompileFlagGenerateDebugInfo
            // 
            this.CB_ECompileFlagGenerateDebugInfo.AutoSize = true;
            this.CB_ECompileFlagGenerateDebugInfo.Location = new System.Drawing.Point(7, 22);
            this.CB_ECompileFlagGenerateDebugInfo.Name = "CB_ECompileFlagGenerateDebugInfo";
            this.CB_ECompileFlagGenerateDebugInfo.Size = new System.Drawing.Size(154, 17);
            this.CB_ECompileFlagGenerateDebugInfo.TabIndex = 1;
            this.CB_ECompileFlagGenerateDebugInfo.Text = "Generate Debug File (.dbg)";
            this.CB_ECompileFlagGenerateDebugInfo.UseVisualStyleBackColor = true;
            // 
            // GB_ECompilePathsEdit
            // 
            this.GB_ECompilePathsEdit.Controls.Add(this.BTN_ECompileEditPathsScripts);
            this.GB_ECompilePathsEdit.Controls.Add(this.BTN_ECompileEditPathsIncludes);
            this.GB_ECompilePathsEdit.Controls.Add(this.BTN_ECompileEditPathsModules);
            this.GB_ECompilePathsEdit.Controls.Add(this.PNL_ECompilePathsEditTBS);
            this.GB_ECompilePathsEdit.Controls.Add(this.LBL_ECompilePathsEditScriptRoot);
            this.GB_ECompilePathsEdit.Controls.Add(this.LBL_ECompilePathsEditIncludes);
            this.GB_ECompilePathsEdit.Controls.Add(this.LBL_ECompilePathsEditModules);
            this.GB_ECompilePathsEdit.Controls.Add(this.BTN_ECompilePathsEditDone);
            this.GB_ECompilePathsEdit.Location = new System.Drawing.Point(7, 178);
            this.GB_ECompilePathsEdit.Name = "GB_ECompilePathsEdit";
            this.GB_ECompilePathsEdit.Size = new System.Drawing.Size(661, 176);
            this.GB_ECompilePathsEdit.TabIndex = 6;
            this.GB_ECompilePathsEdit.TabStop = false;
            this.GB_ECompilePathsEdit.Text = "Edit ECompile Path Settings";
            this.GB_ECompilePathsEdit.Visible = false;
            // 
            // BTN_ECompileEditPathsScripts
            // 
            this.BTN_ECompileEditPathsScripts.Location = new System.Drawing.Point(324, 78);
            this.BTN_ECompileEditPathsScripts.Name = "BTN_ECompileEditPathsScripts";
            this.BTN_ECompileEditPathsScripts.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompileEditPathsScripts.TabIndex = 7;
            this.BTN_ECompileEditPathsScripts.Text = "Browse";
            this.BTN_ECompileEditPathsScripts.UseVisualStyleBackColor = true;
            this.BTN_ECompileEditPathsScripts.Click += new System.EventHandler(this.BTN_ECompileEditPathsScripts_Click);
            // 
            // BTN_ECompileEditPathsIncludes
            // 
            this.BTN_ECompileEditPathsIncludes.Location = new System.Drawing.Point(324, 52);
            this.BTN_ECompileEditPathsIncludes.Name = "BTN_ECompileEditPathsIncludes";
            this.BTN_ECompileEditPathsIncludes.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompileEditPathsIncludes.TabIndex = 6;
            this.BTN_ECompileEditPathsIncludes.Text = "Browse";
            this.BTN_ECompileEditPathsIncludes.UseVisualStyleBackColor = true;
            this.BTN_ECompileEditPathsIncludes.Click += new System.EventHandler(this.BTN_ECompileEditPathsIncludes_Click);
            // 
            // BTN_ECompileEditPathsModules
            // 
            this.BTN_ECompileEditPathsModules.Location = new System.Drawing.Point(324, 26);
            this.BTN_ECompileEditPathsModules.Name = "BTN_ECompileEditPathsModules";
            this.BTN_ECompileEditPathsModules.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompileEditPathsModules.TabIndex = 5;
            this.BTN_ECompileEditPathsModules.Text = "Browse";
            this.BTN_ECompileEditPathsModules.UseVisualStyleBackColor = true;
            this.BTN_ECompileEditPathsModules.Click += new System.EventHandler(this.BTN_ECompileEditPathsModules_Click);
            // 
            // PNL_ECompilePathsEditTBS
            // 
            this.PNL_ECompilePathsEditTBS.Controls.Add(this.TB_ECompilePathsEditPolScriptRoot);
            this.PNL_ECompilePathsEditTBS.Controls.Add(this.TB_ECompilePathsEditIncludeDirectory);
            this.PNL_ECompilePathsEditTBS.Controls.Add(this.TB_ECompilePathsEditModuleDirectory);
            this.PNL_ECompilePathsEditTBS.Location = new System.Drawing.Point(109, 19);
            this.PNL_ECompilePathsEditTBS.Name = "PNL_ECompilePathsEditTBS";
            this.PNL_ECompilePathsEditTBS.Size = new System.Drawing.Size(209, 87);
            this.PNL_ECompilePathsEditTBS.TabIndex = 4;
            // 
            // TB_ECompilePathsEditPolScriptRoot
            // 
            this.TB_ECompilePathsEditPolScriptRoot.BackColor = System.Drawing.SystemColors.Window;
            this.TB_ECompilePathsEditPolScriptRoot.Location = new System.Drawing.Point(3, 59);
            this.TB_ECompilePathsEditPolScriptRoot.Name = "TB_ECompilePathsEditPolScriptRoot";
            this.TB_ECompilePathsEditPolScriptRoot.ReadOnly = true;
            this.TB_ECompilePathsEditPolScriptRoot.Size = new System.Drawing.Size(200, 20);
            this.TB_ECompilePathsEditPolScriptRoot.TabIndex = 5;
            // 
            // TB_ECompilePathsEditIncludeDirectory
            // 
            this.TB_ECompilePathsEditIncludeDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.TB_ECompilePathsEditIncludeDirectory.Location = new System.Drawing.Point(3, 33);
            this.TB_ECompilePathsEditIncludeDirectory.Name = "TB_ECompilePathsEditIncludeDirectory";
            this.TB_ECompilePathsEditIncludeDirectory.ReadOnly = true;
            this.TB_ECompilePathsEditIncludeDirectory.Size = new System.Drawing.Size(200, 20);
            this.TB_ECompilePathsEditIncludeDirectory.TabIndex = 4;
            // 
            // TB_ECompilePathsEditModuleDirectory
            // 
            this.TB_ECompilePathsEditModuleDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.TB_ECompilePathsEditModuleDirectory.Location = new System.Drawing.Point(3, 7);
            this.TB_ECompilePathsEditModuleDirectory.Name = "TB_ECompilePathsEditModuleDirectory";
            this.TB_ECompilePathsEditModuleDirectory.ReadOnly = true;
            this.TB_ECompilePathsEditModuleDirectory.Size = new System.Drawing.Size(200, 20);
            this.TB_ECompilePathsEditModuleDirectory.TabIndex = 3;
            // 
            // LBL_ECompilePathsEditScriptRoot
            // 
            this.LBL_ECompilePathsEditScriptRoot.AutoSize = true;
            this.LBL_ECompilePathsEditScriptRoot.Location = new System.Drawing.Point(10, 81);
            this.LBL_ECompilePathsEditScriptRoot.Name = "LBL_ECompilePathsEditScriptRoot";
            this.LBL_ECompilePathsEditScriptRoot.Size = new System.Drawing.Size(84, 13);
            this.LBL_ECompilePathsEditScriptRoot.TabIndex = 2;
            this.LBL_ECompilePathsEditScriptRoot.Text = "POL Script Root";
            // 
            // LBL_ECompilePathsEditIncludes
            // 
            this.LBL_ECompilePathsEditIncludes.AutoSize = true;
            this.LBL_ECompilePathsEditIncludes.Location = new System.Drawing.Point(10, 55);
            this.LBL_ECompilePathsEditIncludes.Name = "LBL_ECompilePathsEditIncludes";
            this.LBL_ECompilePathsEditIncludes.Size = new System.Drawing.Size(92, 13);
            this.LBL_ECompilePathsEditIncludes.TabIndex = 1;
            this.LBL_ECompilePathsEditIncludes.Text = "Includes Directory";
            // 
            // LBL_ECompilePathsEditModules
            // 
            this.LBL_ECompilePathsEditModules.AutoSize = true;
            this.LBL_ECompilePathsEditModules.Location = new System.Drawing.Point(10, 29);
            this.LBL_ECompilePathsEditModules.Name = "LBL_ECompilePathsEditModules";
            this.LBL_ECompilePathsEditModules.Size = new System.Drawing.Size(92, 13);
            this.LBL_ECompilePathsEditModules.TabIndex = 0;
            this.LBL_ECompilePathsEditModules.Text = "Modules Directory";
            // 
            // BTN_ECompilePathsEditDone
            // 
            this.BTN_ECompilePathsEditDone.Location = new System.Drawing.Point(580, 147);
            this.BTN_ECompilePathsEditDone.Name = "BTN_ECompilePathsEditDone";
            this.BTN_ECompilePathsEditDone.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompilePathsEditDone.TabIndex = 0;
            this.BTN_ECompilePathsEditDone.TabStop = false;
            this.BTN_ECompilePathsEditDone.Text = "Finished";
            this.BTN_ECompilePathsEditDone.UseVisualStyleBackColor = true;
            this.BTN_ECompilePathsEditDone.Click += new System.EventHandler(this.BTN_ECompilePathsEditDone_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(676, 392);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "POL Setup";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.tabPage6.Controls.Add(this.BTN_StopPOL);
            this.tabPage6.Controls.Add(this.CB_POLScrollBar);
            this.tabPage6.Controls.Add(this.BTN_StartPOL);
            this.tabPage6.Controls.Add(this.txtPOLConsole);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(676, 392);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "POL";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // BTN_StopPOL
            // 
            this.BTN_StopPOL.Location = new System.Drawing.Point(338, 351);
            this.BTN_StopPOL.Name = "BTN_StopPOL";
            this.BTN_StopPOL.Size = new System.Drawing.Size(75, 23);
            this.BTN_StopPOL.TabIndex = 4;
            this.BTN_StopPOL.Text = "Stop POL";
            this.BTN_StopPOL.UseVisualStyleBackColor = true;
            this.BTN_StopPOL.Click += new System.EventHandler(this.BTN_StopPOL_Click);
            // 
            // CB_POLScrollBar
            // 
            this.CB_POLScrollBar.AutoSize = true;
            this.CB_POLScrollBar.Location = new System.Drawing.Point(601, 351);
            this.CB_POLScrollBar.Name = "CB_POLScrollBar";
            this.CB_POLScrollBar.Size = new System.Drawing.Size(67, 17);
            this.CB_POLScrollBar.TabIndex = 3;
            this.CB_POLScrollBar.Text = "Scrollbar";
            this.CB_POLScrollBar.UseVisualStyleBackColor = true;
            this.CB_POLScrollBar.CheckedChanged += new System.EventHandler(this.CB_POLScrollBar_CheckedChanged);
            // 
            // BTN_StartPOL
            // 
            this.BTN_StartPOL.Location = new System.Drawing.Point(258, 351);
            this.BTN_StartPOL.Name = "BTN_StartPOL";
            this.BTN_StartPOL.Size = new System.Drawing.Size(75, 23);
            this.BTN_StartPOL.TabIndex = 2;
            this.BTN_StartPOL.Text = "Start POL";
            this.BTN_StartPOL.UseVisualStyleBackColor = true;
            this.BTN_StartPOL.Click += new System.EventHandler(this.BTN_StartPOL_Click);
            // 
            // txtPOLConsole
            // 
            this.txtPOLConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.txtPOLConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPOLConsole.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.txtPOLConsole.ForeColor = System.Drawing.Color.Black;
            this.txtPOLConsole.Location = new System.Drawing.Point(8, 3);
            this.txtPOLConsole.Multiline = true;
            this.txtPOLConsole.Name = "txtPOLConsole";
            this.txtPOLConsole.ReadOnly = true;
            this.txtPOLConsole.Size = new System.Drawing.Size(660, 342);
            this.txtPOLConsole.TabIndex = 1;
            this.txtPOLConsole.TextChanged += new System.EventHandler(this.txtPOLConsole_TextChanged);
            this.txtPOLConsole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPOLConsole_KeyUp);
            this.txtPOLConsole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPOLConsole_KeyPress);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.tabPage7.Controls.Add(this.GB_DataBackup);
            this.tabPage7.Controls.Add(this.GB_ModifyAccount);
            this.tabPage7.Controls.Add(this.GB_AuxSvcSettings);
            this.tabPage7.Controls.Add(this.panel3);
            this.tabPage7.Controls.Add(this.GB_CreateAccount);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(676, 392);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Accounts & Data";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // GB_DataBackup
            // 
            this.GB_DataBackup.Location = new System.Drawing.Point(8, 298);
            this.GB_DataBackup.Name = "GB_DataBackup";
            this.GB_DataBackup.Size = new System.Drawing.Size(660, 88);
            this.GB_DataBackup.TabIndex = 4;
            this.GB_DataBackup.TabStop = false;
            this.GB_DataBackup.Text = "POL Data Backup";
            // 
            // GB_ModifyAccount
            // 
            this.GB_ModifyAccount.Location = new System.Drawing.Point(282, 66);
            this.GB_ModifyAccount.Name = "GB_ModifyAccount";
            this.GB_ModifyAccount.Size = new System.Drawing.Size(386, 132);
            this.GB_ModifyAccount.TabIndex = 3;
            this.GB_ModifyAccount.TabStop = false;
            this.GB_ModifyAccount.Text = "Modify Account";
            // 
            // GB_AuxSvcSettings
            // 
            this.GB_AuxSvcSettings.Controls.Add(this.TB_ModifyAuxPassword);
            this.GB_AuxSvcSettings.Controls.Add(this.TB_ModifyPort);
            this.GB_AuxSvcSettings.Controls.Add(this.LBL_ModifyPassword);
            this.GB_AuxSvcSettings.Controls.Add(this.LBL_ModifyPort);
            this.GB_AuxSvcSettings.Controls.Add(this.TB_CreateAuxPassword);
            this.GB_AuxSvcSettings.Controls.Add(this.LBL_AuxSvcPassword);
            this.GB_AuxSvcSettings.Controls.Add(this.TB_CreateAccountPort);
            this.GB_AuxSvcSettings.Controls.Add(this.LBL_CreatePort);
            this.GB_AuxSvcSettings.Location = new System.Drawing.Point(282, 204);
            this.GB_AuxSvcSettings.Name = "GB_AuxSvcSettings";
            this.GB_AuxSvcSettings.Size = new System.Drawing.Size(386, 88);
            this.GB_AuxSvcSettings.TabIndex = 2;
            this.GB_AuxSvcSettings.TabStop = false;
            this.GB_AuxSvcSettings.Text = "AuxSvc Settings";
            // 
            // TB_ModifyAuxPassword
            // 
            this.TB_ModifyAuxPassword.Location = new System.Drawing.Point(264, 52);
            this.TB_ModifyAuxPassword.MaxLength = 30;
            this.TB_ModifyAuxPassword.Name = "TB_ModifyAuxPassword";
            this.TB_ModifyAuxPassword.PasswordChar = '*';
            this.TB_ModifyAuxPassword.Size = new System.Drawing.Size(100, 20);
            this.TB_ModifyAuxPassword.TabIndex = 7;
            // 
            // TB_ModifyPort
            // 
            this.TB_ModifyPort.Location = new System.Drawing.Point(264, 26);
            this.TB_ModifyPort.MaxLength = 10;
            this.TB_ModifyPort.Name = "TB_ModifyPort";
            this.TB_ModifyPort.Size = new System.Drawing.Size(100, 20);
            this.TB_ModifyPort.TabIndex = 6;
            this.TB_ModifyPort.Text = "5667";
            // 
            // LBL_ModifyPassword
            // 
            this.LBL_ModifyPassword.AutoSize = true;
            this.LBL_ModifyPassword.Location = new System.Drawing.Point(195, 54);
            this.LBL_ModifyPassword.Name = "LBL_ModifyPassword";
            this.LBL_ModifyPassword.Size = new System.Drawing.Size(56, 13);
            this.LBL_ModifyPassword.TabIndex = 5;
            this.LBL_ModifyPassword.Text = "Password:";
            // 
            // LBL_ModifyPort
            // 
            this.LBL_ModifyPort.AutoSize = true;
            this.LBL_ModifyPort.Location = new System.Drawing.Point(195, 29);
            this.LBL_ModifyPort.Name = "LBL_ModifyPort";
            this.LBL_ModifyPort.Size = new System.Drawing.Size(63, 13);
            this.LBL_ModifyPort.TabIndex = 4;
            this.LBL_ModifyPort.Text = "Modify Port:";
            // 
            // TB_CreateAuxPassword
            // 
            this.TB_CreateAuxPassword.Location = new System.Drawing.Point(78, 52);
            this.TB_CreateAuxPassword.MaxLength = 30;
            this.TB_CreateAuxPassword.Name = "TB_CreateAuxPassword";
            this.TB_CreateAuxPassword.PasswordChar = '*';
            this.TB_CreateAuxPassword.Size = new System.Drawing.Size(100, 20);
            this.TB_CreateAuxPassword.TabIndex = 3;
            // 
            // LBL_AuxSvcPassword
            // 
            this.LBL_AuxSvcPassword.AutoSize = true;
            this.LBL_AuxSvcPassword.Location = new System.Drawing.Point(9, 54);
            this.LBL_AuxSvcPassword.Name = "LBL_AuxSvcPassword";
            this.LBL_AuxSvcPassword.Size = new System.Drawing.Size(56, 13);
            this.LBL_AuxSvcPassword.TabIndex = 2;
            this.LBL_AuxSvcPassword.Text = "Password:";
            // 
            // TB_CreateAccountPort
            // 
            this.TB_CreateAccountPort.Location = new System.Drawing.Point(78, 26);
            this.TB_CreateAccountPort.MaxLength = 10;
            this.TB_CreateAccountPort.Name = "TB_CreateAccountPort";
            this.TB_CreateAccountPort.Size = new System.Drawing.Size(100, 20);
            this.TB_CreateAccountPort.TabIndex = 1;
            this.TB_CreateAccountPort.Text = "5666";
            // 
            // LBL_CreatePort
            // 
            this.LBL_CreatePort.AutoSize = true;
            this.LBL_CreatePort.Location = new System.Drawing.Point(9, 29);
            this.LBL_CreatePort.Name = "LBL_CreatePort";
            this.LBL_CreatePort.Size = new System.Drawing.Size(63, 13);
            this.LBL_CreatePort.TabIndex = 0;
            this.LBL_CreatePort.Text = "Create Port:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.LBL_AccountsHeader2);
            this.panel3.Controls.Add(this.LBL_AccountsHeader1);
            this.panel3.Location = new System.Drawing.Point(9, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 53);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "running when you try to use these controls.";
            // 
            // LBL_AccountsHeader2
            // 
            this.LBL_AccountsHeader2.AutoSize = true;
            this.LBL_AccountsHeader2.Location = new System.Drawing.Point(27, 13);
            this.LBL_AccountsHeader2.Name = "LBL_AccountsHeader2";
            this.LBL_AccountsHeader2.Size = new System.Drawing.Size(602, 13);
            this.LBL_AccountsHeader2.TabIndex = 1;
            this.LBL_AccountsHeader2.Text = "Create and make Minor Changes to existing Accounts. Because this uses the Aux Ser" +
                "vices with Distro, remember to have POL";
            // 
            // LBL_AccountsHeader1
            // 
            this.LBL_AccountsHeader1.AutoSize = true;
            this.LBL_AccountsHeader1.Location = new System.Drawing.Point(27, 0);
            this.LBL_AccountsHeader1.Name = "LBL_AccountsHeader1";
            this.LBL_AccountsHeader1.Size = new System.Drawing.Size(602, 13);
            this.LBL_AccountsHeader1.TabIndex = 0;
            this.LBL_AccountsHeader1.Text = "The Accounts Tab is usefull for basic account creation and manipulation. This use" +
                "s the AuxSvc Connection with POL Distro to";
            // 
            // GB_CreateAccount
            // 
            this.GB_CreateAccount.Controls.Add(this.BTN_CreateAccount);
            this.GB_CreateAccount.Controls.Add(this.TB_CreateEmail);
            this.GB_CreateAccount.Controls.Add(this.LBL_CreateEmail);
            this.GB_CreateAccount.Controls.Add(this.LBX_CreateExpansion);
            this.GB_CreateAccount.Controls.Add(this.LBL_CreateExpansion);
            this.GB_CreateAccount.Controls.Add(this.LBL_CreateCmdlevel);
            this.GB_CreateAccount.Controls.Add(this.LBX_CreateCmdlevel);
            this.GB_CreateAccount.Controls.Add(this.TB_CreatePassword);
            this.GB_CreateAccount.Controls.Add(this.LBL_CreatePassword);
            this.GB_CreateAccount.Controls.Add(this.TB_CreateUsername);
            this.GB_CreateAccount.Controls.Add(this.LBL_CreateUsername);
            this.GB_CreateAccount.Location = new System.Drawing.Point(8, 66);
            this.GB_CreateAccount.Name = "GB_CreateAccount";
            this.GB_CreateAccount.Size = new System.Drawing.Size(268, 226);
            this.GB_CreateAccount.TabIndex = 0;
            this.GB_CreateAccount.TabStop = false;
            this.GB_CreateAccount.Text = "Create Account";
            // 
            // BTN_CreateAccount
            // 
            this.BTN_CreateAccount.Location = new System.Drawing.Point(187, 197);
            this.BTN_CreateAccount.Name = "BTN_CreateAccount";
            this.BTN_CreateAccount.Size = new System.Drawing.Size(75, 23);
            this.BTN_CreateAccount.TabIndex = 10;
            this.BTN_CreateAccount.Text = "Create";
            this.BTN_CreateAccount.UseVisualStyleBackColor = true;
            this.BTN_CreateAccount.Click += new System.EventHandler(this.BTN_CreateAccount_Click);
            // 
            // TB_CreateEmail
            // 
            this.TB_CreateEmail.Location = new System.Drawing.Point(78, 83);
            this.TB_CreateEmail.MaxLength = 30;
            this.TB_CreateEmail.Name = "TB_CreateEmail";
            this.TB_CreateEmail.Size = new System.Drawing.Size(155, 20);
            this.TB_CreateEmail.TabIndex = 9;
            // 
            // LBL_CreateEmail
            // 
            this.LBL_CreateEmail.AutoSize = true;
            this.LBL_CreateEmail.Location = new System.Drawing.Point(9, 86);
            this.LBL_CreateEmail.Name = "LBL_CreateEmail";
            this.LBL_CreateEmail.Size = new System.Drawing.Size(35, 13);
            this.LBL_CreateEmail.TabIndex = 8;
            this.LBL_CreateEmail.Text = "Email:";
            // 
            // LBX_CreateExpansion
            // 
            this.LBX_CreateExpansion.FormattingEnabled = true;
            this.LBX_CreateExpansion.Items.AddRange(new object[] {
            "T2A",
            "LBR",
            "AOS",
            "SE",
            "ML"});
            this.LBX_CreateExpansion.Location = new System.Drawing.Point(78, 151);
            this.LBX_CreateExpansion.Name = "LBX_CreateExpansion";
            this.LBX_CreateExpansion.Size = new System.Drawing.Size(94, 30);
            this.LBX_CreateExpansion.TabIndex = 7;
            // 
            // LBL_CreateExpansion
            // 
            this.LBL_CreateExpansion.AutoSize = true;
            this.LBL_CreateExpansion.Location = new System.Drawing.Point(9, 151);
            this.LBL_CreateExpansion.Name = "LBL_CreateExpansion";
            this.LBL_CreateExpansion.Size = new System.Drawing.Size(59, 13);
            this.LBL_CreateExpansion.TabIndex = 6;
            this.LBL_CreateExpansion.Text = "Expansion:";
            // 
            // LBL_CreateCmdlevel
            // 
            this.LBL_CreateCmdlevel.AutoSize = true;
            this.LBL_CreateCmdlevel.Location = new System.Drawing.Point(9, 113);
            this.LBL_CreateCmdlevel.Name = "LBL_CreateCmdlevel";
            this.LBL_CreateCmdlevel.Size = new System.Drawing.Size(57, 13);
            this.LBL_CreateCmdlevel.TabIndex = 5;
            this.LBL_CreateCmdlevel.Text = "CmdLevel:";
            // 
            // LBX_CreateCmdlevel
            // 
            this.LBX_CreateCmdlevel.FormattingEnabled = true;
            this.LBX_CreateCmdlevel.Items.AddRange(new object[] {
            "0 - Player",
            "1 - Counselor",
            "2 - Seer",
            "3 - Game Master",
            "4 - Admin",
            "5 - Developer"});
            this.LBX_CreateCmdlevel.Location = new System.Drawing.Point(78, 113);
            this.LBX_CreateCmdlevel.Name = "LBX_CreateCmdlevel";
            this.LBX_CreateCmdlevel.Size = new System.Drawing.Size(94, 30);
            this.LBX_CreateCmdlevel.TabIndex = 4;
            // 
            // TB_CreatePassword
            // 
            this.TB_CreatePassword.Location = new System.Drawing.Point(78, 56);
            this.TB_CreatePassword.MaxLength = 30;
            this.TB_CreatePassword.Name = "TB_CreatePassword";
            this.TB_CreatePassword.PasswordChar = '*';
            this.TB_CreatePassword.Size = new System.Drawing.Size(155, 20);
            this.TB_CreatePassword.TabIndex = 3;
            // 
            // LBL_CreatePassword
            // 
            this.LBL_CreatePassword.AutoSize = true;
            this.LBL_CreatePassword.Location = new System.Drawing.Point(9, 59);
            this.LBL_CreatePassword.Name = "LBL_CreatePassword";
            this.LBL_CreatePassword.Size = new System.Drawing.Size(56, 13);
            this.LBL_CreatePassword.TabIndex = 2;
            this.LBL_CreatePassword.Text = "Password:";
            // 
            // TB_CreateUsername
            // 
            this.TB_CreateUsername.Location = new System.Drawing.Point(78, 29);
            this.TB_CreateUsername.MaxLength = 30;
            this.TB_CreateUsername.Name = "TB_CreateUsername";
            this.TB_CreateUsername.Size = new System.Drawing.Size(155, 20);
            this.TB_CreateUsername.TabIndex = 1;
            // 
            // LBL_CreateUsername
            // 
            this.LBL_CreateUsername.AutoSize = true;
            this.LBL_CreateUsername.Location = new System.Drawing.Point(9, 32);
            this.LBL_CreateUsername.Name = "LBL_CreateUsername";
            this.LBL_CreateUsername.Size = new System.Drawing.Size(58, 13);
            this.LBL_CreateUsername.TabIndex = 0;
            this.LBL_CreateUsername.Text = "Username:";
            // 
            // PackageRootPath
            // 
            this.PackageRootPath.HeaderText = "Path";
            this.PackageRootPath.Name = "PackageRootPath";
            this.PackageRootPath.ReadOnly = true;
            this.PackageRootPath.Width = 300;
            // 
            // PackageRootBrowseButton
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.NullValue = "Browse";
            this.PackageRootBrowseButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.PackageRootBrowseButton.HeaderText = "Select Folder";
            this.PackageRootBrowseButton.Name = "PackageRootBrowseButton";
            this.PackageRootBrowseButton.ReadOnly = true;
            this.PackageRootBrowseButton.Text = "Browse";
            // 
            // PackageRootDeleteButton
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = "Delete";
            this.PackageRootDeleteButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.PackageRootDeleteButton.HeaderText = "Delete Entry";
            this.PackageRootDeleteButton.Name = "PackageRootDeleteButton";
            this.PackageRootDeleteButton.ReadOnly = true;
            this.PackageRootDeleteButton.Text = "Delete";
            // 
            // PackageRootAddButton
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.NullValue = "Add New Path";
            this.PackageRootAddButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.PackageRootAddButton.HeaderText = "Add New Path";
            this.PackageRootAddButton.Name = "PackageRootAddButton";
            this.PackageRootAddButton.ReadOnly = true;
            this.PackageRootAddButton.Text = "Add New Path";
            // 
            // BTN_ECompilePackageRootEditorCancel
            // 
            this.BTN_ECompilePackageRootEditorCancel.Location = new System.Drawing.Point(9, 144);
            this.BTN_ECompilePackageRootEditorCancel.Name = "BTN_ECompilePackageRootEditorCancel";
            this.BTN_ECompilePackageRootEditorCancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_ECompilePackageRootEditorCancel.TabIndex = 2;
            this.BTN_ECompilePackageRootEditorCancel.Text = "Cancel";
            this.BTN_ECompilePackageRootEditorCancel.UseVisualStyleBackColor = true;
            this.BTN_ECompilePackageRootEditorCancel.Click += new System.EventHandler(this.BTN_ECompilePackageRootEditorCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "POL Launch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.UOConvertGroupBox.ResumeLayout(false);
            this.PNL_UOCSettings.ResumeLayout(false);
            this.PNL_UOCSettings.PerformLayout();
            this.PNL_UOCConfigFiles.ResumeLayout(false);
            this.PNL_UOCConfigFiles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.GB_PackageRootEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PackageRoot)).EndInit();
            this.GB_ECompile.ResumeLayout(false);
            this.GB_ECompile.PerformLayout();
            this.PNL_ECompilePaths.ResumeLayout(false);
            this.PNL_ECompilePaths.PerformLayout();
            this.PNL_ECompileLoadSave.ResumeLayout(false);
            this.PNL_ECompileLoadSave.PerformLayout();
            this.PNL_ECompileSave.ResumeLayout(false);
            this.PNL_ECompileSave.PerformLayout();
            this.PNL_ECompileFlags.ResumeLayout(false);
            this.PNL_ECompileFlags.PerformLayout();
            this.GB_ECompilePathsEdit.ResumeLayout(false);
            this.GB_ECompilePathsEdit.PerformLayout();
            this.PNL_ECompilePathsEditTBS.ResumeLayout(false);
            this.PNL_ECompilePathsEditTBS.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.GB_AuxSvcSettings.ResumeLayout(false);
            this.GB_AuxSvcSettings.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.GB_CreateAccount.ResumeLayout(false);
            this.GB_CreateAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.CheckBox CB_StraightToPOL;
        private System.Windows.Forms.Button BTN_RunTests;
        private System.Windows.Forms.TextBox txtPOLConsole;
        private System.Windows.Forms.Button BTN_StartPOL;
		private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox TB_RunTests;
        private System.Windows.Forms.GroupBox UOConvertGroupBox;
        private System.Windows.Forms.Panel PNL_UOCConfigFiles;
        private System.Windows.Forms.CheckBox CB_TileData;
        private System.Windows.Forms.CheckBox CB_LandTiles;
        private System.Windows.Forms.CheckBox CB_Multis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_MalMap;
        private System.Windows.Forms.CheckBox CB_TokMap;
        private System.Windows.Forms.CheckBox CB_IlshMap;
        private System.Windows.Forms.CheckBox CB_TramMap;
        private System.Windows.Forms.CheckBox CB_BritT2AMap;
        private System.Windows.Forms.CheckBox CB_BritMLMap;
        public System.Windows.Forms.TextBox TB_UOCOutput;
        private System.Windows.Forms.CheckBox CB_BritT2ADif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_BritMLDif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CB_TramDif;
        private System.Windows.Forms.CheckBox CB_IlshDif;
        private System.Windows.Forms.CheckBox CB_TokDif;
        private System.Windows.Forms.CheckBox CB_MalDif;
        private System.Windows.Forms.Button BTN_UOConvert;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox GB_CreateAccount;
        private System.Windows.Forms.TextBox TB_CreateUsername;
        private System.Windows.Forms.Label LBL_CreateUsername;
        private System.Windows.Forms.TextBox TB_CreatePassword;
        private System.Windows.Forms.Label LBL_CreatePassword;
        private System.Windows.Forms.Label LBL_CreateCmdlevel;
        private System.Windows.Forms.ListBox LBX_CreateCmdlevel;
        private System.Windows.Forms.ListBox LBX_CreateExpansion;
        private System.Windows.Forms.Label LBL_CreateExpansion;
        private System.Windows.Forms.Label LBL_CreateEmail;
        private System.Windows.Forms.TextBox TB_CreateEmail;
        private System.Windows.Forms.Button BTN_CreateAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LBL_AccountsHeader2;
        private System.Windows.Forms.Label LBL_AccountsHeader1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GB_AuxSvcSettings;
        private System.Windows.Forms.TextBox TB_CreateAccountPort;
        private System.Windows.Forms.Label LBL_CreatePort;
        private System.Windows.Forms.Panel PNL_UOCSettings;
        private System.Windows.Forms.Label LBL_UOCSettingsHeader;
        private System.Windows.Forms.Label LBL_UOCMulFilePath;
        private System.Windows.Forms.Button BTN_MULBrowse;
        private System.Windows.Forms.TextBox TB_MULFilePath;
        private System.Windows.Forms.TextBox TB_CreateAuxPassword;
        private System.Windows.Forms.Label LBL_AuxSvcPassword;
        private System.Windows.Forms.GroupBox GB_DataBackup;
        private System.Windows.Forms.GroupBox GB_ModifyAccount;
        private System.Windows.Forms.Label LBL_ModifyPort;
        private System.Windows.Forms.TextBox TB_ModifyAuxPassword;
        private System.Windows.Forms.TextBox TB_ModifyPort;
        private System.Windows.Forms.Label LBL_ModifyPassword;
        public System.Windows.Forms.TextBox TB_ECompile;
        private System.Windows.Forms.Button BTN_ECompile;
        private System.Windows.Forms.GroupBox GB_ECompile;
        private System.Windows.Forms.Panel PNL_ECompileSave;
        private System.Windows.Forms.Button BTN_ECompileSave;
        private System.Windows.Forms.Label LBL_ECompilePackageRoots;
        private System.Windows.Forms.Panel PNL_ECompileFlags;
        private System.Windows.Forms.Label LBL_ECompileFlags;
        private System.Windows.Forms.CheckBox CB_ECompileFlagGenerateDebugTextInfo;
        private System.Windows.Forms.CheckBox CB_ECompileFlagGenerateListing;
        private System.Windows.Forms.CheckBox CB_ECompileFlagGenerateDebugInfo;
        private System.Windows.Forms.Panel PNL_ECompileLoadSave;
        private System.Windows.Forms.Button BTN_EcompileLoad;
        private System.Windows.Forms.Label LBL_ECompileLoadSave;
        private System.Windows.Forms.CheckBox CB_ECompileFlagDisplayWarnings;
        private System.Windows.Forms.CheckBox CB_ECompileFlagCompileAspPages;
        private System.Windows.Forms.CheckBox CB_ECompileFlagUpdateOnlyOnAutoCompile;
        private System.Windows.Forms.CheckBox CB_ECompileFlagAutoCompileByDefault;
        private System.Windows.Forms.CheckBox CB_ECompileFlagGenerateDependencyInfo;
        private System.Windows.Forms.CheckBox CB_ECompileFlagDisplaySummary;
        private System.Windows.Forms.CheckBox CB_ECompileFlagOnlyCompileUpdatedScripts;
        private System.Windows.Forms.CheckBox CB_ECompileFlagDisplayUpToDateScripts;
        private System.Windows.Forms.CheckBox CB_POLScrollBar;
        private System.Windows.Forms.Button BTN_StopPOL;
        private System.Windows.Forms.TextBox TB_ECompileModuleDirectory;
        private System.Windows.Forms.Panel PNL_ECompilePaths;
        private System.Windows.Forms.Button BTN_ECompilePackageRoots;
        private System.Windows.Forms.TextBox TB_ECompileIncludeDirectory;
        private System.Windows.Forms.TextBox TB_ECompilePolScriptRoot;
        private System.Windows.Forms.Button BTN_ECompilePathsEdit;
        private System.Windows.Forms.GroupBox GB_ECompilePathsEdit;
        private System.Windows.Forms.Button BTN_ECompilePathsEditDone;
        private System.Windows.Forms.Label LBL_ECompilePathsEditModules;
        private System.Windows.Forms.Panel PNL_ECompilePathsEditTBS;
        private System.Windows.Forms.TextBox TB_ECompilePathsEditModuleDirectory;
        private System.Windows.Forms.Label LBL_ECompilePathsEditScriptRoot;
        private System.Windows.Forms.Label LBL_ECompilePathsEditIncludes;
        private System.Windows.Forms.TextBox TB_ECompilePathsEditPolScriptRoot;
        private System.Windows.Forms.TextBox TB_ECompilePathsEditIncludeDirectory;
        private System.Windows.Forms.Button BTN_ECompileEditPathsModules;
        private System.Windows.Forms.Button BTN_ECompileEditPathsScripts;
        private System.Windows.Forms.Button BTN_ECompileEditPathsIncludes;
        private System.Windows.Forms.GroupBox GB_PackageRootEditor;
        private System.Windows.Forms.Button BTN_ECompilePackageRootEditorFinished;
        private System.Windows.Forms.DataGridView DGV_PackageRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageRootPath;
        private System.Windows.Forms.DataGridViewButtonColumn PackageRootBrowseButton;
        private System.Windows.Forms.DataGridViewButtonColumn PackageRootDeleteButton;
        private System.Windows.Forms.DataGridViewButtonColumn PackageRootAddButton;
        private System.Windows.Forms.Button BTN_ECompilePackageRootEditorCancel;
	}
}

