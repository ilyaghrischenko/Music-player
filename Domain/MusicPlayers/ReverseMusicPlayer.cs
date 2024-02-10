using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MusicPlayer
{
    public class ReverseMusicPlayer(NoteSequence noteSequence) : IMusicPlayer
    {
        private readonly NoteSequence _noteSequence = noteSequence;

        public void Play()
        {
            CheckOS();

            var reverseList = noteSequence._notes;
            reverseList.Reverse();
            foreach (var item in reverseList)
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
