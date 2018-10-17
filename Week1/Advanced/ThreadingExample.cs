using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Advanced
{
    public class ThreadingExample
    {
        public void SimpleMethod(int valueTotal)
        {
            for (int i = 0; i < valueTotal; i++)
            {
                Console.WriteLine("Hello Threading");
            }
        }

        public void DifferrentMethod(object data)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Threading again {0}", data);
            }
        }
    }
}
