using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace AxelNotes
{
    public partial class AboutBox : Form
    {
        public enum OpenModes { HELP = 0, INFO = 1 };

        public AboutBox()
        {
            InitializeComponent();
        }

        public OpenModes OpenMode
        {
            get { return (OpenModes)tabControl.SelectedIndex; }
            set { tabControl.SelectTab((int) value); }
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void focusTextBox()
        {
            if (tabControl.SelectedTab == tabHelp)
            {
                textHelp.Focus();
                textHelp.Select(0, 0);
                HideCaret(textHelp.Handle);
            }
            if (tabControl.SelectedTab == tabInfo)
            {
                textInfo.Focus();
                textInfo.Select(0, 0);
                HideCaret(textInfo.Handle);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            focusTextBox();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            focusTextBox();
        }

        private void linkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(linkSource.Text));
        }

        private void AboutBox_Activated(object sender, EventArgs e)
        {
            focusTextBox();
        }

        private void AboutBox_Shown(object sender, EventArgs e)
        {
            focusTextBox();
        }
    }
}
