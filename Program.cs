using static System.Console;

namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noteSequence = new NoteSequence();

            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Quarter));

            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Eight));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.Eight));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Eight));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Eight));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Eight));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.B, NoteDuration.Eight));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.A, NoteDuration.Eight));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Quarter));

            // Припев

            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.Half));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Half));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Half));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Half));

            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Quarter));

            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Quarter));

            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Whole));

            // 2-й куплет

            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.G, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.E, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.D, NoteDuration.Quarter));
            noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.C, NoteDuration.Quarter));

            var musicPlayer = new MusicPlayer(noteSequence);
            musicPlayer.Play();
        }
    }
}
