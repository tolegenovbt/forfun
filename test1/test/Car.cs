using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test
{
    enum Direction
    {
        Up, Down, Right, Left
    }

    class Car : GameObject
    {
        //private Direction movementDirection;
        public Car(char character, ConsoleColor consoleColor) : base(character, consoleColor)
        {

        }
        //public void ChangeDirection(Direction newDirection)
        //{
        //    movementDirection = newDirection;
        //}
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    for (int i = body.Count - 1; i > 0; i--)
                    {
                        body[i].Y = body[i].Y - 1;
                    }
                    break;
                case Direction.Down:
                    for (int i = body.Count - 1; i > 0; i--)
                    {
                        body[i].Y = body[i].Y + 1;
                    }
                    break;
                case Direction.Right:
                    for (int i = body.Count - 1; i > 0; i--)
                    {
                        body[i].X = body[i].X + 1;
                    }
                    break;
                case Direction.Left:
                    for (int i = body.Count - 1; i > 0; i--)
                    {
                        body[i].X = body[i].X - 1;
                    }
                    break;
                default:
                    break;
            }
        }
        //public List<Point> body;
        //public char character;
        //public Direction movementDirection;

        //public Car(char c)
        //{
        //    character = c;
        //}
        //private void AddPoint(Point point)
        //{
        //    body.Add(point);
        //}
        //public void Draw()
        //{
        //    foreach (var point in body)
        //    {
        //        Console.SetCursorPosition(point.X, point.Y);
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.Write(character);
        //    }
        //}
        //public void ChangeDirection(Direction newdirection)
        //{
        //    movementDirection = newdirection;
        //}

        //public void Move()
        //{
        //switch(movementDirection)
        //{
        //    case Direction.Up:
        //        for (int i = body.Count - 1; i > 0; i--)
        //        {
        //            body[i].Y = body[i].Y-1;
        //        }
        //        break;
        //    case Direction.Down:
        //        for (int i = body.Count - 1; i > 0; i--)
        //        {
        //            body[i].Y = body[i].Y+1;
        //        }
        //        break;
        //    case Direction.Right:
        //        for (int i = body.Count - 1; i > 0; i--)
        //        {
        //            body[i].X = body[i].X+1;
        //        }
        //        break;
        //    case Direction.Left:
        //        for (int i = body.Count - 1; i > 0; i--)
        //        {
        //            body[i].X = body[i].X-1;
        //        }
        //        break;
        //    default:
        //        break;
        //}
        //}
        public void LoadTheCar()
        {
            using (StreamReader streamReader = new StreamReader("../../TheCar.txt"))
            {
                int row = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '0')
                        {
                            AddPoint(new Point() { X = i, Y = row });
                        }
                    }
                    row++;
                }
            }
        }
    }
}
