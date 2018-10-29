using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Effects
{
    public class StartNewThread
    {
        public void PlayNewThread()
        {

            for (int i = 0; i < 10; i++)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hello Seperate Thread!");
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(100);

            }
            
        }
    }
}
