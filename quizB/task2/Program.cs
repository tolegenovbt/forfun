using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace task2
{
    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move()
        {
            if (x >= 25 && y < 25)
            {
                x++;
                y++;
            }
            else if (x > 25 && y >= 25)
            {
                x--;
                y++;
            }
            else if (x <= 25 && y > 25)
            {
                x--;
                y++;
            }
            else if (x <= 25 && y < 25)
            {
                x--;
                y++;
            }
        }
    }
    class Triangle
    {
        public List<Point> body;
        public Triangle()
        {
             
        }
        public void Load()
        {
            using (StreamReader streamReader = new StreamReader("../../triangle.txt"))
            {
                int row = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == 'O')
                        {
                            //Point pp = new Point(i,row);
                            //pp.x = i;

                            AddPoint(new Point(i,row));
                        }
                    }
                    row++;
                }
            }
        }
        public void AddPoint(Point point)
        {
            body.Add(point);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 30);
            Console.SetBufferSize(50, 30);
            Console.CursorVisible = false;
            Thread thread = new Thread(F);
            thread.Start();
        }
        static void F()
        {
            Triangle triangle = new Triangle();
            triangle.Load();
            for(;;)
            {
                Console.Clear();
                for (int i = 0; i < triangle.body.Count(); i++)
                {
                    Console.SetCursorPosition(triangle.body[i].x, triangle.body[i].y);
                    Console.Write('O');
                    triangle.body[i].Move();
                }
                Thread.Sleep(200);
            }
        }   
    }
}
