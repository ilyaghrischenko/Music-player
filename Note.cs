using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Note<T>(NoteFrequencies frequency, NoteDuration duration)
    {
        public int _frequency { get; set; } = (int)frequency;
        public int _duration { get; set; } = (int)duration;
    }
}
