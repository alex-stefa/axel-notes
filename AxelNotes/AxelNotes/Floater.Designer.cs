namespace AxelNotes
{
    partial class Floater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Floater));
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbFloater = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbHandle = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFloater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHandle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMessage.Location = new System.Drawing.Point(34, 5);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(63, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Floater Text";
            // 
            // pbFloater
            // 
            this.pbFloater.BackColor = System.Drawing.Color.Transparent;
            this.pbFloater.Image = ((System.Drawing.Image)(resources.GetObject("pbFloater.Image")));
            this.pbFloater.Location = new System.Drawing.Point(2, 2);
            this.pbFloater.Name = "pbFloater";
            this.pbFloater.Size = new System.Drawing.Size(20, 20);
            this.pbFloater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFloater.TabIndex = 1;
            this.pbFloater.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(441, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.toolTip.SetToolTip(this.btnClose, "Close floater");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbHandle
            // 
            this.pbHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHandle.BackColor = System.Drawing.Color.Transparent;
            this.pbHandle.Image = ((System.Drawing.Image)(resources.GetObject("pbHandle.Image")));
            this.pbHandle.Location = new System.Drawing.Point(466, 4);
            this.pbHandle.Name = "pbHandle";
            this.pbHandle.Size = new System.Drawing.Size(15, 15);
            this.pbHandle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHandle.TabIndex = 3;
            this.pbHandle.TabStop = false;
            this.toolTip.SetToolTip(this.pbHandle, "Move floater");
            this.pbHandle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbHandle_MouseDown);
            this.pbHandle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbHandle_MouseMove);
            this.pbHandle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbHandle_MouseUp);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // Floater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 24);
            this.ControlBox = false;
            this.Controls.Add(this.pbHandle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbFloater);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 24);
            this.Name = "Floater";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Floater";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Floater_FormClosed);
            this.Shown += new System.EventHandler(this.Floater_Shown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Floater_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbFloater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHandle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbFloater;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbHandle;
        private System.Windows.Forms.ToolTip toolTip;
    }
}