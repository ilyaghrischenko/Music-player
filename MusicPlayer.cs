using MusicPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//TODO: create a note tones, reverse noteSequence

namespace MusicPlayer
{
    public class MusicPlayer(NoteSequence noteSequence)
    {
        private readonly NoteSequence _noteSequence = noteSequence;

        public void Play()
        {
            CheckOS();

            foreach (var item in _noteSequence._notes)
            {
                Beep(item._frequency, item._duration);
            }
        }
        private void CheckOS()
        {
            PlatformID platform = Environment.OSVersion.Platform;
            if (platform != PlatformID.Win32NT && platform != PlatformID.Win32Windows)
            {
                throw new Exception("PLay(): your OS does not support this action");
            }
        }
    }
}
