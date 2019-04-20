using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
            Thread Greenthread = new Thread(F);
            Greenthread.Start();
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.Spacebar)
            {
                Greenthread.Suspend();
            }
        }
        static void F()
        {
            for (;;)
            {
                Console.Clear();
                ConsoleColor[] consoleColors = new ConsoleColor[3];
                consoleColors[0] = ConsoleColor.Cyan;
                consoleColors[1] = ConsoleColor.Red;
                consoleColors[2] = ConsoleColor.DarkYellow;
                Random random = new Random();
                int x = random.Next(0, 40);
                int y = random.Next(0, 40);
                int ch = random.Next(65, 68);
                int cc = random.Next(0, 3);
                Console.ForegroundColor = consoleColors[cc];
                Console.SetCursorPosition(x, y);
                Console.Write((char)ch);
                Thread.Sleep(2000);
            }
        }
    }
}
