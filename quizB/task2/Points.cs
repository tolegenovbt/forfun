using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point point
        {
            get
            {
                return point;
            }
            set
            {
                if (point.x >= 25 && point.y<25)
                {
                    point.x++;
                    point.y++;
                }
                else if (point.x > 25 && point.y >= 25)
                {
                    point.x--;
                    point.y++;
                }
                else if (point.x <= 25 && point.y > 25)
                {
                    point.x--;
                    point.y++;
                }
                else if (point.x <= 25 && point.y < 25)
                {
                    point.x--;
                    point.y++;
                }
                else
                {
                    point.x = point.x;
                    point.y = point.y;
                }
            }
        }
        
    }
}
