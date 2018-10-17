//This is a directory for all of my classwork and homework done in Visual Studio Code

using System;
using System.Timers;
using ClassMaterial.Week1;
using Advanced;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            //   ***MAINTENANCE***: 
            //        1.  Change "sbyte NumberofWeeks" below to the exact number 
            //          of weeks of work (example: 3 for 3 weeks). 
            //        2.  Add appropriate selections to the "switch(_choice)" below

            //  *****Update the initialization value to match number of class weeks*****
            //Array of number of weeks of classwork
            sbyte NumberofWeeks = 7;
            
            //This variable will check to see if a choice from 
            //  the menu has been made
            bool exitNow = false;


            


            //This will print the menu items
            while ( exitNow == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("     --------");
                System.Console.WriteLine("       MENU");
                System.Console.WriteLine("     --------");

                //Variables for printing
                sbyte _counter = 1;
                sbyte _selectionNumber = 1;

                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("0. Exit");




                //Print Menu selections by number
                while ( _selectionNumber < (NumberofWeeks * 2))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine(_selectionNumber++ + ". Week " + _counter + " Classwork");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine(_selectionNumber++ + ". Week " + _counter++ + " Homework");
                }

                //Reset the console to default colors
                Console.ResetColor();

                System.Console.WriteLine("Please select an item number from the menu");
                System.Console.WriteLine("or press \"R\" for a random selection");
                System.Console.WriteLine("and press \"Enter\":");
                
                Console.ForegroundColor = ConsoleColor.Blue;                

                string _choice = Console.ReadLine().ToUpper();

                Console.WriteLine();


                //Allow the user to make a random choice
                if( _choice == "R")
                {
                    Random _luck = new Random();

                    //(min value, max value) min value will be met, but not max value
                    //   for random numbers
                    int getRandom = _luck.Next(1,(NumberofWeeks*2+1));

                    _choice = getRandom.ToString();
                }
                
                Console.ResetColor();



                void exitToMenu()
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Press \"Enter\" to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }



                /* This switch will execute the user selection made.
                    *****Be sure to update!*****  */
                switch (_choice)
                {

                    case "0":
                        //Week1Classwork.RunWeek1Classwork();
                        exitNow = true;
                        break;

                    case "1":
                        Week1Classwork.RunWeek1Classwork();
                        exitToMenu();
                        break;

                    case "2":
                        Week1Homework.RunWeek1Homework();
                        exitToMenu();
                        break;

                    case "3":
                        Week2Classwork.RunWeek2Classwork();
                        exitToMenu();
                        break;

                    case "4":
                        Week2Homework.RunWeek2Homework();
                        exitToMenu();
                        break;

                    case "5":
                        Week3Classwork.RunWeek3Classwork();
                        exitToMenu();
                        break;

                    case "6":
                        Week3Homework.RunWeek3Homework();
                        exitToMenu();
                        break;

                    case "7":
                        Week4Classwork.RunWeek4Classwork();
                        exitToMenu();
                        break;

                    case "8":
                        Week4Homework.RunWeek4Homework();
                        exitToMenu();
                        break;

                    case "9":
                        Week5Classwork.RunWeek5Classwork();
                        exitToMenu();
                        break;

                    case "10":
                        Week5Homework.RunWeek5Homework();
                        exitToMenu();
                        break;

                    case "11":
                        Week6Classwork.RunWeek6Classwork();
                        exitToMenu();
                        break;

                    case "12":
                        Week6Homework.RunWeek6Homework();
                        exitToMenu();
                        break;

                    case "13":
                        Week7Classwork.RunWeek7Classwork();
                        exitToMenu();
                        break;

                    case "14":
                        Week7Homework.RunWeek7Homework();
                        exitToMenu();
                        break;

                    // *****Add new selections above this line*****

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red ;
                        Console.WriteLine("\"\a" + _choice + "\"" + " is an invalid selection.");
                        Console.ResetColor();
                        break;
                }                
            }

        }
    }
} 
