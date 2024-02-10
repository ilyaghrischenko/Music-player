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

    public enum CounterOctave
    {
        C = 32,
        D = 37,
        E = 41,
        F = 44,
        G = 49,
        A = 55,
        B = 62
    }
    public enum BigOctave
    {
        C = 65,
        D = 74,
        E = 82,
        F = 87,
        G = 98,
        A = 110,
        B = 123
    }
    public enum SmallOctave
    {
        C = 131,
        D = 148,
        E = 165,
        F = 175,
        G = 196,
        A = 220,
        B = 247
    }
    public enum FirstOctave
    {
        C = 262,
        D = 294,
        E = 330,
        F = 349,
        G = 392,
        A = 440,
        B = 494
    }
    public enum SecondOctave
    {
        C = 523,
        D = 587,
        E = 659,
        F = 698,
        G = 784,
        A = 880,
        B = 988
    }
    public enum ThirdOctave
    {
        C = 1046,
        D = 1174,
        E = 1318,
        F = 1396,
        G = 1568,
        A = 1720,
        B = 1975
    }
    public enum FourthOctave
    {
        C = 2093,
        D = 2349,
        E = 2637,
        F = 2793,
        G = 3136,
        A = 3440,
        B = 3951
    }
    public enum FiveOctave
    {
        C = 4186,
        D = 4698,
        E = 5274
    }
}
