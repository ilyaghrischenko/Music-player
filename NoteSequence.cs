using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class NoteSequence()
    {
        public List<dynamic> _notes { get; } = new List<dynamic>();
        public void AddNote(dynamic note)
        {
            _notes.Add(note);
        }
        public void RemoveNote(dynamic note)
        {
            _notes.Remove(note);
        }
        public void Clear()
        {
            _notes.Clear();
        }
    }
}
