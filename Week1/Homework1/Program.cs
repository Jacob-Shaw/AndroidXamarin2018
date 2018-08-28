using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            int MyNumber = 2;

            int AddOne(int x)
            {
                x += 1;
                return x;
            }

            int AddTwo(ref int x)
            {
                x += 2;
                return x; 
            }

            Console.WriteLine("Listen to my bikes make noise!");

            Bicycle MyBike = new Bicycle();

            MyBike.RingBell();

            Harley MyHarley = new Harley();

            MyHarley.RingBell();

            //Demonstrates inheritance of brand from Bicycle class
            Console.WriteLine("Let me check the headlight on my " + MyHarley.Brand + ".");

            if (MyHarley.HeadLightOn == true)
            {
                Console.WriteLine("The headlight is on.");
            }
            else
            {
                Console.WriteLine("The headlight is off.");  
            }

            Console.WriteLine("Let me change that.");

            MyHarley.HeadLightOn = (!MyHarley.HeadLightOn);

            Console.WriteLine("Time for some Math:");

            Console.WriteLine("We will start with my number of bikes which is " + MyNumber + ".");

            //This will send the value of MyNumber to the AddOne Method
            Console.WriteLine("One more than the number of my bikes is " + AddOne(MyNumber) + ".");

            //This demonstrates that MyNumber is not changed because it was passed by value to AddOne
            Console.WriteLine("The number of bikes I own is still " + MyNumber + ".");

            Console.WriteLine("Now I am going to buy 2 more bikes.");

            //The reference of MyNumber will be used in the AddTwo Method
            Console.WriteLine("Now I own " + AddTwo(ref MyNumber) + " bikes.");

            //This proves that MyNumber has changed because it was sent by reference to AddTwo
            Console.WriteLine("The number of bikes I own is " + MyNumber + ".");

        }
    }
}
