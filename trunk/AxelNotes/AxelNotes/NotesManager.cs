using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;


namespace AxelNotes
{
    class NotesManager
    {
        public List<NoteGroup> Groups;
        public NoteGroup AllNotes, PinnedNotes, UnfiledNotes;

        public NotesManager()
        {
            this.Groups = new List<NoteGroup>();
            this.UnfiledNotes = new NoteGroup("Unfiled Notes");
            this.PinnedNotes = new NoteGroup("Pinned Notes");
            this.AllNotes = new NoteGroup("All Notes");
        }

        public void LoadNotesFrom(string path)
        {

        }
        
        private string[] GetFileList(string path)
        {
            if (path == null)
            {
                ErrorHandler.Error("Notes directory path is empty.");
                return null;
            }
            if (!path.EndsWith(@"\")) path += @"\";

            string[] files = null;

            try { files = Directory.GetFiles(@path); }
            catch (UnauthorizedAccessException ex) { ErrorHandler.Error("You do not have read access to notes directory: " + path, ex); }
            catch (DirectoryNotFoundException ex) { ErrorHandler.Error("Could not find notes directory: " + path, ex); }
            catch (ArgumentException ex) { ErrorHandler.Error("Invalid notes directory path: " + path, ex); }
            catch (PathTooLongException ex) { ErrorHandler.Error("Notes directory path is too long: " + path, ex); }
            catch (IOException ex) { ErrorHandler.Error("Invalid notes directory path (appears to be a filename or network error): " + path, ex); }
            catch (Exception ex) { ErrorHandler.Error("Could not load notes from '" + path + "'. The following error was encountered: ", ex); }

            return files;
        }

        private string[] GetDirList(string path)
        {
            if (path == null)
            {
                ErrorHandler.Error("Notes directory path is empty.");
                return null;
            }
            if (!path.EndsWith(@"\")) path += @"\";

            string[] dirs = null;

            try { dirs = Directory.GetDirectories(@path); }
            catch (UnauthorizedAccessException ex) { ErrorHandler.Error("You do not have read access to notes directory: " + path, ex); }
            catch (DirectoryNotFoundException ex) { ErrorHandler.Error("Could not find notes directory: " + path, ex); }
            catch (ArgumentException ex) { ErrorHandler.Error("Invalid notes directory path: " + path, ex); }
            catch (PathTooLongException ex) { ErrorHandler.Error("Notes directory path is too long: " + path, ex); }
            catch (IOException ex) { ErrorHandler.Error("Invalid notes directory path (appears to be a filename or network error): " + path, ex); }
            catch (Exception ex) { ErrorHandler.Error("Could not load notes from '" + path + "'. The following error was encountered: ", ex); }

            return dirs;
        }

    }


    class NoteGroup
    {
        public string Name;
        public List<Note> Notes;

        public NoteGroup(string name)
        {
            this.Name = name;
            this.Notes = new List<Note>();
        }
    }

    class Note
    {
        public enum NoteTypes { HTML, TEXT };

        public NoteTypes Type;
        public string Name;
        public NoteGroup Group;
        public bool IsDirty;
        public bool IsLocked;
        public bool IsPinned;
        public DateTime? Created;
        public DateTime? Modified;

        public Note(string name, NoteGroup group, NoteTypes type)
        {
            this.Type = type;
            this.Name = name;
            this.Group = group;
            this.IsDirty = false;
            this.IsLocked = false;
            this.IsPinned = false;
            this.Created = null;
            this.Modified = null;
        }

        public static string GetFileExtension(NoteTypes noteType)
        {
            if (noteType == NoteTypes.HTML) return "html";
            if (noteType == NoteTypes.TEXT) return "txt";
            return null;
        }

        public string GetFullName()
        {
            return Group.Name + "\\" + this.Name + "." + GetFileExtension(this.Type);
        }

    }



    class NoteCache
    {
        private long maxSize; // size in bytes
        public long MaxSizeKB
        {
            get { return maxSize >> 10; }
            set
            {   
                maxSize = Math.Max(0, value);
                maxSize = Math.Min(1 << 20, value); // max 1GB
                maxSize <<= 10;
                Purge();
            }
        }

        private long currentSize; // size in bytes
        public long CurrentSizeKB
        {
            get { return currentSize >> 10; }
        }

        private Dictionary<Note, LinkedListNode<ListPair>> contentsMap;
        private LinkedList<ListPair> contentsList;

        private class ListPair
        {
            public Note note;
            public NoteContent content;

            public ListPair(Note note, NoteContent content)
            {
                this.note = note;
                this.content = content;
            }
        }

        public NoteCache(long cacheSizeKB)
        {
            cacheSizeKB = Math.Max(0, cacheSizeKB);
            cacheSizeKB = Math.Min(1 << 20, cacheSizeKB); // max 1GB
            this.maxSize = cacheSizeKB << 10;
            contentsList = new LinkedList<ListPair>();
            contentsMap = new Dictionary<Note,LinkedListNode<ListPair>>(1000);
            currentSize = 0;
        }

        public void Put(Note note, NoteContent content)
        {
            if (note == null) return;
            if (content == null) return;

            if (contentsMap.ContainsKey(note)) // if note already in cache, perform update
            {
                LinkedListNode<ListPair> prev = null;
                if (contentsMap.TryGetValue(note, out prev)) // get previous contents value
                {
                    currentSize -= prev.Value.content.GetSizeInBytes();
                    contentsList.Remove(prev);
                }

            }

            contentsList.AddLast(new ListPair(note, content));
            currentSize += content.GetSizeInBytes();
            contentsMap[note] = contentsList.Last;

            Purge();
        }

        private void Purge()
        {
            if (contentsList.Count == 0) return;

            LinkedListNode<ListPair> iterator = contentsList.First;
            while (currentSize >= maxSize && iterator != null)
            {
                if (!iterator.Value.note.IsDirty)
                {
                    currentSize -= iterator.Value.content.GetSizeInBytes();
                    contentsMap.Remove(iterator.Value.note);
                    LinkedListNode<ListPair> evicted = iterator;
                    iterator = iterator.Next;
                    contentsList.Remove(evicted);
                }
                else
                    iterator = iterator.Next;
            }
        }

        public NoteContent Get(Note note)
        {
            if (note == null) return null;
            LinkedListNode<ListPair> result = null;
            contentsMap.TryGetValue(note, out result);
            if (result == null) return null;
            return result.Value.content;
        }
    }
}

