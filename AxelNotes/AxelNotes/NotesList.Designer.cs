namespace AxelNotes
{
    partial class NotesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesList));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Unfiled");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pinned", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node2");
            this.mainStrip = new System.Windows.Forms.ToolStrip();
            this.mainNewTextNote = new System.Windows.Forms.ToolStripButton();
            this.mainNewHtmlNote = new System.Windows.Forms.ToolStripButton();
            this.mainNewGroup = new System.Windows.Forms.ToolStripButton();
            this.mainSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainFind = new System.Windows.Forms.ToolStripButton();
            this.mainSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainSaveAll = new System.Windows.Forms.ToolStripButton();
            this.mainReload = new System.Windows.Forms.ToolStripButton();
            this.mainSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainDeleteNote = new System.Windows.Forms.ToolStripButton();
            this.mainSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.mainSettings = new System.Windows.Forms.ToolStripButton();
            this.mainAbout = new System.Windows.Forms.ToolStripButton();
            this.imagesNotes = new System.Windows.Forms.ImageList(this.components);
            this.menuNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuNewTextNote = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewHtmlNote = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExpandThis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCollapseThis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.treeNotes = new System.Windows.Forms.TreeView();
            this.mainStrip.SuspendLayout();
            this.menuNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStrip
            // 
            this.mainStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainNewTextNote,
            this.mainNewHtmlNote,
            this.mainNewGroup,
            this.mainSep1,
            this.mainFind,
            this.mainSep2,
            this.mainSaveAll,
            this.mainReload,
            this.mainSep3,
            this.mainDeleteNote,
            this.mainSep4,
            this.mainSettings,
            this.mainAbout});
            this.mainStrip.Location = new System.Drawing.Point(0, 0);
            this.mainStrip.Name = "mainStrip";
            this.mainStrip.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.mainStrip.Size = new System.Drawing.Size(26, 416);
            this.mainStrip.TabIndex = 0;
            // 
            // mainNewTextNote
            // 
            this.mainNewTextNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainNewTextNote.Image = ((System.Drawing.Image)(resources.GetObject("mainNewTextNote.Image")));
            this.mainNewTextNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainNewTextNote.Name = "mainNewTextNote";
            this.mainNewTextNote.Size = new System.Drawing.Size(19, 20);
            this.mainNewTextNote.Text = "toolStripButton1";
            // 
            // mainNewHtmlNote
            // 
            this.mainNewHtmlNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainNewHtmlNote.Image = ((System.Drawing.Image)(resources.GetObject("mainNewHtmlNote.Image")));
            this.mainNewHtmlNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainNewHtmlNote.Name = "mainNewHtmlNote";
            this.mainNewHtmlNote.Size = new System.Drawing.Size(19, 20);
            this.mainNewHtmlNote.Text = "toolStripButton1";
            // 
            // mainNewGroup
            // 
            this.mainNewGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainNewGroup.Image = ((System.Drawing.Image)(resources.GetObject("mainNewGroup.Image")));
            this.mainNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainNewGroup.Name = "mainNewGroup";
            this.mainNewGroup.Size = new System.Drawing.Size(19, 20);
            this.mainNewGroup.Text = "toolStripButton1";
            // 
            // mainSep1
            // 
            this.mainSep1.Name = "mainSep1";
            this.mainSep1.Size = new System.Drawing.Size(19, 6);
            // 
            // mainFind
            // 
            this.mainFind.CheckOnClick = true;
            this.mainFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainFind.Image = ((System.Drawing.Image)(resources.GetObject("mainFind.Image")));
            this.mainFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainFind.Name = "mainFind";
            this.mainFind.Size = new System.Drawing.Size(19, 20);
            this.mainFind.Text = "Filter (Ctrl+F)";
            // 
            // mainSep2
            // 
            this.mainSep2.Name = "mainSep2";
            this.mainSep2.Size = new System.Drawing.Size(19, 6);
            // 
            // mainSaveAll
            // 
            this.mainSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("mainSaveAll.Image")));
            this.mainSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainSaveAll.Name = "mainSaveAll";
            this.mainSaveAll.Size = new System.Drawing.Size(19, 20);
            this.mainSaveAll.Text = "toolStripButton2";
            // 
            // mainReload
            // 
            this.mainReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainReload.Image = ((System.Drawing.Image)(resources.GetObject("mainReload.Image")));
            this.mainReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainReload.Name = "mainReload";
            this.mainReload.Size = new System.Drawing.Size(19, 20);
            this.mainReload.Text = "toolStripButton1";
            this.mainReload.Click += new System.EventHandler(this.mainReload_Click);
            // 
            // mainSep3
            // 
            this.mainSep3.Name = "mainSep3";
            this.mainSep3.Size = new System.Drawing.Size(19, 6);
            // 
            // mainDeleteNote
            // 
            this.mainDeleteNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainDeleteNote.Image = ((System.Drawing.Image)(resources.GetObject("mainDeleteNote.Image")));
            this.mainDeleteNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainDeleteNote.Name = "mainDeleteNote";
            this.mainDeleteNote.Size = new System.Drawing.Size(19, 20);
            this.mainDeleteNote.Text = "toolStripButton1";
            // 
            // mainSep4
            // 
            this.mainSep4.Name = "mainSep4";
            this.mainSep4.Size = new System.Drawing.Size(19, 6);
            // 
            // mainSettings
            // 
            this.mainSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainSettings.Image = ((System.Drawing.Image)(resources.GetObject("mainSettings.Image")));
            this.mainSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainSettings.Name = "mainSettings";
            this.mainSettings.Size = new System.Drawing.Size(19, 20);
            this.mainSettings.Text = "toolStripButton1";
            this.mainSettings.Click += new System.EventHandler(this.mainSettings_Click);
            // 
            // mainAbout
            // 
            this.mainAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainAbout.Image = ((System.Drawing.Image)(resources.GetObject("mainAbout.Image")));
            this.mainAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainAbout.Name = "mainAbout";
            this.mainAbout.Size = new System.Drawing.Size(19, 20);
            this.mainAbout.Text = "About / Help (F1)";
            this.mainAbout.ToolTipText = "About / Help (F1)";
            this.mainAbout.Click += new System.EventHandler(this.mainAbout_Click);
            // 
            // imagesNotes
            // 
            this.imagesNotes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesNotes.ImageStream")));
            this.imagesNotes.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesNotes.Images.SetKeyName(0, "blank.png");
            this.imagesNotes.Images.SetKeyName(1, "note_text.png");
            this.imagesNotes.Images.SetKeyName(2, "note_html.png");
            this.imagesNotes.Images.SetKeyName(3, "note_text_locked.png");
            this.imagesNotes.Images.SetKeyName(4, "note_html_locked.png");
            this.imagesNotes.Images.SetKeyName(5, "notes_pinned.png");
            // 
            // menuNotes
            // 
            this.menuNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewTextNote,
            this.menuNewHtmlNote,
            this.menuNewGroup,
            this.menuSep1,
            this.menuRename,
            this.menuConvert,
            this.menuSave,
            this.menuReload,
            this.menuSep2,
            this.menuPin,
            this.menuLock,
            this.menuSep3,
            this.menuDelete,
            this.menuSep4,
            this.menuExpandThis,
            this.menuCollapseThis,
            this.menuSep5,
            this.menuExpandAll,
            this.menuCollapseAll,
            this.menuSep6,
            this.menuQuit});
            this.menuNotes.Name = "menuNotes";
            this.menuNotes.Size = new System.Drawing.Size(182, 370);
            // 
            // menuNewTextNote
            // 
            this.menuNewTextNote.Image = ((System.Drawing.Image)(resources.GetObject("menuNewTextNote.Image")));
            this.menuNewTextNote.Name = "menuNewTextNote";
            this.menuNewTextNote.Size = new System.Drawing.Size(181, 22);
            this.menuNewTextNote.Text = "New Plain &Text Note";
            // 
            // menuNewHtmlNote
            // 
            this.menuNewHtmlNote.Image = ((System.Drawing.Image)(resources.GetObject("menuNewHtmlNote.Image")));
            this.menuNewHtmlNote.Name = "menuNewHtmlNote";
            this.menuNewHtmlNote.Size = new System.Drawing.Size(181, 22);
            this.menuNewHtmlNote.Text = "New &HTML Note ";
            // 
            // menuNewGroup
            // 
            this.menuNewGroup.Image = ((System.Drawing.Image)(resources.GetObject("menuNewGroup.Image")));
            this.menuNewGroup.Name = "menuNewGroup";
            this.menuNewGroup.Size = new System.Drawing.Size(181, 22);
            this.menuNewGroup.Text = "New Note &Group";
            // 
            // menuSep1
            // 
            this.menuSep1.Name = "menuSep1";
            this.menuSep1.Size = new System.Drawing.Size(178, 6);
            // 
            // menuRename
            // 
            this.menuRename.Image = ((System.Drawing.Image)(resources.GetObject("menuRename.Image")));
            this.menuRename.Name = "menuRename";
            this.menuRename.Size = new System.Drawing.Size(181, 22);
            this.menuRename.Text = "Rena&me";
            // 
            // menuConvert
            // 
            this.menuConvert.Image = ((System.Drawing.Image)(resources.GetObject("menuConvert.Image")));
            this.menuConvert.Name = "menuConvert";
            this.menuConvert.Size = new System.Drawing.Size(181, 22);
            this.menuConvert.Text = "&Convert";
            // 
            // menuSave
            // 
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(181, 22);
            this.menuSave.Text = "&Save";
            // 
            // menuReload
            // 
            this.menuReload.Image = ((System.Drawing.Image)(resources.GetObject("menuReload.Image")));
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(181, 22);
            this.menuReload.Text = "Re&load";
            // 
            // menuSep2
            // 
            this.menuSep2.Name = "menuSep2";
            this.menuSep2.Size = new System.Drawing.Size(178, 6);
            // 
            // menuPin
            // 
            this.menuPin.Image = ((System.Drawing.Image)(resources.GetObject("menuPin.Image")));
            this.menuPin.Name = "menuPin";
            this.menuPin.Size = new System.Drawing.Size(181, 22);
            this.menuPin.Text = "Pin Note(s)";
            // 
            // menuLock
            // 
            this.menuLock.Image = ((System.Drawing.Image)(resources.GetObject("menuLock.Image")));
            this.menuLock.Name = "menuLock";
            this.menuLock.Size = new System.Drawing.Size(181, 22);
            this.menuLock.Text = "Lock Note(s)";
            // 
            // menuSep3
            // 
            this.menuSep3.Name = "menuSep3";
            this.menuSep3.Size = new System.Drawing.Size(178, 6);
            // 
            // menuDelete
            // 
            this.menuDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuDelete.Image")));
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(181, 22);
            this.menuDelete.Text = "&Delete";
            // 
            // menuSep4
            // 
            this.menuSep4.Name = "menuSep4";
            this.menuSep4.Size = new System.Drawing.Size(178, 6);
            // 
            // menuExpandThis
            // 
            this.menuExpandThis.Image = ((System.Drawing.Image)(resources.GetObject("menuExpandThis.Image")));
            this.menuExpandThis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuExpandThis.Name = "menuExpandThis";
            this.menuExpandThis.Size = new System.Drawing.Size(181, 22);
            this.menuExpandThis.Text = "Expand";
            // 
            // menuCollapseThis
            // 
            this.menuCollapseThis.Image = ((System.Drawing.Image)(resources.GetObject("menuCollapseThis.Image")));
            this.menuCollapseThis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCollapseThis.Name = "menuCollapseThis";
            this.menuCollapseThis.Size = new System.Drawing.Size(181, 22);
            this.menuCollapseThis.Text = "Collapse";
            // 
            // menuSep5
            // 
            this.menuSep5.Name = "menuSep5";
            this.menuSep5.Size = new System.Drawing.Size(178, 6);
            // 
            // menuExpandAll
            // 
            this.menuExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("menuExpandAll.Image")));
            this.menuExpandAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuExpandAll.Name = "menuExpandAll";
            this.menuExpandAll.Size = new System.Drawing.Size(181, 22);
            this.menuExpandAll.Text = "Expand All";
            this.menuExpandAll.Click += new System.EventHandler(this.menuExpandAll_Click);
            // 
            // menuCollapseAll
            // 
            this.menuCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("menuCollapseAll.Image")));
            this.menuCollapseAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCollapseAll.Name = "menuCollapseAll";
            this.menuCollapseAll.Size = new System.Drawing.Size(181, 22);
            this.menuCollapseAll.Text = "Collapse All";
            this.menuCollapseAll.Click += new System.EventHandler(this.menuCollapseAll_Click);
            // 
            // menuSep6
            // 
            this.menuSep6.Name = "menuSep6";
            this.menuSep6.Size = new System.Drawing.Size(178, 6);
            // 
            // menuQuit
            // 
            this.menuQuit.Image = ((System.Drawing.Image)(resources.GetObject("menuQuit.Image")));
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(181, 22);
            this.menuQuit.Text = "&Quit";
            // 
            // treeNotes
            // 
            this.treeNotes.AllowDrop = true;
            this.treeNotes.ContextMenuStrip = this.menuNotes;
            this.treeNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeNotes.FullRowSelect = true;
            this.treeNotes.HideSelection = false;
            this.treeNotes.ImageIndex = 0;
            this.treeNotes.ImageList = this.imagesNotes;
            this.treeNotes.Indent = 10;
            this.treeNotes.Location = new System.Drawing.Point(26, 0);
            this.treeNotes.Name = "treeNotes";
            treeNode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(99)))));
            treeNode1.ImageKey = "note_group.png";
            treeNode1.Name = "Node6";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode1.SelectedImageKey = "note_group.png";
            treeNode1.Text = "Unfiled";
            treeNode2.ImageKey = "note_text.png";
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageKey = "note_text.png";
            treeNode2.StateImageKey = "notes_pinned.png";
            treeNode2.Text = "Node3";
            treeNode3.ImageKey = "note_html.png";
            treeNode3.Name = "Node4";
            treeNode3.SelectedImageKey = "note_html.png";
            treeNode3.StateImageKey = "blank.png";
            treeNode3.Text = "Node4";
            treeNode4.ImageKey = "note_html.png";
            treeNode4.Name = "Node5";
            treeNode4.SelectedImageKey = "note_html.png";
            treeNode4.StateImageKey = "notes_pinned.png";
            treeNode4.Text = "Node5";
            treeNode5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(99)))));
            treeNode5.ImageKey = "note_group.png";
            treeNode5.Name = "Node1";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode5.SelectedImageKey = "note_group.png";
            treeNode5.Text = "Pinned";
            treeNode6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(99)))));
            treeNode6.ImageKey = "note_group.png";
            treeNode6.Name = "Node2";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            treeNode6.SelectedImageKey = "note_group.png";
            treeNode6.Text = "Node2";
            this.treeNotes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6});
            this.treeNotes.SelectedImageIndex = 0;
            this.treeNotes.ShowLines = false;
            this.treeNotes.ShowRootLines = false;
            this.treeNotes.Size = new System.Drawing.Size(231, 416);
            this.treeNotes.StateImageList = this.imagesNotes;
            this.treeNotes.TabIndex = 1;
            // 
            // NotesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeNotes);
            this.Controls.Add(this.mainStrip);
            this.Name = "NotesList";
            this.Size = new System.Drawing.Size(257, 416);
            this.mainStrip.ResumeLayout(false);
            this.mainStrip.PerformLayout();
            this.menuNotes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainStrip;
        private System.Windows.Forms.ToolStripButton mainNewTextNote;
        private System.Windows.Forms.ToolStripButton mainNewHtmlNote;
        private System.Windows.Forms.ToolStripButton mainNewGroup;
        private System.Windows.Forms.ToolStripButton mainDeleteNote;
        private System.Windows.Forms.ToolStripButton mainFind;
        private System.Windows.Forms.ToolStripButton mainAbout;
        private System.Windows.Forms.ToolStripButton mainSettings;
        private System.Windows.Forms.ToolStripSeparator mainSep1;
        private System.Windows.Forms.ToolStripSeparator mainSep2;
        private System.Windows.Forms.ContextMenuStrip menuNotes;
        private System.Windows.Forms.ToolStripSeparator mainSep3;
        private System.Windows.Forms.ImageList imagesNotes;
        private System.Windows.Forms.TreeView treeNotes;
        private System.Windows.Forms.ToolStripButton mainSaveAll;
        private System.Windows.Forms.ToolStripButton mainReload;
        private System.Windows.Forms.ToolStripSeparator mainSep4;
        private System.Windows.Forms.ToolStripMenuItem menuNewTextNote;
        private System.Windows.Forms.ToolStripMenuItem menuNewHtmlNote;
        private System.Windows.Forms.ToolStripMenuItem menuNewGroup;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
        private System.Windows.Forms.ToolStripMenuItem menuRename;
        private System.Windows.Forms.ToolStripMenuItem menuConvert;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripSeparator menuSep2;
        private System.Windows.Forms.ToolStripMenuItem menuPin;
        private System.Windows.Forms.ToolStripMenuItem menuLock;
        private System.Windows.Forms.ToolStripSeparator menuSep3;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripSeparator menuSep4;
        private System.Windows.Forms.ToolStripMenuItem menuExpandThis;
        private System.Windows.Forms.ToolStripMenuItem menuCollapseThis;
        private System.Windows.Forms.ToolStripSeparator menuSep5;
        private System.Windows.Forms.ToolStripMenuItem menuExpandAll;
        private System.Windows.Forms.ToolStripMenuItem menuCollapseAll;
        private System.Windows.Forms.ToolStripSeparator menuSep6;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
    }
}
