using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

public enum NoteFrequencies
{
    C = 131,
    D = 148,
    E = 165,
    F = 175,
    G = 196,
    A = 220,
    B = 247
}

namespace MusicPlayer
{
    public class MusicPlayer
    {
        private int[] frequencies;
        private int[] duration;

        public MusicPlayer()
        {
            frequency = 1000;
            duration = 1000;
        }
        /// <summary>
        /// 1 value - frequency in hertz, 2 - duration in seconds
        /// </summary>
        public MusicPlayer(int frequency, float duration)
        {
            this.frequency = frequency;
            this.duration = (int)(duration * 1000);
        }

        public int Frequency
        {
            get { return frequency; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid frequency argument!");
                }
                frequency = value;
            }
        }
        public int Duration
        {
            get { return duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid duration argument!");
                }
                duration = value;
            }
        }

        public void Show()
        {
            WriteLine($"Frequency: {frequency} | Duration: {duration}\n");
        }
        public void Input()
        {
            Write("Frequency(in hertz): ");
            if (!int.TryParse(ReadLine(), out int fr))
            {
                throw new Exception("Input(): Invalid value for frequency");
            }
            Frequency = fr;

            Write("Duration(in seconds): ");
            if (!float.TryParse(ReadLine(), out float dur))
            {
                throw new Exception("Input(): Invalid value for duration");
            }
            Duration = (int)(dur * 1000);
        }

        public override string ToString()
        {
            return $"{Frequency} {Duration}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (MusicPlayer)obj;
            return this.ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// Plays sound at the frequency and duration that is saved in your class
        /// </summary>
        public void PlaySound()
        {
            OperatingSystem os = Environment.OSVersion;
            if (os.Platform != PlatformID.Win32NT && os.Platform != PlatformID.Win32Windows)
            {
                throw new Exception("PlaySound(): Your operating system does not support this action");
            }
            Beep(Frequency, Duration);
        }
    }
}
