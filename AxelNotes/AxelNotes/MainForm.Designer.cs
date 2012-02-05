namespace AxelNotes
{
    partial class MainForm
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.pnlIn = new System.Windows.Forms.Panel();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.highlightTextBox = new AxelNotes.HighlightTextBox();
            this.htmlTextbox = new AxelNotes.HtmlTextbox();
            this.notesList = new AxelNotes.NotesList();
            this.pnlOut.SuspendLayout();
            this.pnlIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = global::AxelNotes.Properties.Resources.icon_small;
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.Control;
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(0, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(6, 280);
            this.btnHide.TabIndex = 1;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // pnlOut
            // 
            this.pnlOut.Controls.Add(this.pnlIn);
            this.pnlOut.Controls.Add(this.btnHide);
            this.pnlOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOut.Location = new System.Drawing.Point(181, 0);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(669, 280);
            this.pnlOut.TabIndex = 2;
            // 
            // pnlIn
            // 
            this.pnlIn.Controls.Add(this.highlightTextBox);
            this.pnlIn.Controls.Add(this.htmlTextbox);
            this.pnlIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIn.Location = new System.Drawing.Point(6, 0);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Size = new System.Drawing.Size(663, 280);
            this.pnlIn.TabIndex = 2;
            // 
            // panelHolder
            // 
            this.panelHolder.AutoSize = true;
            this.panelHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHolder.Location = new System.Drawing.Point(0, 280);
            this.panelHolder.Margin = new System.Windows.Forms.Padding(0);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(850, 0);
            this.panelHolder.TabIndex = 3;
            // 
            // highlightTextBox
            // 
            this.highlightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highlightTextBox.Location = new System.Drawing.Point(0, 0);
            this.highlightTextBox.Name = "highlightTextBox";
            this.highlightTextBox.Size = new System.Drawing.Size(663, 280);
            this.highlightTextBox.TabIndex = 1;
            this.highlightTextBox.Visible = false;
            // 
            // htmlTextbox
            // 
            this.htmlTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTextbox.Location = new System.Drawing.Point(0, 0);
            this.htmlTextbox.Name = "htmlTextbox";
            this.htmlTextbox.Size = new System.Drawing.Size(663, 280);
            this.htmlTextbox.TabIndex = 0;
            // 
            // notesList
            // 
            this.notesList.AllowDrop = true;
            this.notesList.Dock = System.Windows.Forms.DockStyle.Left;
            this.notesList.Location = new System.Drawing.Point(0, 0);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(181, 280);
            this.notesList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(850, 280);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.notesList);
            this.Controls.Add(this.panelHolder);
            this.Icon = global::AxelNotes.Properties.Resources.icon_small;
            this.MinimumSize = new System.Drawing.Size(203, 38);
            this.Name = "MainForm";
            this.Text = "AxelNotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlOut.ResumeLayout(false);
            this.pnlIn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Panel pnlIn;
        private HtmlTextbox htmlTextbox;
        private NotesList notesList;
        private HighlightTextBox highlightTextBox;
        private System.Windows.Forms.Panel panelHolder;
    }
}

