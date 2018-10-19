using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Week1.Week1.Week_6;


namespace ClassMaterial.Week1
{
    class Week6Homework
    {
        public static void RunWeek6Homework()
        {
            Console.Clear();
            SolarSystem();            

            void SolarSystem()
            {
                ArrayList listSolarSystem = new ArrayList();
                listSolarSystem.Add("Sun");
                listSolarSystem.Add("Mercury");
                listSolarSystem.Add("Venus");
                listSolarSystem.Add("Earth");
                listSolarSystem.Add("Mars");
                listSolarSystem.Add("Ceres");
                listSolarSystem.Add("Asteroid Belt");
                listSolarSystem.Add("Jupiter");
                listSolarSystem.Add("Saturn");
                listSolarSystem.Add("Uranus");
                listSolarSystem.Add("Neptune");
                listSolarSystem.Add("Pluto");
                listSolarSystem.Add("Haumea");
                listSolarSystem.Add("Makemake");
                listSolarSystem.Add("Kuiper Belt");
                listSolarSystem.Add("Scattered Disk");
                listSolarSystem.Add("Sedna");
                listSolarSystem.Add("Eris");
                listSolarSystem.Add("Planet X");
                listSolarSystem.Add("Oort Cloud");


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("There are " + listSolarSystem.Count + " well known destinations in our Solar System.");
                Console.ForegroundColor = ConsoleColor.Red;
                int counter = 1;

                foreach (Object destination in listSolarSystem)
                {
                    Console.WriteLine(counter + ". " + destination);
                    counter++;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Would you like to add one?");
                Console.WriteLine("(Y)es  or  (N)o ?");

                string userResponse = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (userResponse == "Y")
                {
                    MyTryCatchFinal.CheckArrayList(listSolarSystem);
                }
                else if (userResponse == "N")
                {
                    Console.WriteLine("Have a nice day!");
                    Console.WriteLine("We will now return you to the Main Menu.");
                }
                else
                {
                    Console.WriteLine("I'll take that as a no, have a nice day!");
                    Console.WriteLine("We will now return you to the Main Menu.");
                }
            }
        }
    }
}

