using Advanced;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassMaterial.Week1
{
    public static class Week4Classwork
    {

        //Delegates Example in Advanced
        public delegate void TryOn(string Type);  //won't work in main

        public static void RunWeek4Classwork()
        {
            DelegateSample();           

            EventSample();

            LambdaSample();            

            void LambdaSample()
            {
                LambdaExamples myLamb = new LambdaExamples();
                //myLamb.MyLambdaOne(5);
                Console.WriteLine(myLamb.MyLambdaOne(5));


                LambdaExamples mySecond = new LambdaExamples(23);
                Console.WriteLine(mySecond.MyLambdaOne(mySecond.MyValue));
            }

            void DelegateSample()
            {
                Hats myHat = new Hats("Cowboy", 7);  //old stuff
                TryOn theHat = myHat.TryOnHat;
                theHat("I tried on a " + myHat.HatType + " hat was size " + myHat.HatSize);

                Hats mySecond = new Hats();
            }


            


            void EventSample()
            {
                Coats myCoat = new Coats();         //Instantiate the class
                string result = myCoat.MyResult;  //Get results from the property
                Console.WriteLine(result);
            }

        }
    }
}
