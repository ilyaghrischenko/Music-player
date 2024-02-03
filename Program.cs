using static System.Console;

namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoteSequence noteSequence = new NoteSequence();
            noteSequence.AddNote(new Note(NoteFrequencies.C, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.E, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.A, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note(NoteFrequencies.F, NoteDuration.Half));

            MusicPlayer musicPlayer = new MusicPlayer(noteSequence);
            musicPlayer.Play();
        }
    }
}
