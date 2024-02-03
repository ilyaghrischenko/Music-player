using static System.Console;

namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoteSequence noteSequence = new NoteSequence();
            noteSequence.AddNote(new Note(NoteFrequencies.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.A, NoteDuration.Eight));
            noteSequence.AddNote(new Note(NoteFrequencies.B, NoteDuration.Half));
            noteSequence.AddNote(new Note(NoteFrequencies.C, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.B, NoteDuration.Eight));
            noteSequence.AddNote(new Note(NoteFrequencies.A, NoteDuration.Quarter));

            MusicPlayer musicPlayer = new MusicPlayer(noteSequence);
            musicPlayer.Play();
        }
    }
}
