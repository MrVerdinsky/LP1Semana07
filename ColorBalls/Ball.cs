using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    public  class Ball
    {
        public int NThrown { get; set; }

        public Color Color { get; set; }

        private int r;


        public Ball(Color c, int r)
        {
            this.r = r;
            Color = c;

            NThrown = 0;
        }
        public void Pop()
        {
            r = 0;
        }

        public void Throw()
        {
            if (r != 0)
            {
                NThrown++;
            }
        }

    }
}
