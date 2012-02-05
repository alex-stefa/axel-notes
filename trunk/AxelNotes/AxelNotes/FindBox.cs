using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AxelNotes
{
    public partial class FindBox : UserControl
    {
        private NotesController notesController;
        public NotesController NotesController { get { return notesController; } }

        public FindBox(NotesController notesController)
        {
            InitializeComponent();
            this.notesController = notesController;
            this.ReplaceVisible = false;
        }

        private void lblReplaceToggle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ReplaceVisible = !this.ReplaceVisible;
        }

        private bool ReplaceVisible
        {
            get { return pnlReplace.Visible; }

            set
            {
                pnlReplace.Visible = value;
                if (value)
                {
                    lblReplaceToggle.Text = "Close Replace";
                    this.Height = 58;
                }
                else
                {
                    lblReplaceToggle.Text = "Open Replace";
                    this.Height = 34;
                }
            }
        }

        public bool MatchCase
        {
            get { return btnMatchCase.Checked; }
            set { btnMatchCase.Checked = value; }
        }

        public bool SelectionOnly
        {
            get { return btnSelectionOnly.Checked; }
            set { btnSelectionOnly.Checked = value; }
        }

        public string FindText
        {
            get { return txtFind.Text; }
            set { txtFind.Text = value; }
        }

        public string ReplaceText
        {
            get { return txtReplace.Text; }
            set { txtReplace.Text = value; }
        }

        private void btnSearchClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notesController.FindPanelClosed();
        }

        //public void ShowFind(string text, bool selectionOnly)



    }
}
