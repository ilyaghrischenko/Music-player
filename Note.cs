using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Note<T>(T frequency, NoteDuration duration) where T : Enum
    {
        public int _frequency { get; set; } = Convert.ToInt32(frequency);
        public int _duration { get; set; } = Convert.ToInt32(duration);
    }
}
