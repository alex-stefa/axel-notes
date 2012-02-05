using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AxelNotes
{
    interface NoteContent
    {
        long GetSizeInBytes();
        string AsText();
        HtmlDocument AsHtml();
        void SaveTo(String filename);
        void LoadFrom(String filename);
    }

    class TextContent : NoteContent
    {
        private string content;

        public long GetSizeInBytes()
        {
            if (content == null) return 0;
            return content.Length * 2 + 2;
        }

        public string AsText()
        {
            return content;
        }

        public HtmlDocument AsHtml()
        {
            throw new NotImplementedException();
        }

        public void SaveTo(string filename)
        {
            throw new NotImplementedException();
        }

        public void LoadFrom(string filename)
        {
            throw new NotImplementedException();
        }
    }

    class HtmlContent : NoteContent
    {
        private HtmlDocument content;

        public long GetSizeInBytes()
        {
            if (content == null) return 0;
            return -1;
        }

        public string AsText()
        {
            return "";
        }

        public HtmlDocument AsHtml()
        {
            return content;
        }

        public void SaveTo(string filename)
        {
            throw new NotImplementedException();
        }

        public void LoadFrom(string filename)
        {
            throw new NotImplementedException();
        }
    }

}
