using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
            Thread Greenthread = new Thread(Green);
            Thread Redthread = new Thread(Red);
            Greenthread.Start();
            Redthread.Start();
            ConsoleKeyInfo pressedKey = Console.ReadKey(); 
            if(pressedKey.Key == ConsoleKey.Spacebar)
            {
                Greenthread.Suspend();
                Redthread.Suspend();
            }
        }
        static void Green()
        {
            for (int i = 0; i < 40; i+=2)
            {
                //int k = 0;
                Console.SetCursorPosition(i,4);
                Console.ForegroundColor = ConsoleColor.Green;
                //for(int j=0;j<39;j++)
                //{
                //    Console.Write('_');
                //}
                //Console.WriteLine("________________________________________");
                Console.Write('_');
                //k++;
                Thread.Sleep(500);
                
            }
        }
        static void Red()
        {
            for (int i = 1; i < 40; i+=2)
            {
                //int k = 0;
                Console.SetCursorPosition(i, 8);
                Console.ForegroundColor = ConsoleColor.Red;
                //for (int j = 0; j < 39; j++)
                //{
                //    Console.Write('_');
                //}
                //Console.WriteLine("________________________________________");
                Console.Write('_');
                //k++;
                Thread.Sleep(225);
            }
        }
    }
}
