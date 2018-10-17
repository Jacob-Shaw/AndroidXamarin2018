using Advanced;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassMaterial.Week1
{
    public static class Week6Classwork
    {
        public static void RunWeek6Classwork()
        {
            ThreadingReturnSample();

            ThreadingSample2();

            //The callback method must match the signature of the callback delegate
            void ResultCallback(int lineCount)
            {
                Console.WriteLine("Independent task printed {0} lines.", lineCount);
            }

            void ThreadingReturnSample()
            {
                ThreadWithState tws = new ThreadWithState("This report displays the number {0}.", 42,
                    new ExampleCallback(ResultCallback));
                Thread t = new Thread(new ThreadStart(tws.ThreadProc));
                t.Start();
                Console.WriteLine("Main thread does some work, then waits.");
                t.Join();
                Console.WriteLine("Independent task has completed; main thread ENDS.");
            }

            void ThreadingSample2()
            {
                //Calling constructo with value using Thread two ways
                ThreadingExample myExample = new ThreadingExample();
                Thread thread = new Thread(() => myExample.SimpleMethod(100));
                thread.Start();

                //or the older implementation
                //Thread secondThread = new Thread(myExample.DifferentMethod);
                //secondThread.Start("I see");
            }


        }

    }
}
