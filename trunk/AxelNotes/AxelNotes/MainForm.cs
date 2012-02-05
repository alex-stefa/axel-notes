using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AxelNotes
{
    public partial class MainForm : Form
    {
        private NotesController notesController;
        public NotesController NotesController { get { return notesController; } }

        private FindBox findBox;
        private RenameBox renameBox;
        private FilterBox filterBox;
        public FindBox FindBox { get { return findBox; } }
        public FilterBox FilterBox { get { return filterBox; } }
        public RenameBox RenameBox { get { return renameBox; } }


        public MainForm(NotesController notesController)
        {
            this.notesController = notesController;

            InitializeComponent();
            AddInputPanels();

            highlightTextBox.Visible = true;
            htmlTextbox.Visible = false;

            findBox.Show();
        }

        private void AddInputPanels()
        {
            findBox = new FindBox(notesController);
            findBox.Visible = false;
            renameBox = new RenameBox();
            renameBox.Visible = false;
            filterBox = new FilterBox();
            filterBox.Visible = false;
            panelHolder.Controls.Add(findBox);
            panelHolder.Controls.Add(renameBox);
            panelHolder.Controls.Add(filterBox);
        }

        private void HideInputPanels()
        {
            findBox.Visible = false;
            renameBox.Visible = false;
            filterBox.Visible = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            notesList.Visible = !notesList.Visible;
            if (notesList.Visible)
                notesList.Focus();
            //else
            //    editor.Focus();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notesController.DoShutdown();
        }



    }
}
