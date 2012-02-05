namespace AxelNotes
{
    partial class FindBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBox));
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnFindPrev = new System.Windows.Forms.Button();
            this.btnMatchCase = new System.Windows.Forms.CheckBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblReplaceToggle = new System.Windows.Forms.LinkLabel();
            this.lblFindResult = new System.Windows.Forms.Label();
            this.pbFind = new System.Windows.Forms.PictureBox();
            this.lblSearchTxt = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnSearchClose = new System.Windows.Forms.Button();
            this.pnlReplace = new System.Windows.Forms.Panel();
            this.lblReplaceTxt = new System.Windows.Forms.Label();
            this.btnSelectionOnly = new System.Windows.Forms.CheckBox();
            this.btnUndoOne = new System.Windows.Forms.Button();
            this.btnUndoAll = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnReplaceNext = new System.Windows.Forms.Button();
            this.pnlFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind)).BeginInit();
            this.pnlReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFind
            // 
            this.pnlFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFind.Controls.Add(this.btnSelectionOnly);
            this.pnlFind.Controls.Add(this.btnFindNext);
            this.pnlFind.Controls.Add(this.btnFindPrev);
            this.pnlFind.Controls.Add(this.btnMatchCase);
            this.pnlFind.Controls.Add(this.lblReplaceToggle);
            this.pnlFind.Controls.Add(this.lblFindResult);
            this.pnlFind.Controls.Add(this.pbFind);
            this.pnlFind.Controls.Add(this.lblSearchTxt);
            this.pnlFind.Controls.Add(this.txtFind);
            this.pnlFind.Controls.Add(this.btnSearchClose);
            this.pnlFind.Location = new System.Drawing.Point(0, 0);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(700, 34);
            this.pnlFind.TabIndex = 11;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindNext.AutoSize = true;
            this.btnFindNext.Image = ((System.Drawing.Image)(resources.GetObject("btnFindNext.Image")));
            this.btnFindNext.Location = new System.Drawing.Point(314, 6);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(44, 22);
            this.btnFindNext.TabIndex = 14;
            this.btnFindNext.UseVisualStyleBackColor = true;
            // 
            // btnFindPrev
            // 
            this.btnFindPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindPrev.AutoSize = true;
            this.btnFindPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnFindPrev.Image")));
            this.btnFindPrev.Location = new System.Drawing.Point(269, 6);
            this.btnFindPrev.Name = "btnFindPrev";
            this.btnFindPrev.Size = new System.Drawing.Size(44, 22);
            this.btnFindPrev.TabIndex = 13;
            this.btnFindPrev.UseVisualStyleBackColor = true;
            // 
            // btnMatchCase
            // 
            this.btnMatchCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMatchCase.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMatchCase.AutoSize = true;
            this.btnMatchCase.Image = ((System.Drawing.Image)(resources.GetObject("btnMatchCase.Image")));
            this.btnMatchCase.Location = new System.Drawing.Point(359, 6);
            this.btnMatchCase.Name = "btnMatchCase";
            this.btnMatchCase.Size = new System.Drawing.Size(22, 22);
            this.btnMatchCase.TabIndex = 12;
            this.btnMatchCase.UseVisualStyleBackColor = true;
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReplace.BackColor = System.Drawing.SystemColors.Window;
            this.txtReplace.Location = new System.Drawing.Point(62, 2);
            this.txtReplace.MaxLength = 1000;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(119, 20);
            this.txtReplace.TabIndex = 11;
            // 
            // lblReplaceToggle
            // 
            this.lblReplaceToggle.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblReplaceToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReplaceToggle.AutoSize = true;
            this.lblReplaceToggle.Location = new System.Drawing.Point(188, 11);
            this.lblReplaceToggle.Name = "lblReplaceToggle";
            this.lblReplaceToggle.Size = new System.Drawing.Size(76, 13);
            this.lblReplaceToggle.TabIndex = 10;
            this.lblReplaceToggle.TabStop = true;
            this.lblReplaceToggle.Text = "Open Replace";
            this.lblReplaceToggle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReplaceToggle_LinkClicked);
            // 
            // lblFindResult
            // 
            this.lblFindResult.AutoSize = true;
            this.lblFindResult.Location = new System.Drawing.Point(454, 11);
            this.lblFindResult.Name = "lblFindResult";
            this.lblFindResult.Size = new System.Drawing.Size(88, 13);
            this.lblFindResult.TabIndex = 9;
            this.lblFindResult.Text = "Replaced x times";
            // 
            // pbFind
            // 
            this.pbFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbFind.Image = ((System.Drawing.Image)(resources.GetObject("pbFind.Image")));
            this.pbFind.Location = new System.Drawing.Point(430, 7);
            this.pbFind.Name = "pbFind";
            this.pbFind.Size = new System.Drawing.Size(22, 22);
            this.pbFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFind.TabIndex = 8;
            this.pbFind.TabStop = false;
            // 
            // lblSearchTxt
            // 
            this.lblSearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchTxt.AutoSize = true;
            this.lblSearchTxt.Location = new System.Drawing.Point(30, 11);
            this.lblSearchTxt.Name = "lblSearchTxt";
            this.lblSearchTxt.Size = new System.Drawing.Size(30, 13);
            this.lblSearchTxt.TabIndex = 2;
            this.lblSearchTxt.Text = "Find:";
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFind.BackColor = System.Drawing.SystemColors.Window;
            this.txtFind.Location = new System.Drawing.Point(62, 8);
            this.txtFind.MaxLength = 1000;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(119, 20);
            this.txtFind.TabIndex = 1;
            // 
            // btnSearchClose
            // 
            this.btnSearchClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearchClose.AutoSize = true;
            this.btnSearchClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchClose.Image")));
            this.btnSearchClose.Location = new System.Drawing.Point(4, 7);
            this.btnSearchClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchClose.Name = "btnSearchClose";
            this.btnSearchClose.Size = new System.Drawing.Size(22, 22);
            this.btnSearchClose.TabIndex = 0;
            this.btnSearchClose.UseVisualStyleBackColor = true;
            this.btnSearchClose.Click += new System.EventHandler(this.btnSearchClose_Click);
            // 
            // pnlReplace
            // 
            this.pnlReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReplace.Controls.Add(this.btnReplaceAll);
            this.pnlReplace.Controls.Add(this.btnReplaceNext);
            this.pnlReplace.Controls.Add(this.btnUndoOne);
            this.pnlReplace.Controls.Add(this.btnUndoAll);
            this.pnlReplace.Controls.Add(this.lblReplaceTxt);
            this.pnlReplace.Controls.Add(this.txtReplace);
            this.pnlReplace.Location = new System.Drawing.Point(0, 30);
            this.pnlReplace.Name = "pnlReplace";
            this.pnlReplace.Size = new System.Drawing.Size(700, 28);
            this.pnlReplace.TabIndex = 12;
            this.pnlReplace.Visible = false;
            // 
            // lblReplaceTxt
            // 
            this.lblReplaceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReplaceTxt.AutoSize = true;
            this.lblReplaceTxt.Location = new System.Drawing.Point(10, 5);
            this.lblReplaceTxt.Name = "lblReplaceTxt";
            this.lblReplaceTxt.Size = new System.Drawing.Size(50, 13);
            this.lblReplaceTxt.TabIndex = 12;
            this.lblReplaceTxt.Text = "Replace:";
            // 
            // btnSelectionOnly
            // 
            this.btnSelectionOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectionOnly.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSelectionOnly.AutoSize = true;
            this.btnSelectionOnly.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectionOnly.Image")));
            this.btnSelectionOnly.Location = new System.Drawing.Point(381, 6);
            this.btnSelectionOnly.Name = "btnSelectionOnly";
            this.btnSelectionOnly.Size = new System.Drawing.Size(22, 22);
            this.btnSelectionOnly.TabIndex = 15;
            this.btnSelectionOnly.UseVisualStyleBackColor = true;
            // 
            // btnUndoOne
            // 
            this.btnUndoOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUndoOne.AutoSize = true;
            this.btnUndoOne.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoOne.Image")));
            this.btnUndoOne.Location = new System.Drawing.Point(269, 0);
            this.btnUndoOne.Name = "btnUndoOne";
            this.btnUndoOne.Size = new System.Drawing.Size(44, 22);
            this.btnUndoOne.TabIndex = 17;
            this.btnUndoOne.UseVisualStyleBackColor = true;
            // 
            // btnUndoAll
            // 
            this.btnUndoAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUndoAll.AutoSize = true;
            this.btnUndoAll.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoAll.Image")));
            this.btnUndoAll.Location = new System.Drawing.Point(224, 0);
            this.btnUndoAll.Name = "btnUndoAll";
            this.btnUndoAll.Size = new System.Drawing.Size(44, 22);
            this.btnUndoAll.TabIndex = 16;
            this.btnUndoAll.UseVisualStyleBackColor = true;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplaceAll.AutoSize = true;
            this.btnReplaceAll.Image = ((System.Drawing.Image)(resources.GetObject("btnReplaceAll.Image")));
            this.btnReplaceAll.Location = new System.Drawing.Point(359, 0);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(44, 22);
            this.btnReplaceAll.TabIndex = 19;
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btnReplaceNext
            // 
            this.btnReplaceNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplaceNext.AutoSize = true;
            this.btnReplaceNext.Image = ((System.Drawing.Image)(resources.GetObject("btnReplaceNext.Image")));
            this.btnReplaceNext.Location = new System.Drawing.Point(314, 0);
            this.btnReplaceNext.Name = "btnReplaceNext";
            this.btnReplaceNext.Size = new System.Drawing.Size(44, 22);
            this.btnReplaceNext.TabIndex = 18;
            this.btnReplaceNext.UseVisualStyleBackColor = true;
            // 
            // FindBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlReplace);
            this.Controls.Add(this.pnlFind);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FindBox";
            this.Size = new System.Drawing.Size(700, 58);
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFind)).EndInit();
            this.pnlReplace.ResumeLayout(false);
            this.pnlReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.LinkLabel lblReplaceToggle;
        private System.Windows.Forms.Label lblFindResult;
        private System.Windows.Forms.PictureBox pbFind;
        private System.Windows.Forms.Label lblSearchTxt;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnSearchClose;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnFindPrev;
        private System.Windows.Forms.CheckBox btnMatchCase;
        private System.Windows.Forms.Panel pnlReplace;
        private System.Windows.Forms.CheckBox btnSelectionOnly;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnReplaceNext;
        private System.Windows.Forms.Button btnUndoOne;
        private System.Windows.Forms.Button btnUndoAll;
        private System.Windows.Forms.Label lblReplaceTxt;
    }
}
