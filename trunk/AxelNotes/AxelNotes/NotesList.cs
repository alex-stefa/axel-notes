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
    public partial class NotesList : UserControl
    {
        public NotesList()
        {
            InitializeComponent();


            
        }



        private void mainAbout_Click(object sender, EventArgs e)
        {
            (new AboutBox()).Show();
        }

        private void menuExpandAll_Click(object sender, EventArgs e)
        {
            treeNotes.ExpandAll();
        }

        private void menuCollapseAll_Click(object sender, EventArgs e)
        {
            treeNotes.CollapseAll();
        }

        private void mainSettings_Click(object sender, EventArgs e)
        {
            (new SettingsForm()).Show();
        }

        private void mainReload_Click(object sender, EventArgs e)
        {
            (new Floater("AxelNotes")).Show();
        }
    }


    class NoteItem : TreeNode
    {
        private static readonly Font normalFont = 
            new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        private static readonly Font dirtyFont = 
            new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

        public Note Note;        

        public NoteItem(Note note)
        {
            this.Note = note;
            this.Text = Note.Name;
        }





    }


    class GroupItem : TreeNode
    {


    }


    class NotesTree : TreeView
    {

    }




}
