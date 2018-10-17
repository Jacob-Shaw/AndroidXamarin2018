using Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassMaterial.Week1
{
    public static class Week7Classwork
    {
        public static void RunWeek7Classwork()
        {

            MyLinqEample();

            MyAsyncExample();


            SimpleTaskExample();


            void MyLinqEample()
            {
                string[] names = { "Tom", "Don", "Harry", "Mary", "Jay" };
                string[] bnames = { "Tom", "Dick", "Sarah" };
                IEnumerable<string> query = names;
                IEnumerable<string> query2 = bnames

                    .Where(n => n.Contains("a"))
                    .OrderBy(n => n.Length)
                    .Select(n => n.ToUpper());

                foreach (string name in query) Console.WriteLine(name);
            }





            async void MyAsyncExample()
            {
                AsyncUtility myUtility = new AsyncUtility();
                string MyWord = await myUtility.BottlesOfBeerAsync();
                Console.WriteLine(MyWord);
            }





            void SimpleTaskExample()
            {
                Thread.CurrentThread.Name = "Main";

                //Create a task and a supply a user delegate by using a lambda expression
                Task task = new Task(() => Console.WriteLine("Hello from task!"));
                //Define a run with task
                //Task task = Task.Run(() => Console.WriteLine("Hello from task!"));       


                //Start the task
                task.Start();

                //Output a message from the calling task
                Console.WriteLine("Hello from thread {0}.", Thread.CurrentThread.Name);
                task.Wait();
            }
        }
    }
}
