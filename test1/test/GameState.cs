using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace test
{
    class GameState
    {
        Car car;

        private bool run;

        public GameState()
        {
            car = new Car('$', ConsoleColor.Green);

            Console.SetWindowSize(70, 30);
            Console.SetBufferSize(70, 30);
            Console.CursorVisible = false;
        }


        public void StartGame()
        {
            run = true;
            car.LoadTheCar();

            while (run)
            {
                car.Draw();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        // Clear before moving because if serpent moves first, we cannot clear properly
                        car.Clear();
                        car.Move(Direction.Up);
                        break;
                    case ConsoleKey.DownArrow:
                        car.Clear();
                        car.Move(Direction.Down);
                        break;
                    case ConsoleKey.LeftArrow:
                        car.Clear();
                        car.Move(Direction.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        car.Clear();
                        car.Move(Direction.Right);
                        break;
                    case ConsoleKey.Escape:
                        run = false;
                        break;
                    default:
                        break;
                }

            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(35, 15);
            Console.Write("GAME OVER");
        }
    }
}