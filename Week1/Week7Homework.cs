using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Effects;

namespace ClassMaterial.Week1
{
    class Week7Homework
    {
       public static void RunWeek7Homework()
       {
            Console.Clear();
            
            bool BlinkOn = true;

            Blink("                            Please press any key!   ");

            
            async void Blink(string message)
            {
                while (BlinkOn == true)
                {
                    Console.Write(message);
                    
                    await Task.Delay(400);
                    Console.ForegroundColor = Console.ForegroundColor == ConsoleColor.Red ? ConsoleColor.Black : ConsoleColor.Red;
                }
            }

            // While the above keeps executing, the console will await a key to be pressed below.
            Thread.Sleep(500);

            // A seperate thread to run.
            StartNewThread startNewThread = new StartNewThread();

            startNewThread.PlayNewThread();

            Console.ReadKey();

            BlinkOn = false;

            Thread.Sleep(500);
        }
    }
}

