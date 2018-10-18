using System;
using System.Collections.Generic;
using System.Text;
using Delegates;
using CustomerInfoClass;

namespace ClassMaterial.Week1
{
    class Week5Homework
    {

        public static void RunWeek5Homework()
        {
            MyDelegateExample();

            void MyDelegateExample()
            {
                Console.Clear();
                Console.WriteLine("This program uses set of class files to demonstrate the use of a delegate.");
                Console.WriteLine();
                Console.WriteLine();

                ///This creates the delegates
                passMethod NewName, NewCustomerAddress, ClearAll;


                //Create Customer object
                CustomerInfo newCustomerInfo = new CustomerInfo();


                //Assign the delegates
                NewName = newCustomerInfo.CustomerName;
                NewCustomerAddress = newCustomerInfo.CustomerAddress;

                //Storing delegates in the ClearAll delegate. This is like a list of commands executed left to right.
                ClearAll = NewName + NewCustomerAddress;

                //Application
                Console.WriteLine("What is your name?");
                NewName(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("What is your address?");
                NewCustomerAddress(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Information Saved.");
                Console.WriteLine();
                Console.WriteLine("Name: " + newCustomerInfo.Name);
                Console.WriteLine("Address: " + newCustomerInfo.Address);
                Console.WriteLine();
                Console.WriteLine("Clearing Customer Profile.");
                Console.WriteLine();

                //Use a delegate to clear fields using other delegates
                ClearAll("");

                //Show that the ClearAll dlegate worked
                Console.WriteLine("Name: " + newCustomerInfo.Name);
                Console.WriteLine("Address: " + newCustomerInfo.Address);
                
            }
        }
    }
}
