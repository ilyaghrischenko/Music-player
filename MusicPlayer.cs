using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MusicPlayer
{
    public class MusicPlayer
    {
        private int frequency;
        private int duration;

        public MusicPlayer()
        {
            frequency = 1000;
            duration = 1000;
        }
        /// <summary>
        /// 1 value - frequency in hertz, 2 - duration in seconds
        /// </summary>
        public MusicPlayer(int frequency, int duration)
        {
            this.frequency = frequency;
            this.duration = duration * 1000;
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
            if (!int.TryParse(ReadLine(), out int dur))
            {
                throw new Exception("Input(): Invalid value for duration");
            }
            Duration = dur * 1000;
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
