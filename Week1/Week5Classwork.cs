using Advanced;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassMaterial.Week1
{
    public static class Week5Classwork
    {

        //Delegates Example in Advanced
        public delegate void TryOn(string Type);  //won't work in main

        public static void RunWeek5Classwork()
        {


            CollectionSample();
            MultiDelegateSample();
            ThreadingSample();
            ExceptionSample();



            void CollectionSample()
            {
                CollectionExamples mySample = new CollectionExamples();

                //mySample.MyArrayListExample();

                mySample.MyListExample();
            }

            void MultiDelegateSample()
            {
                Hats moreHats = new Hats(7);
                TryOn someHats, niceHat, sadHat;

                niceHat = moreHats.FindLuckHat;
                niceHat("Top");

                sadHat = moreHats.FindUglyHat;
                sadHat("Dunce");

                someHats = niceHat + sadHat;
                someHats("Cowboy");
            }



            void ThreadingSample()
            {
                Thread thread = new Thread(CollectionSample);

                thread.Start();

                MultiDelegateSample();

            }

            void ExceptionSample()
            {
                    ExceptionExamples examples = new ExceptionExamples();
                    examples.MyException();

                    examples.MyThirdExample();


            }
        }
    }
}
