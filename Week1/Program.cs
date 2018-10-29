//This is a directory for all of my classwork and homework done in Visual Studio Code

using System;
using System.Timers;
using ClassMaterial.Week1;
using Advanced;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

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
            sbyte NumberofWeeks = 8;
            
            //This variable will check to see if a choice from 
            //  the menu has been made
            bool exitNow = false;


            bool MainTitle = true;

            String TitleBar = "";
            string message = "Please make a selection.";

            void ChangeTitle()
            {
                if (MainTitle == true)
                {
                    TitleDisplay();

                    async void TitleDisplay()
                    {
                        while (MainTitle == true)
                        {
                            Console.Title = "";

                            for (int i = 0; i < message.Length; i++)
                            {
                                if (MainTitle == true)
                                {
                                    TitleBar += message[i];
                                    Console.Title = TitleBar;
                                    await Task.Delay(200);
                                }
                            }

                            for (int i = 0; i < 5; i++)
                            {
                                if (MainTitle == true)
                                Thread.Sleep(300);
                            }
                            
                            TitleBar = "";

                        }

                    }
                }
            }

            



            //This will print the menu items
            while ( exitNow == false)
            {
                ChangeTitle();
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

                



                Console.Title = _choice + ".";

                /* This switch will execute the user selection made.
                    *****Be sure to update!*****  */
                switch (_choice)
                {

                    case "0":
                        exitNow = true;
                        break;

                    case "1":
                        MainTitle = false;
                        Week1Classwork.RunWeek1Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();

                        MainTitle = true;
                        
                        break;

                    case "2":
                        MainTitle = false;
                        Week1Homework.RunWeek1Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        
                        break;

                    case "3":
                        MainTitle = false;
                        Week2Classwork.RunWeek2Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        
                        break;

                    case "4":
                        MainTitle = false;
                        Week2Homework.RunWeek2Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                       
                        break;

                    case "5":
                        MainTitle = false;
                        Week3Classwork.RunWeek3Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                       
                        break;

                    case "6":
                        MainTitle = false;
                        Week3Homework.RunWeek3Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "7":
                        MainTitle = false;
                        Week4Classwork.RunWeek4Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "8":
                        MainTitle = false;
                        Week4Homework.RunWeek4Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "9":
                        MainTitle = false;
                        Week5Classwork.RunWeek5Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "10":
                        MainTitle = false;
                        Week5Homework.RunWeek5Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "11":
                        MainTitle = false;
                        Week6Classwork.RunWeek6Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "12":
                        MainTitle = false;
                        Week6Homework.RunWeek6Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "13":
                        MainTitle = false;
                        Week7Classwork.RunWeek7Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "14":
                        MainTitle = false;
                        Week7Homework.RunWeek7Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "15":
                        MainTitle = false;
                        Week8Classwork.RunWeek8Classwork();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    case "16":
                        MainTitle = false;
                        Week8Homework.RunWeek8Homework();
                        Thread.Sleep(1000);
                        exitToMenu();
                        MainTitle = true;
                        break;

                    // *****Add new selections above this line*****

                    default:
                        MainTitle = false;
                        Thread.Sleep(1000);
                        MainTitle = true;
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
