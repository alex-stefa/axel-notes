namespace AxelNotes
{
    partial class HighlightTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighlightTextBox));
            this.editStrip = new System.Windows.Forms.ToolStrip();
            this.editSave = new System.Windows.Forms.ToolStripSplitButton();
            this.editReload = new System.Windows.Forms.ToolStripMenuItem();
            this.editConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.editSaveSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.editRename = new System.Windows.Forms.ToolStripMenuItem();
            this.editSaveSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.editLock = new System.Windows.Forms.ToolStripMenuItem();
            this.editPin = new System.Windows.Forms.ToolStripMenuItem();
            this.editFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.editSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.editHeading = new System.Windows.Forms.ToolStripButton();
            this.editHighlight = new System.Windows.Forms.ToolStripButton();
            this.editSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.editIndentLeft = new System.Windows.Forms.ToolStripButton();
            this.editIndentRight = new System.Windows.Forms.ToolStripButton();
            this.editSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.editSearch = new System.Windows.Forms.ToolStripButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.editStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // editStrip
            // 
            this.editStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.editStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSave,
            this.editSep1,
            this.editHeading,
            this.editHighlight,
            this.editSep2,
            this.editIndentLeft,
            this.editIndentRight,
            this.editSep3,
            this.editSearch});
            this.editStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.editStrip.Location = new System.Drawing.Point(0, 0);
            this.editStrip.Name = "editStrip";
            this.editStrip.Size = new System.Drawing.Size(679, 23);
            this.editStrip.TabIndex = 5;
            this.editStrip.Text = "toolStrip1";
            // 
            // editSave
            // 
            this.editSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editReload,
            this.editConvert,
            this.editSaveSep1,
            this.editRename,
            this.editSaveSep2,
            this.editFloat,
            this.editLock,
            this.editPin});
            this.editSave.Image = ((System.Drawing.Image)(resources.GetObject("editSave.Image")));
            this.editSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editSave.Name = "editSave";
            this.editSave.Size = new System.Drawing.Size(32, 20);
            this.editSave.Text = "toolStripDropDownButton1";
            // 
            // editReload
            // 
            this.editReload.Image = ((System.Drawing.Image)(resources.GetObject("editReload.Image")));
            this.editReload.Name = "editReload";
            this.editReload.Size = new System.Drawing.Size(152, 22);
            this.editReload.Text = "Reload";
            // 
            // editConvert
            // 
            this.editConvert.Image = ((System.Drawing.Image)(resources.GetObject("editConvert.Image")));
            this.editConvert.Name = "editConvert";
            this.editConvert.Size = new System.Drawing.Size(152, 22);
            this.editConvert.Text = "Convert";
            // 
            // editSaveSep1
            // 
            this.editSaveSep1.Name = "editSaveSep1";
            this.editSaveSep1.Size = new System.Drawing.Size(149, 6);
            // 
            // editRename
            // 
            this.editRename.Image = ((System.Drawing.Image)(resources.GetObject("editRename.Image")));
            this.editRename.Name = "editRename";
            this.editRename.Size = new System.Drawing.Size(152, 22);
            this.editRename.Text = "Rename";
            // 
            // editSaveSep2
            // 
            this.editSaveSep2.Name = "editSaveSep2";
            this.editSaveSep2.Size = new System.Drawing.Size(149, 6);
            // 
            // editLock
            // 
            this.editLock.Image = ((System.Drawing.Image)(resources.GetObject("editLock.Image")));
            this.editLock.Name = "editLock";
            this.editLock.Size = new System.Drawing.Size(152, 22);
            this.editLock.Text = "Lock";
            // 
            // editPin
            // 
            this.editPin.Image = ((System.Drawing.Image)(resources.GetObject("editPin.Image")));
            this.editPin.Name = "editPin";
            this.editPin.Size = new System.Drawing.Size(152, 22);
            this.editPin.Text = "Pin";
            // 
            // editFloat
            // 
            this.editFloat.Image = ((System.Drawing.Image)(resources.GetObject("editFloat.Image")));
            this.editFloat.Name = "editFloat";
            this.editFloat.Size = new System.Drawing.Size(152, 22);
            this.editFloat.Text = "Float";
            // 
            // editSep1
            // 
            this.editSep1.Name = "editSep1";
            this.editSep1.Size = new System.Drawing.Size(6, 23);
            // 
            // editHeading
            // 
            this.editHeading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editHeading.Image = ((System.Drawing.Image)(resources.GetObject("editHeading.Image")));
            this.editHeading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editHeading.Name = "editHeading";
            this.editHeading.Size = new System.Drawing.Size(23, 20);
            this.editHeading.Text = "toolStripButton1";
            // 
            // editHighlight
            // 
            this.editHighlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editHighlight.Image = ((System.Drawing.Image)(resources.GetObject("editHighlight.Image")));
            this.editHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editHighlight.Name = "editHighlight";
            this.editHighlight.Size = new System.Drawing.Size(23, 20);
            this.editHighlight.Text = "toolStripButton1";
            // 
            // editSep2
            // 
            this.editSep2.Name = "editSep2";
            this.editSep2.Size = new System.Drawing.Size(6, 23);
            // 
            // editIndentLeft
            // 
            this.editIndentLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editIndentLeft.Image = ((System.Drawing.Image)(resources.GetObject("editIndentLeft.Image")));
            this.editIndentLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editIndentLeft.Name = "editIndentLeft";
            this.editIndentLeft.Size = new System.Drawing.Size(23, 20);
            this.editIndentLeft.Text = "toolStripButton1";
            // 
            // editIndentRight
            // 
            this.editIndentRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editIndentRight.Image = ((System.Drawing.Image)(resources.GetObject("editIndentRight.Image")));
            this.editIndentRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editIndentRight.Name = "editIndentRight";
            this.editIndentRight.Size = new System.Drawing.Size(23, 20);
            this.editIndentRight.Text = "toolStripButton1";
            // 
            // editSep3
            // 
            this.editSep3.Name = "editSep3";
            this.editSep3.Size = new System.Drawing.Size(6, 23);
            // 
            // editSearch
            // 
            this.editSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editSearch.Image = ((System.Drawing.Image)(resources.GetObject("editSearch.Image")));
            this.editSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editSearch.Name = "editSearch";
            this.editSearch.Size = new System.Drawing.Size(23, 20);
            this.editSearch.Text = "toolStripButton1";
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 23);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(679, 219);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // HighlightTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.editStrip);
            this.Name = "HighlightTextBox";
            this.Size = new System.Drawing.Size(679, 242);
            this.editStrip.ResumeLayout(false);
            this.editStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip editStrip;
        private System.Windows.Forms.ToolStripButton editIndentLeft;
        private System.Windows.Forms.ToolStripButton editIndentRight;
        private System.Windows.Forms.ToolStripSeparator editSep2;
        private System.Windows.Forms.ToolStripSeparator editSep3;
        private System.Windows.Forms.ToolStripButton editSearch;
        private System.Windows.Forms.ToolStripButton editHeading;
        private System.Windows.Forms.ToolStripButton editHighlight;
        private System.Windows.Forms.ToolStripSeparator editSep1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripSplitButton editSave;
        private System.Windows.Forms.ToolStripMenuItem editRename;
        private System.Windows.Forms.ToolStripMenuItem editConvert;
        private System.Windows.Forms.ToolStripMenuItem editReload;
        private System.Windows.Forms.ToolStripSeparator editSaveSep1;
        private System.Windows.Forms.ToolStripSeparator editSaveSep2;
        private System.Windows.Forms.ToolStripMenuItem editLock;
        private System.Windows.Forms.ToolStripMenuItem editPin;
        private System.Windows.Forms.ToolStripMenuItem editFloat;

    }
}
