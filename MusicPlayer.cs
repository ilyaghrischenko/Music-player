using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//TODO: create a note tones, reverse noteSequence
public enum NoteFrequencies
{
    C = 131,
    D = 148,
    E = 165,
    F = 175,
    G = 196,
    A = 220,
    B = 247
}
public enum NoteDuration
{
    WholeWithPoint = 6000,
    Whole = 4000,
    HalfWithPoint = 3000,
    Half = 2000,
    QuarterWithPoint = 1500,
    Quarter = 1000,
    EightWithPoint = 750,
    Eight = 500,
    SixthWithPoint = 375,
    Sixth = 250,
}

public class Note(NoteFrequencies frequency, NoteDuration duration)
{
    public int _frequency { get; set; } = (int)frequency;
    public int _duration { get; set; } = (int)duration;
}

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
    public class MusicPlayer(NoteSequence noteSequence)
    {
        private readonly NoteSequence _noteSequence = noteSequence;

        public void Play()
        {
            if (!checkOS()) throw new Exception("PLay(): your OS does not support this action");

            foreach(var item in _noteSequence._notes)
            {
                Beep(item._frequency, item._duration);
            }
        }
        private bool checkOS()
        {
            PlatformID platform = Environment.OSVersion.Platform;
            return platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows;
        }
    }
}
