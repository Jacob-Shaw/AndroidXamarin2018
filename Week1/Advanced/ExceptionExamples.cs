using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ExceptionExamples
    {
        string exampleNull = null;


        //This is a method that may throw an exception
        public void MyException()
        {

            //This is what you will test that may throw exceptions
            try
            {
                Console.WriteLine(exampleNull);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Exception thrown " + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("exception thrown " + e.Message);
            }

            




        }


        public void MySecondExample()
        {
            try
            {
                exampleNull = "No longer null.";
                Console.WriteLine(exampleNull.ToUpper());
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null exception thrown " + ex.Message);
            }

            finally
            {
                Console.WriteLine("Finally block was called!");
            }
        }

        public void MyThirdExample()
        {
            string[] names = { "Matt", "Dave", "John" };

            try
            {
                byte b = byte.Parse(names[3]);
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please provide at least one arguement!");

            }

            catch (FormatException)
            {
                Console.WriteLine("That is nopt a number!");
            }

            catch (OverflowException)
            {
                Console.WriteLine("You've given me more than a byte!");
            }
        }
    }
}
