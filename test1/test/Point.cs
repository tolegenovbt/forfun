using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Point
    {
        int x;
        int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 69)
                {
                    x = 0;
                }
                else if (value < 0)
                {
                    x = 69;
                }
                else
                {
                    x = value;
                }
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 29)
                {
                    y = 0;
                }
                else if (value < 0)
                {
                    y = 29;
                }
                else
                {
                    y = value;
                }
            }
        }
    }
}