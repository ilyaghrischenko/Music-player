using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public enum NoteDuration
    {
        WholeWithPoint = 6000,
        Whole = 4000,
        HalfWithPoint = 3000,
        Half = 2000,
        QuarterWithPoint = 1500,
        Quarter = 1000,
        EightWithPoint = 750,
        Eight = 500,
        SixthWithPoint = 375,
        Sixth = 250,
    }

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
}
