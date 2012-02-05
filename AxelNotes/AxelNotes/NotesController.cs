using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AxelNotes
{

    public class NotesController : ApplicationContext
    {
        private MainForm mainForm;
        private AboutBox aboutBox;
        private SettingsForm settingsForm;


        public NotesController()
        {
            this.mainForm = new MainForm(this);
            this.mainForm.Show();
        }

        public void DoShutdown()
        {
            Properties.Settings.Default.Save();
            mainForm.Dispose();
            Application.Exit();
        }

        public void ShowAboutBox(AboutBox.OpenModes openMode = AboutBox.OpenModes.INFO)
        {
            if (aboutBox == null) aboutBox = new AboutBox();
            aboutBox.OpenMode = openMode;
            if (aboutBox.Visible)
                aboutBox.Focus();
            else
                aboutBox.Show(mainForm);
        }

        public void ShowSettings()
        {
            if (settingsForm == null) settingsForm = new SettingsForm();
            // apply current settings
            if (settingsForm.Visible)
                settingsForm.Focus();
            else
                settingsForm.Show(mainForm);
        }



        public void FindPanelClosed()
        {

        }

        public void RenamePanelClosed()
        {

        }

        public void FilterPanelClosed()
        {


        }












    }

    public class ErrorHandler
    {
        private static string GetExceptionString(Exception exception)
        {
            if (exception == null) return "";
            return "\n\nException:\n" + exception.Message + "\n\nStack trace:\n" + exception.StackTrace;
        }

        public static void Error(string message, Exception exception = null)
        {
            new Thread(new ThreadStart(delegate
            {
                MessageBox.Show(message + GetExceptionString(exception), "Error - AxelNotes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            })).Start();
        }

        public static void Warn(string message, Exception exception = null)
        {
            new Thread(new ThreadStart(delegate
            {
                MessageBox.Show(message + GetExceptionString(exception), "Warning - AxelNotes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })).Start();
        }

        public static void Info(string message, Exception exception = null)
        {
            new Thread(new ThreadStart(delegate
            {
                MessageBox.Show(message + GetExceptionString(exception), "Info - AxelNotes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            })).Start();
        }
    }
}
