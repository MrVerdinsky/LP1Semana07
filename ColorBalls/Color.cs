using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    public class Color
    {
        //Properties for Color
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public byte Alpha { get; set; }

        public int Grey { get; }



        public Color(byte r, byte g, byte b, byte a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
            Grey = (r + g + b) / 3;
        }

        public Color(byte r, byte g, byte b)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
            Grey = (r + g + b) / 3;
        }
    }
}
