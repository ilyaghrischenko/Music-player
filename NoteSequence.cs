using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class NoteSequence()
    {
        public List<Note> _notes { get; } = new List<Note>();
        public void AddNote(Note note)
        {
            _notes.Add(note);
        }
        public void RemoveNote(Note note)
        {
            _notes.Remove(note);
        }
        public void Clear()
        {
            _notes.Clear();
        }
    }
}
