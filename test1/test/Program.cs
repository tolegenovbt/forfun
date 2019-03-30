using System;
using System.IO;
using System.Threading;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState gameState = new GameState();
            gameState.StartGame();
            //Car car;
            //car = new Car('0');
            //bool run = true;
            //Console.SetWindowSize(70, 30);
            //Console.SetBufferSize(70, 30);
            //Console.CursorVisible = false;
            //car.LoadTheCar();

            //while (run)
            //{
            //    car.Draw();
            //    ConsoleKeyInfo pressedKey = Console.ReadKey();
            //    switch (pressedKey.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            car.ChangeDirection(Direction.Up);
            //            break;
            //        case ConsoleKey.DownArrow:
            //            car.ChangeDirection(Direction.Down);
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            car.ChangeDirection(Direction.Left);
            //            break;
            //        case ConsoleKey.RightArrow:
            //            car.ChangeDirection(Direction.Right);
            //            break;
            //        case ConsoleKey.Escape:
            //            run = false;
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }
    }
}