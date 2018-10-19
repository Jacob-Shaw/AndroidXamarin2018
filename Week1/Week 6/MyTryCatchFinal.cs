using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Week1.Week1.Week_6
{
    public class MyTryCatchFinal
    {
        public static void CheckArrayList(ArrayList check)
        {
            try
            {
                Console.WriteLine("What is the name of the new Destination?");
                string newDestination = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Add the new destination after which number?");
                Console.WriteLine("Be careful to list a number, and not too high!");
                string addDestination = Console.ReadLine();
                int destinationNumber = Convert.ToInt32(addDestination);
                Console.WriteLine();
                check.Insert(destinationNumber, newDestination);
                Console.WriteLine();

                int counter = 1;

                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Object destination in check)
                {
                    Console.WriteLine(counter + ". " + destination);
                    counter++;
                }

                Console.ForegroundColor = ConsoleColor.Blue;

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Oops! Sorry, our system is having problems with your response!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number ({0}) is out of range.",
                    check.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("exception thrown " + e.Message);
            }
            // The "finall" block of code will always execute.
            finally
            {
                Console.WriteLine("We will now return you to the Main Menu.");
            }
        }
    }
}
