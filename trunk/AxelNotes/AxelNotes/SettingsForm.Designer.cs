namespace AxelNotes
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnBrowseNotes = new System.Windows.Forms.Button();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.numVersions = new System.Windows.Forms.NumericUpDown();
            this.cbRecycle = new System.Windows.Forms.CheckBox();
            this.btnNotesListColor = new System.Windows.Forms.Button();
            this.lblNotesListColor = new System.Windows.Forms.Label();
            this.cbMultipleInstances = new System.Windows.Forms.CheckBox();
            this.cbCloseToTray = new System.Windows.Forms.CheckBox();
            this.cbMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.cbShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.numAutosave = new System.Windows.Forms.NumericUpDown();
            this.lblAutosaveTime = new System.Windows.Forms.Label();
            this.cbAutosaveTime = new System.Windows.Forms.CheckBox();
            this.cbVersions = new System.Windows.Forms.CheckBox();
            this.cbAutosaveFocus = new System.Windows.Forms.CheckBox();
            this.cbLoadStartup = new System.Windows.Forms.CheckBox();
            this.txtBackupFolder = new System.Windows.Forms.TextBox();
            this.txtNotesFolder = new System.Windows.Forms.TextBox();
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.lblNotesFolder = new System.Windows.Forms.Label();
            this.groupText = new System.Windows.Forms.GroupBox();
            this.btnFloater = new System.Windows.Forms.Button();
            this.lblFloaterColor = new System.Windows.Forms.Label();
            this.lblTabSize = new System.Windows.Forms.Label();
            this.numTabSize = new System.Windows.Forms.NumericUpDown();
            this.btnCurrentLineColor = new System.Windows.Forms.Button();
            this.lblCurrentLineColor = new System.Windows.Forms.Label();
            this.cbLineNumbers = new System.Windows.Forms.CheckBox();
            this.cbLineWrap = new System.Windows.Forms.CheckBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.btnHighlightColor = new System.Windows.Forms.Button();
            this.lblHighlightColor = new System.Windows.Forms.Label();
            this.btnHeadingColor = new System.Windows.Forms.Button();
            this.lblFontHeading = new System.Windows.Forms.Label();
            this.lblFontHHeadingSample = new System.Windows.Forms.Label();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.lblFontText = new System.Windows.Forms.Label();
            this.lblFontTextSample = new System.Windows.Forms.Label();
            this.groupHtml = new System.Windows.Forms.GroupBox();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabText = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabHtml = new System.Windows.Forms.TabPage();
            this.groupBehavior = new System.Windows.Forms.GroupBox();
            this.groupAppearance = new System.Windows.Forms.GroupBox();
            this.groupTextBeh = new System.Windows.Forms.GroupBox();
            this.lblColorHeading = new System.Windows.Forms.Label();
            this.lblColorText = new System.Windows.Forms.Label();
            this.groupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVersions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutosave)).BeginInit();
            this.groupText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTabSize)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabHtml.SuspendLayout();
            this.groupBehavior.SuspendLayout();
            this.groupAppearance.SuspendLayout();
            this.groupTextBeh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseNotes
            // 
            this.btnBrowseNotes.Location = new System.Drawing.Point(392, 15);
            this.btnBrowseNotes.Name = "btnBrowseNotes";
            this.btnBrowseNotes.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseNotes.TabIndex = 0;
            this.btnBrowseNotes.Text = "Browse...";
            this.btnBrowseNotes.UseVisualStyleBackColor = true;
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Location = new System.Drawing.Point(392, 41);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseBackup.TabIndex = 1;
            this.btnBrowseBackup.Text = "Browse...";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // fontDialog
            // 
            this.fontDialog.AllowVerticalFonts = false;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(351, 381);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(432, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(270, 381);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.numVersions);
            this.groupMain.Controls.Add(this.numAutosave);
            this.groupMain.Controls.Add(this.lblAutosaveTime);
            this.groupMain.Controls.Add(this.cbAutosaveTime);
            this.groupMain.Controls.Add(this.cbVersions);
            this.groupMain.Controls.Add(this.cbAutosaveFocus);
            this.groupMain.Controls.Add(this.txtBackupFolder);
            this.groupMain.Controls.Add(this.txtNotesFolder);
            this.groupMain.Controls.Add(this.lblBackupFolder);
            this.groupMain.Controls.Add(this.lblNotesFolder);
            this.groupMain.Controls.Add(this.btnBrowseBackup);
            this.groupMain.Controls.Add(this.btnBrowseNotes);
            this.groupMain.Location = new System.Drawing.Point(6, 6);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(485, 144);
            this.groupMain.TabIndex = 6;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "Paths and Recovery";
            // 
            // numVersions
            // 
            this.numVersions.Location = new System.Drawing.Point(275, 69);
            this.numVersions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVersions.Name = "numVersions";
            this.numVersions.Size = new System.Drawing.Size(42, 20);
            this.numVersions.TabIndex = 7;
            this.numVersions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cbRecycle
            // 
            this.cbRecycle.AutoSize = true;
            this.cbRecycle.Location = new System.Drawing.Point(260, 19);
            this.cbRecycle.Name = "cbRecycle";
            this.cbRecycle.Size = new System.Drawing.Size(158, 17);
            this.cbRecycle.TabIndex = 20;
            this.cbRecycle.Text = "Delete notes to Recycle Bin";
            this.cbRecycle.UseVisualStyleBackColor = true;
            // 
            // btnNotesListColor
            // 
            this.btnNotesListColor.Location = new System.Drawing.Point(106, 19);
            this.btnNotesListColor.Name = "btnNotesListColor";
            this.btnNotesListColor.Size = new System.Drawing.Size(38, 23);
            this.btnNotesListColor.TabIndex = 19;
            this.btnNotesListColor.UseVisualStyleBackColor = true;
            // 
            // lblNotesListColor
            // 
            this.lblNotesListColor.AutoSize = true;
            this.lblNotesListColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNotesListColor.Location = new System.Drawing.Point(21, 24);
            this.lblNotesListColor.Name = "lblNotesListColor";
            this.lblNotesListColor.Size = new System.Drawing.Size(79, 13);
            this.lblNotesListColor.TabIndex = 18;
            this.lblNotesListColor.Text = "Notes list color:";
            // 
            // cbMultipleInstances
            // 
            this.cbMultipleInstances.AutoSize = true;
            this.cbMultipleInstances.Location = new System.Drawing.Point(24, 42);
            this.cbMultipleInstances.Name = "cbMultipleInstances";
            this.cbMultipleInstances.Size = new System.Drawing.Size(137, 17);
            this.cbMultipleInstances.TabIndex = 18;
            this.cbMultipleInstances.Text = "Allow multiple instances";
            this.cbMultipleInstances.UseVisualStyleBackColor = true;
            // 
            // cbCloseToTray
            // 
            this.cbCloseToTray.AutoSize = true;
            this.cbCloseToTray.Location = new System.Drawing.Point(260, 65);
            this.cbCloseToTray.Name = "cbCloseToTray";
            this.cbCloseToTray.Size = new System.Drawing.Size(107, 17);
            this.cbCloseToTray.TabIndex = 17;
            this.cbCloseToTray.Text = "Close to tray icon";
            this.cbCloseToTray.UseVisualStyleBackColor = true;
            // 
            // cbMinimizeToTray
            // 
            this.cbMinimizeToTray.AutoSize = true;
            this.cbMinimizeToTray.Location = new System.Drawing.Point(260, 42);
            this.cbMinimizeToTray.Name = "cbMinimizeToTray";
            this.cbMinimizeToTray.Size = new System.Drawing.Size(121, 17);
            this.cbMinimizeToTray.TabIndex = 16;
            this.cbMinimizeToTray.Text = "Minimize to tray icon";
            this.cbMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // cbShowInTaskbar
            // 
            this.cbShowInTaskbar.AutoSize = true;
            this.cbShowInTaskbar.Location = new System.Drawing.Point(24, 88);
            this.cbShowInTaskbar.Name = "cbShowInTaskbar";
            this.cbShowInTaskbar.Size = new System.Drawing.Size(102, 17);
            this.cbShowInTaskbar.TabIndex = 15;
            this.cbShowInTaskbar.Text = "Show in taskbar";
            this.cbShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // cbAlwaysOnTop
            // 
            this.cbAlwaysOnTop.AutoSize = true;
            this.cbAlwaysOnTop.Location = new System.Drawing.Point(24, 65);
            this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            this.cbAlwaysOnTop.Size = new System.Drawing.Size(158, 17);
            this.cbAlwaysOnTop.TabIndex = 14;
            this.cbAlwaysOnTop.Text = "Keep window always on top";
            this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // numAutosave
            // 
            this.numAutosave.Location = new System.Drawing.Point(146, 115);
            this.numAutosave.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numAutosave.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAutosave.Name = "numAutosave";
            this.numAutosave.Size = new System.Drawing.Size(52, 20);
            this.numAutosave.TabIndex = 11;
            this.numAutosave.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblAutosaveTime
            // 
            this.lblAutosaveTime.AutoSize = true;
            this.lblAutosaveTime.Location = new System.Drawing.Point(201, 117);
            this.lblAutosaveTime.Name = "lblAutosaveTime";
            this.lblAutosaveTime.Size = new System.Drawing.Size(47, 13);
            this.lblAutosaveTime.TabIndex = 13;
            this.lblAutosaveTime.Text = "seconds";
            // 
            // cbAutosaveTime
            // 
            this.cbAutosaveTime.AutoSize = true;
            this.cbAutosaveTime.Location = new System.Drawing.Point(24, 116);
            this.cbAutosaveTime.Name = "cbAutosaveTime";
            this.cbAutosaveTime.Size = new System.Drawing.Size(124, 17);
            this.cbAutosaveTime.TabIndex = 12;
            this.cbAutosaveTime.Text = "Autosave note every";
            this.cbAutosaveTime.UseVisualStyleBackColor = true;
            // 
            // cbVersions
            // 
            this.cbVersions.AutoSize = true;
            this.cbVersions.Location = new System.Drawing.Point(24, 70);
            this.cbVersions.Name = "cbVersions";
            this.cbVersions.Size = new System.Drawing.Size(252, 17);
            this.cbVersions.TabIndex = 10;
            this.cbVersions.Text = "Number of previous versions to keep in backup:";
            this.cbVersions.UseVisualStyleBackColor = true;
            // 
            // cbAutosaveFocus
            // 
            this.cbAutosaveFocus.AutoSize = true;
            this.cbAutosaveFocus.Location = new System.Drawing.Point(24, 93);
            this.cbAutosaveFocus.Name = "cbAutosaveFocus";
            this.cbAutosaveFocus.Size = new System.Drawing.Size(183, 17);
            this.cbAutosaveFocus.TabIndex = 9;
            this.cbAutosaveFocus.Text = "Autosave note when losing focus";
            this.cbAutosaveFocus.UseVisualStyleBackColor = true;
            // 
            // cbLoadStartup
            // 
            this.cbLoadStartup.AutoSize = true;
            this.cbLoadStartup.Location = new System.Drawing.Point(24, 19);
            this.cbLoadStartup.Name = "cbLoadStartup";
            this.cbLoadStartup.Size = new System.Drawing.Size(191, 17);
            this.cbLoadStartup.TabIndex = 6;
            this.cbLoadStartup.Text = "Run AxelNotes at Windows startup";
            this.cbLoadStartup.UseVisualStyleBackColor = true;
            // 
            // txtBackupFolder
            // 
            this.txtBackupFolder.BackColor = System.Drawing.SystemColors.Info;
            this.txtBackupFolder.Location = new System.Drawing.Point(119, 43);
            this.txtBackupFolder.MaxLength = 1000;
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.txtBackupFolder.Size = new System.Drawing.Size(267, 20);
            this.txtBackupFolder.TabIndex = 5;
            // 
            // txtNotesFolder
            // 
            this.txtNotesFolder.BackColor = System.Drawing.SystemColors.Info;
            this.txtNotesFolder.Location = new System.Drawing.Point(119, 17);
            this.txtNotesFolder.MaxLength = 1000;
            this.txtNotesFolder.Name = "txtNotesFolder";
            this.txtNotesFolder.Size = new System.Drawing.Size(267, 20);
            this.txtNotesFolder.TabIndex = 4;
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.AutoSize = true;
            this.lblBackupFolder.Location = new System.Drawing.Point(21, 46);
            this.lblBackupFolder.Name = "lblBackupFolder";
            this.lblBackupFolder.Size = new System.Drawing.Size(90, 13);
            this.lblBackupFolder.TabIndex = 3;
            this.lblBackupFolder.Text = "Backup directory:";
            // 
            // lblNotesFolder
            // 
            this.lblNotesFolder.AutoSize = true;
            this.lblNotesFolder.Location = new System.Drawing.Point(30, 20);
            this.lblNotesFolder.Name = "lblNotesFolder";
            this.lblNotesFolder.Size = new System.Drawing.Size(81, 13);
            this.lblNotesFolder.TabIndex = 2;
            this.lblNotesFolder.Text = "Notes directory:";
            // 
            // groupText
            // 
            this.groupText.Controls.Add(this.lblColorHeading);
            this.groupText.Controls.Add(this.lblColorText);
            this.groupText.Controls.Add(this.btnFloater);
            this.groupText.Controls.Add(this.lblFloaterColor);
            this.groupText.Controls.Add(this.btnCurrentLineColor);
            this.groupText.Controls.Add(this.lblCurrentLineColor);
            this.groupText.Controls.Add(this.btnBackgroundColor);
            this.groupText.Controls.Add(this.lblBackgroundColor);
            this.groupText.Controls.Add(this.btnHighlightColor);
            this.groupText.Controls.Add(this.lblHighlightColor);
            this.groupText.Controls.Add(this.btnHeadingColor);
            this.groupText.Controls.Add(this.lblFontHeading);
            this.groupText.Controls.Add(this.lblFontHHeadingSample);
            this.groupText.Controls.Add(this.btnTextColor);
            this.groupText.Controls.Add(this.lblFontText);
            this.groupText.Controls.Add(this.lblFontTextSample);
            this.groupText.Location = new System.Drawing.Point(6, 6);
            this.groupText.Name = "groupText";
            this.groupText.Size = new System.Drawing.Size(485, 121);
            this.groupText.TabIndex = 7;
            this.groupText.TabStop = false;
            this.groupText.Text = "Fonts and Colors";
            // 
            // btnFloater
            // 
            this.btnFloater.Location = new System.Drawing.Point(410, 87);
            this.btnFloater.Name = "btnFloater";
            this.btnFloater.Size = new System.Drawing.Size(38, 23);
            this.btnFloater.TabIndex = 21;
            this.btnFloater.UseVisualStyleBackColor = true;
            // 
            // lblFloaterColor
            // 
            this.lblFloaterColor.AutoSize = true;
            this.lblFloaterColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFloaterColor.Location = new System.Drawing.Point(366, 92);
            this.lblFloaterColor.Name = "lblFloaterColor";
            this.lblFloaterColor.Size = new System.Drawing.Size(42, 13);
            this.lblFloaterColor.TabIndex = 20;
            this.lblFloaterColor.Text = "Floater:";
            // 
            // lblTabSize
            // 
            this.lblTabSize.AutoSize = true;
            this.lblTabSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTabSize.Location = new System.Drawing.Point(18, 69);
            this.lblTabSize.Name = "lblTabSize";
            this.lblTabSize.Size = new System.Drawing.Size(50, 13);
            this.lblTabSize.TabIndex = 19;
            this.lblTabSize.Text = "Tab size:";
            // 
            // numTabSize
            // 
            this.numTabSize.Location = new System.Drawing.Point(68, 65);
            this.numTabSize.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numTabSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTabSize.Name = "numTabSize";
            this.numTabSize.Size = new System.Drawing.Size(42, 20);
            this.numTabSize.TabIndex = 18;
            this.numTabSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnCurrentLineColor
            // 
            this.btnCurrentLineColor.Location = new System.Drawing.Point(309, 87);
            this.btnCurrentLineColor.Name = "btnCurrentLineColor";
            this.btnCurrentLineColor.Size = new System.Drawing.Size(38, 23);
            this.btnCurrentLineColor.TabIndex = 17;
            this.btnCurrentLineColor.UseVisualStyleBackColor = true;
            // 
            // lblCurrentLineColor
            // 
            this.lblCurrentLineColor.AutoSize = true;
            this.lblCurrentLineColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrentLineColor.Location = new System.Drawing.Point(244, 92);
            this.lblCurrentLineColor.Name = "lblCurrentLineColor";
            this.lblCurrentLineColor.Size = new System.Drawing.Size(63, 13);
            this.lblCurrentLineColor.TabIndex = 16;
            this.lblCurrentLineColor.Text = "Current line:";
            // 
            // cbLineNumbers
            // 
            this.cbLineNumbers.AutoSize = true;
            this.cbLineNumbers.Location = new System.Drawing.Point(21, 42);
            this.cbLineNumbers.Name = "cbLineNumbers";
            this.cbLineNumbers.Size = new System.Drawing.Size(115, 17);
            this.cbLineNumbers.TabIndex = 15;
            this.cbLineNumbers.Text = "Show line numbers";
            this.cbLineNumbers.UseVisualStyleBackColor = true;
            // 
            // cbLineWrap
            // 
            this.cbLineWrap.AutoSize = true;
            this.cbLineWrap.Location = new System.Drawing.Point(21, 19);
            this.cbLineWrap.Name = "cbLineWrap";
            this.cbLineWrap.Size = new System.Drawing.Size(72, 17);
            this.cbLineWrap.TabIndex = 14;
            this.cbLineWrap.Text = "Line wrap";
            this.cbLineWrap.UseVisualStyleBackColor = true;
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(193, 87);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(38, 23);
            this.btnBackgroundColor.TabIndex = 13;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBackgroundColor.Location = new System.Drawing.Point(123, 92);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(68, 13);
            this.lblBackgroundColor.TabIndex = 12;
            this.lblBackgroundColor.Text = "Background:";
            // 
            // btnHighlightColor
            // 
            this.btnHighlightColor.Location = new System.Drawing.Point(69, 86);
            this.btnHighlightColor.Name = "btnHighlightColor";
            this.btnHighlightColor.Size = new System.Drawing.Size(38, 23);
            this.btnHighlightColor.TabIndex = 11;
            this.btnHighlightColor.UseVisualStyleBackColor = true;
            // 
            // lblHighlightColor
            // 
            this.lblHighlightColor.AutoSize = true;
            this.lblHighlightColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHighlightColor.Location = new System.Drawing.Point(16, 92);
            this.lblHighlightColor.Name = "lblHighlightColor";
            this.lblHighlightColor.Size = new System.Drawing.Size(51, 13);
            this.lblHighlightColor.TabIndex = 10;
            this.lblHighlightColor.Text = "Highlight:";
            // 
            // btnHeadingColor
            // 
            this.btnHeadingColor.Location = new System.Drawing.Point(428, 48);
            this.btnHeadingColor.Name = "btnHeadingColor";
            this.btnHeadingColor.Size = new System.Drawing.Size(38, 23);
            this.btnHeadingColor.TabIndex = 9;
            this.btnHeadingColor.UseVisualStyleBackColor = true;
            // 
            // lblFontHeading
            // 
            this.lblFontHeading.AutoSize = true;
            this.lblFontHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFontHeading.Location = new System.Drawing.Point(10, 53);
            this.lblFontHeading.Name = "lblFontHeading";
            this.lblFontHeading.Size = new System.Drawing.Size(70, 13);
            this.lblFontHeading.TabIndex = 8;
            this.lblFontHeading.Text = "Heading text:";
            // 
            // lblFontHHeadingSample
            // 
            this.lblFontHHeadingSample.BackColor = System.Drawing.SystemColors.Info;
            this.lblFontHHeadingSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFontHHeadingSample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFontHHeadingSample.Location = new System.Drawing.Point(86, 49);
            this.lblFontHHeadingSample.Name = "lblFontHHeadingSample";
            this.lblFontHHeadingSample.Size = new System.Drawing.Size(245, 22);
            this.lblFontHHeadingSample.TabIndex = 7;
            this.lblFontHHeadingSample.Text = "Current Font";
            this.lblFontHHeadingSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(428, 19);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(38, 23);
            this.btnTextColor.TabIndex = 6;
            this.btnTextColor.UseVisualStyleBackColor = true;
            // 
            // lblFontText
            // 
            this.lblFontText.AutoSize = true;
            this.lblFontText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFontText.Location = new System.Drawing.Point(18, 25);
            this.lblFontText.Name = "lblFontText";
            this.lblFontText.Size = new System.Drawing.Size(63, 13);
            this.lblFontText.TabIndex = 1;
            this.lblFontText.Text = "Normal text:";
            // 
            // lblFontTextSample
            // 
            this.lblFontTextSample.BackColor = System.Drawing.SystemColors.Info;
            this.lblFontTextSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFontTextSample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFontTextSample.Location = new System.Drawing.Point(87, 20);
            this.lblFontTextSample.Name = "lblFontTextSample";
            this.lblFontTextSample.Size = new System.Drawing.Size(244, 22);
            this.lblFontTextSample.TabIndex = 0;
            this.lblFontTextSample.Text = "Current Font";
            this.lblFontTextSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupHtml
            // 
            this.groupHtml.Location = new System.Drawing.Point(6, 6);
            this.groupHtml.Name = "groupHtml";
            this.groupHtml.Size = new System.Drawing.Size(485, 82);
            this.groupHtml.TabIndex = 8;
            this.groupHtml.TabStop = false;
            this.groupHtml.Text = "HTML Notes";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabGeneral);
            this.tabSettings.Controls.Add(this.tabText);
            this.tabSettings.Controls.Add(this.tabHtml);
            this.tabSettings.ImageList = this.imageList;
            this.tabSettings.Location = new System.Drawing.Point(12, 12);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.ShowToolTips = true;
            this.tabSettings.Size = new System.Drawing.Size(505, 363);
            this.tabSettings.TabIndex = 9;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupAppearance);
            this.tabGeneral.Controls.Add(this.groupBehavior);
            this.tabGeneral.Controls.Add(this.groupMain);
            this.tabGeneral.ImageKey = "misc_settings.png";
            this.tabGeneral.Location = new System.Drawing.Point(4, 23);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(497, 336);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.ToolTipText = "Change general settings";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.groupTextBeh);
            this.tabText.Controls.Add(this.groupText);
            this.tabText.ImageKey = "note_text.png";
            this.tabText.Location = new System.Drawing.Point(4, 23);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(497, 336);
            this.tabText.TabIndex = 1;
            this.tabText.Text = "Text Notes";
            this.tabText.ToolTipText = "Change settings for text notes";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "misc_settings.png");
            this.imageList.Images.SetKeyName(1, "note_text.png");
            this.imageList.Images.SetKeyName(2, "note_html.png");
            // 
            // tabHtml
            // 
            this.tabHtml.Controls.Add(this.groupHtml);
            this.tabHtml.ImageKey = "note_html.png";
            this.tabHtml.Location = new System.Drawing.Point(4, 23);
            this.tabHtml.Name = "tabHtml";
            this.tabHtml.Padding = new System.Windows.Forms.Padding(3);
            this.tabHtml.Size = new System.Drawing.Size(497, 336);
            this.tabHtml.TabIndex = 2;
            this.tabHtml.Text = "HTML Notes";
            this.tabHtml.ToolTipText = "Change settings for HTML notes";
            this.tabHtml.UseVisualStyleBackColor = true;
            // 
            // groupBehavior
            // 
            this.groupBehavior.Controls.Add(this.cbRecycle);
            this.groupBehavior.Controls.Add(this.cbLoadStartup);
            this.groupBehavior.Controls.Add(this.cbAlwaysOnTop);
            this.groupBehavior.Controls.Add(this.cbShowInTaskbar);
            this.groupBehavior.Controls.Add(this.cbMultipleInstances);
            this.groupBehavior.Controls.Add(this.cbMinimizeToTray);
            this.groupBehavior.Controls.Add(this.cbCloseToTray);
            this.groupBehavior.Location = new System.Drawing.Point(6, 156);
            this.groupBehavior.Name = "groupBehavior";
            this.groupBehavior.Size = new System.Drawing.Size(485, 113);
            this.groupBehavior.TabIndex = 7;
            this.groupBehavior.TabStop = false;
            this.groupBehavior.Text = "Behavior";
            // 
            // groupAppearance
            // 
            this.groupAppearance.Controls.Add(this.btnNotesListColor);
            this.groupAppearance.Controls.Add(this.lblNotesListColor);
            this.groupAppearance.Location = new System.Drawing.Point(6, 275);
            this.groupAppearance.Name = "groupAppearance";
            this.groupAppearance.Size = new System.Drawing.Size(485, 53);
            this.groupAppearance.TabIndex = 8;
            this.groupAppearance.TabStop = false;
            this.groupAppearance.Text = "Appearance";
            // 
            // groupTextBeh
            // 
            this.groupTextBeh.Controls.Add(this.lblTabSize);
            this.groupTextBeh.Controls.Add(this.cbLineWrap);
            this.groupTextBeh.Controls.Add(this.cbLineNumbers);
            this.groupTextBeh.Controls.Add(this.numTabSize);
            this.groupTextBeh.Location = new System.Drawing.Point(6, 133);
            this.groupTextBeh.Name = "groupTextBeh";
            this.groupTextBeh.Size = new System.Drawing.Size(485, 93);
            this.groupTextBeh.TabIndex = 8;
            this.groupTextBeh.TabStop = false;
            this.groupTextBeh.Text = "Behavior";
            // 
            // lblColorHeading
            // 
            this.lblColorHeading.AutoSize = true;
            this.lblColorHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColorHeading.Location = new System.Drawing.Point(349, 53);
            this.lblColorHeading.Name = "lblColorHeading";
            this.lblColorHeading.Size = new System.Drawing.Size(76, 13);
            this.lblColorHeading.TabIndex = 23;
            this.lblColorHeading.Text = "Heading color:";
            // 
            // lblColorText
            // 
            this.lblColorText.AutoSize = true;
            this.lblColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColorText.Location = new System.Drawing.Point(356, 24);
            this.lblColorText.Name = "lblColorText";
            this.lblColorText.Size = new System.Drawing.Size(69, 13);
            this.lblColorText.TabIndex = 22;
            this.lblColorText.Text = "Normal color:";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(528, 411);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings - AxelNotes";
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVersions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutosave)).EndInit();
            this.groupText.ResumeLayout(false);
            this.groupText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTabSize)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabHtml.ResumeLayout(false);
            this.groupBehavior.ResumeLayout(false);
            this.groupBehavior.PerformLayout();
            this.groupAppearance.ResumeLayout(false);
            this.groupAppearance.PerformLayout();
            this.groupTextBeh.ResumeLayout(false);
            this.groupTextBeh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseNotes;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.TextBox txtNotesFolder;
        private System.Windows.Forms.Label lblBackupFolder;
        private System.Windows.Forms.Label lblNotesFolder;
        private System.Windows.Forms.CheckBox cbLoadStartup;
        private System.Windows.Forms.TextBox txtBackupFolder;
        private System.Windows.Forms.NumericUpDown numVersions;
        private System.Windows.Forms.CheckBox cbAutosaveTime;
        private System.Windows.Forms.NumericUpDown numAutosave;
        private System.Windows.Forms.CheckBox cbVersions;
        private System.Windows.Forms.CheckBox cbAutosaveFocus;
        private System.Windows.Forms.Label lblAutosaveTime;
        private System.Windows.Forms.GroupBox groupText;
        private System.Windows.Forms.Label lblFontText;
        private System.Windows.Forms.Label lblFontTextSample;
        private System.Windows.Forms.Button btnHeadingColor;
        private System.Windows.Forms.Label lblFontHeading;
        private System.Windows.Forms.Label lblFontHHeadingSample;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.Windows.Forms.CheckBox cbLineNumbers;
        private System.Windows.Forms.CheckBox cbLineWrap;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Button btnHighlightColor;
        private System.Windows.Forms.Label lblHighlightColor;
        private System.Windows.Forms.Button btnCurrentLineColor;
        private System.Windows.Forms.Label lblCurrentLineColor;
        private System.Windows.Forms.GroupBox groupHtml;
        private System.Windows.Forms.CheckBox cbCloseToTray;
        private System.Windows.Forms.CheckBox cbMinimizeToTray;
        private System.Windows.Forms.CheckBox cbShowInTaskbar;
        private System.Windows.Forms.CheckBox cbMultipleInstances;
        private System.Windows.Forms.Button btnNotesListColor;
        private System.Windows.Forms.Label lblNotesListColor;
        private System.Windows.Forms.CheckBox cbRecycle;
        private System.Windows.Forms.Button btnFloater;
        private System.Windows.Forms.Label lblFloaterColor;
        private System.Windows.Forms.Label lblTabSize;
        private System.Windows.Forms.NumericUpDown numTabSize;
        private System.Windows.Forms.Label lblColorHeading;
        private System.Windows.Forms.Label lblColorText;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox groupAppearance;
        private System.Windows.Forms.GroupBox groupBehavior;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.GroupBox groupTextBeh;
        private System.Windows.Forms.TabPage tabHtml;
        private System.Windows.Forms.ImageList imageList;
    }
}