using static System.Console;

namespace MusicPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var noteSequence = new NoteSequence();

                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.EightWithPoint));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.EightWithPoint));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.EightWithPoint));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.Sixth));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.SixthWithPoint));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.Eight));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.Quarter));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.EightWithPoint));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.EightWithPoint));
                noteSequence.AddNote(new Note<FirstOctave>(FirstOctave.F, NoteDuration.EightWithPoint));

                var musicPlayer = new MusicPlayer(noteSequence);
                musicPlayer.Play();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
