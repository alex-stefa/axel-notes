namespace AxelNotes
{
    partial class FilterBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterBox));
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.pbFilter = new System.Windows.Forms.PictureBox();
            this.lblFilterCount = new System.Windows.Forms.Label();
            this.btnFilterNext = new System.Windows.Forms.Button();
            this.btnFilterPrev = new System.Windows.Forms.Button();
            this.lblFilterTxt = new System.Windows.Forms.Label();
            this.btnTitleOnly = new System.Windows.Forms.CheckBox();
            this.btnMatchCase = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilterClose = new System.Windows.Forms.Button();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.pbFilter);
            this.pnlFilter.Controls.Add(this.lblFilterCount);
            this.pnlFilter.Controls.Add(this.btnFilterNext);
            this.pnlFilter.Controls.Add(this.btnFilterPrev);
            this.pnlFilter.Controls.Add(this.lblFilterTxt);
            this.pnlFilter.Controls.Add(this.btnTitleOnly);
            this.pnlFilter.Controls.Add(this.btnMatchCase);
            this.pnlFilter.Controls.Add(this.txtFilter);
            this.pnlFilter.Controls.Add(this.btnFilterClose);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(700, 34);
            this.pnlFilter.TabIndex = 4;
            // 
            // pbFilter
            // 
            this.pbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbFilter.Image = ((System.Drawing.Image)(resources.GetObject("pbFilter.Image")));
            this.pbFilter.Location = new System.Drawing.Point(336, 7);
            this.pbFilter.Name = "pbFilter";
            this.pbFilter.Size = new System.Drawing.Size(22, 22);
            this.pbFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFilter.TabIndex = 7;
            this.pbFilter.TabStop = false;
            // 
            // lblFilterCount
            // 
            this.lblFilterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilterCount.AutoSize = true;
            this.lblFilterCount.Location = new System.Drawing.Point(360, 11);
            this.lblFilterCount.Name = "lblFilterCount";
            this.lblFilterCount.Size = new System.Drawing.Size(82, 13);
            this.lblFilterCount.TabIndex = 6;
            this.lblFilterCount.Text = "String not found";
            // 
            // btnFilterNext
            // 
            this.btnFilterNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilterNext.AutoSize = true;
            this.btnFilterNext.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterNext.Image")));
            this.btnFilterNext.Location = new System.Drawing.Point(233, 7);
            this.btnFilterNext.Name = "btnFilterNext";
            this.btnFilterNext.Size = new System.Drawing.Size(44, 22);
            this.btnFilterNext.TabIndex = 5;
            this.btnFilterNext.UseVisualStyleBackColor = true;
            // 
            // btnFilterPrev
            // 
            this.btnFilterPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilterPrev.AutoSize = true;
            this.btnFilterPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterPrev.Image")));
            this.btnFilterPrev.Location = new System.Drawing.Point(188, 7);
            this.btnFilterPrev.Name = "btnFilterPrev";
            this.btnFilterPrev.Size = new System.Drawing.Size(44, 22);
            this.btnFilterPrev.TabIndex = 4;
            this.btnFilterPrev.UseVisualStyleBackColor = true;
            // 
            // lblFilterTxt
            // 
            this.lblFilterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilterTxt.AutoSize = true;
            this.lblFilterTxt.Location = new System.Drawing.Point(30, 11);
            this.lblFilterTxt.Name = "lblFilterTxt";
            this.lblFilterTxt.Size = new System.Drawing.Size(32, 13);
            this.lblFilterTxt.TabIndex = 2;
            this.lblFilterTxt.Text = "Filter:";
            // 
            // btnTitleOnly
            // 
            this.btnTitleOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTitleOnly.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTitleOnly.AutoSize = true;
            this.btnTitleOnly.Image = ((System.Drawing.Image)(resources.GetObject("btnTitleOnly.Image")));
            this.btnTitleOnly.Location = new System.Drawing.Point(306, 7);
            this.btnTitleOnly.Name = "btnTitleOnly";
            this.btnTitleOnly.Size = new System.Drawing.Size(22, 22);
            this.btnTitleOnly.TabIndex = 3;
            this.btnTitleOnly.UseVisualStyleBackColor = true;
            // 
            // btnMatchCase
            // 
            this.btnMatchCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMatchCase.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMatchCase.AutoSize = true;
            this.btnMatchCase.Image = ((System.Drawing.Image)(resources.GetObject("btnMatchCase.Image")));
            this.btnMatchCase.Location = new System.Drawing.Point(283, 7);
            this.btnMatchCase.Name = "btnMatchCase";
            this.btnMatchCase.Size = new System.Drawing.Size(22, 22);
            this.btnMatchCase.TabIndex = 2;
            this.btnMatchCase.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilter.Location = new System.Drawing.Point(64, 8);
            this.txtFilter.MaxLength = 1000;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(117, 20);
            this.txtFilter.TabIndex = 1;
            // 
            // btnFilterClose
            // 
            this.btnFilterClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilterClose.AutoSize = true;
            this.btnFilterClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilterClose.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterClose.Image")));
            this.btnFilterClose.Location = new System.Drawing.Point(4, 7);
            this.btnFilterClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilterClose.Name = "btnFilterClose";
            this.btnFilterClose.Size = new System.Drawing.Size(22, 22);
            this.btnFilterClose.TabIndex = 0;
            this.btnFilterClose.UseVisualStyleBackColor = true;
            // 
            // FilterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFilter);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FilterBox";
            this.Size = new System.Drawing.Size(700, 34);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.PictureBox pbFilter;
        private System.Windows.Forms.Label lblFilterCount;
        private System.Windows.Forms.Button btnFilterNext;
        private System.Windows.Forms.Button btnFilterPrev;
        private System.Windows.Forms.Label lblFilterTxt;
        private System.Windows.Forms.CheckBox btnTitleOnly;
        private System.Windows.Forms.CheckBox btnMatchCase;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilterClose;
    }
}
