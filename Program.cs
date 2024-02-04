using static System.Console;

namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noteC = new Note<NoteFrequencies>(NoteFrequencies.C, NoteDuration.Quarter);
            var noteE = new Note<NoteFrequencies>(NoteFrequencies.E, NoteDuration.Quarter);
            var noteG = new Note<NoteFrequencies>(NoteFrequencies.G, NoteDuration.Quarter);
            var noteA = new Note<NoteFrequencies>(NoteFrequencies.A, NoteDuration.Quarter);
            var noteB = new Note<NoteFrequencies>(NoteFrequencies.B, NoteDuration.Quarter);

            var noteSequence = new NoteSequence();
            noteSequence.AddNote(noteG);
            noteSequence.AddNote(noteA);
            noteSequence.AddNote(noteB);
            noteSequence.AddNote(noteA);
            noteSequence.AddNote(noteG);
            noteSequence.AddNote(noteG);
            noteSequence.AddNote(noteA);
            noteSequence.AddNote(noteB);
            noteSequence.AddNote(noteC);
            noteSequence.AddNote(noteC);
            noteSequence.AddNote(noteB);
            noteSequence.AddNote(noteA);

            var musicPlayer = new MusicPlayer(noteSequence);

            // Play the song
            musicPlayer.Play();
        }
    }
}
