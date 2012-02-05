namespace AxelNotes
{
    partial class RenameBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameBox));
            this.pnlRename = new System.Windows.Forms.Panel();
            this.lblRenameValidate = new System.Windows.Forms.Label();
            this.cbxRenameGroups = new System.Windows.Forms.ComboBox();
            this.lblRenameGroup = new System.Windows.Forms.Label();
            this.lblRenameTxt = new System.Windows.Forms.Label();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.pbRename = new System.Windows.Forms.PictureBox();
            this.btnRenameClose = new System.Windows.Forms.Button();
            this.pnlRename.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRename)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRename
            // 
            this.pnlRename.Controls.Add(this.lblRenameValidate);
            this.pnlRename.Controls.Add(this.pbRename);
            this.pnlRename.Controls.Add(this.cbxRenameGroups);
            this.pnlRename.Controls.Add(this.lblRenameGroup);
            this.pnlRename.Controls.Add(this.lblRenameTxt);
            this.pnlRename.Controls.Add(this.txtRename);
            this.pnlRename.Controls.Add(this.btnRenameClose);
            this.pnlRename.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRename.Location = new System.Drawing.Point(0, 0);
            this.pnlRename.Name = "pnlRename";
            this.pnlRename.Size = new System.Drawing.Size(700, 34);
            this.pnlRename.TabIndex = 9;
            // 
            // lblRenameValidate
            // 
            this.lblRenameValidate.AutoSize = true;
            this.lblRenameValidate.Location = new System.Drawing.Point(404, 11);
            this.lblRenameValidate.Name = "lblRenameValidate";
            this.lblRenameValidate.Size = new System.Drawing.Size(91, 13);
            this.lblRenameValidate.TabIndex = 9;
            this.lblRenameValidate.Text = "Invalid note name";
            // 
            // cbxRenameGroups
            // 
            this.cbxRenameGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRenameGroups.FormattingEnabled = true;
            this.cbxRenameGroups.Location = new System.Drawing.Point(230, 8);
            this.cbxRenameGroups.Name = "cbxRenameGroups";
            this.cbxRenameGroups.Size = new System.Drawing.Size(143, 21);
            this.cbxRenameGroups.TabIndex = 4;
            // 
            // lblRenameGroup
            // 
            this.lblRenameGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRenameGroup.AutoSize = true;
            this.lblRenameGroup.Location = new System.Drawing.Point(188, 11);
            this.lblRenameGroup.Name = "lblRenameGroup";
            this.lblRenameGroup.Size = new System.Drawing.Size(39, 13);
            this.lblRenameGroup.TabIndex = 3;
            this.lblRenameGroup.Text = "Group:";
            // 
            // lblRenameTxt
            // 
            this.lblRenameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRenameTxt.AutoSize = true;
            this.lblRenameTxt.Location = new System.Drawing.Point(30, 11);
            this.lblRenameTxt.Name = "lblRenameTxt";
            this.lblRenameTxt.Size = new System.Drawing.Size(50, 13);
            this.lblRenameTxt.TabIndex = 2;
            this.lblRenameTxt.Text = "Rename:";
            // 
            // txtRename
            // 
            this.txtRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRename.BackColor = System.Drawing.SystemColors.Window;
            this.txtRename.Location = new System.Drawing.Point(83, 8);
            this.txtRename.MaxLength = 256;
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(98, 20);
            this.txtRename.TabIndex = 1;
            // 
            // pbRename
            // 
            this.pbRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbRename.Image = ((System.Drawing.Image)(resources.GetObject("pbRename.Image")));
            this.pbRename.Location = new System.Drawing.Point(380, 7);
            this.pbRename.Name = "pbRename";
            this.pbRename.Size = new System.Drawing.Size(22, 22);
            this.pbRename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRename.TabIndex = 8;
            this.pbRename.TabStop = false;
            // 
            // btnRenameClose
            // 
            this.btnRenameClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRenameClose.AutoSize = true;
            this.btnRenameClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRenameClose.Image = ((System.Drawing.Image)(resources.GetObject("btnRenameClose.Image")));
            this.btnRenameClose.Location = new System.Drawing.Point(4, 7);
            this.btnRenameClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnRenameClose.Name = "btnRenameClose";
            this.btnRenameClose.Size = new System.Drawing.Size(22, 22);
            this.btnRenameClose.TabIndex = 0;
            this.btnRenameClose.UseVisualStyleBackColor = true;
            // 
            // RenameBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRename);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RenameBox";
            this.Size = new System.Drawing.Size(700, 34);
            this.pnlRename.ResumeLayout(false);
            this.pnlRename.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRename)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRename;
        private System.Windows.Forms.Label lblRenameValidate;
        private System.Windows.Forms.PictureBox pbRename;
        private System.Windows.Forms.ComboBox cbxRenameGroups;
        private System.Windows.Forms.Label lblRenameGroup;
        private System.Windows.Forms.Label lblRenameTxt;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Button btnRenameClose;
    }
}
