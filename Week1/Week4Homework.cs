using Decorator;
using System;
using System.Collections.Generic;
using System.Text;
using PriceObserver;

namespace ClassMaterial.Week1
{
    public static class Week4Homework
    {
        public static void RunWeek4Homework()
        {
            PriceWatch myPriceWatch = new PriceWatch();
            PriceMonitor monitor = new PriceMonitor(myPriceWatch);
            PriceChangeNotifier auto = new PriceChangeNotifier(myPriceWatch);

            Console.Clear();
            Console.WriteLine("This program uses the decorator program to calculate price and the");
            Console.WriteLine("observer pattern to watch the price of a boat.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("What is my budget to buy a boat?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("$");

            bool haveBudget = false;

            do
            {
                string userInput = Console.ReadLine();
                decimal userNumber;

                bool parsed = Decimal.TryParse(userInput, out userNumber);

                if (!parsed)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    haveBudget = true;
                    myPriceWatch.CurrentBudget = userNumber;
                }

            } while (haveBudget == false);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("What is the base price of the Boat?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("$");
            
            bool haveBoatBasePrice = false;

            do
            {
                string userInput = Console.ReadLine();
                decimal userBoatPrice;

                bool parsed = Decimal.TryParse(userInput, out userBoatPrice);

                if (!parsed)
                    Console.WriteLine("Please enter a number.");

                else
                {
                    haveBoatBasePrice = true;
                    myPriceWatch.CurrentPrice = userBoatPrice;
                }

            } while (haveBoatBasePrice == false);
            
            IOrder myOrder =  new Electronics(new Rigging(new Boat(new BoatOrder(), myPriceWatch.CurrentPrice)));
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The total price of the boat with: ");
            Console.WriteLine(myOrder.GetOrder);
            Console.WriteLine( "is $" + myOrder.Price + ".");
            Console.ForegroundColor = ConsoleColor.White;
            
            myPriceWatch.CurrentPrice = myOrder.Price;

            Console.WriteLine();
            Console.WriteLine("Let's try considering another boat.");
            Console.WriteLine();
            Console.WriteLine("What is the base price of the new Boat?");
            Console.Write("$");

            haveBoatBasePrice = false;

            do
            {
                string userInput = Console.ReadLine();
                decimal userNumber;

                bool parsed = Decimal.TryParse(userInput, out userNumber);

                if (!parsed)
                    Console.WriteLine("Please enter a number.");

                else
                {
                    haveBoatBasePrice = true;
                    myPriceWatch.CurrentPrice = userNumber;
                }

            } while (haveBoatBasePrice == false);

            IOrder myOrder2 = new Electronics(new Rigging(new Boat(new BoatOrder(), myPriceWatch.CurrentPrice)));
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The total price of the boat with: ");
            Console.WriteLine(myOrder2.GetOrder);
            Console.WriteLine("is $" + myOrder2.Price + ".");
            
            myPriceWatch.CurrentPrice = myOrder2.Price;
        }
    }
}
