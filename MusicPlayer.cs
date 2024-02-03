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
