using System;
using ClassMaterial.Week1.Homework3;

namespace ClassMaterial.Week1
{
    public static class Week3Homework
    
    {
        public static void RunWeek3Homework()
        {
            System.Console.Clear();            

            Homework3.Bicycle MakingBike = new Homework3.Bicycle("Men's", "Schwinn", "Silver", "Alloy", 26, 500.00m, "Floor");

            System.Console.WriteLine("This bike was just created: ");
            System.Console.WriteLine("Build: " + MakingBike.Build);
            System.Console.WriteLine("Brand: " + MakingBike.Brand);
            System.Console.WriteLine("Color: " + MakingBike.Color);
            System.Console.WriteLine("Frame Material: " + MakingBike.FrameMaterial);
            System.Console.WriteLine("Frame Size: " + MakingBike.FrameSize);
            System.Console.WriteLine("Price: " +  (string.Format("{0:$#.00}", MakingBike.Price )) );
            System.Console.WriteLine("Location: " + MakingBike.Location);

            System.Console.WriteLine("Let's change the information for that bike.");

            System.Console.WriteLine("Enter a build for the bike, for example Men's or Women's:");

            MakingBike.Build = Console.ReadLine();

            System.Console.WriteLine("Enter a brand name for the bike:");

            MakingBike.Brand = Console.ReadLine();

            System.Console.WriteLine("Enter a color for the bike:");

            MakingBike.Color = Console.ReadLine();

            System.Console.WriteLine("Enter a frame material for the bike:");

            MakingBike.FrameMaterial = Console.ReadLine();

            System.Console.WriteLine("Enter a frame size for the bike:");

                 
            bool haveNumber = false;

            do
            {                
                string userInput = Console.ReadLine();
                int userNumber;

                bool parsed = Int32.TryParse( userInput, out userNumber );

                if (!parsed)
                Console.WriteLine("Please enter a number.");

                else
                {
                    haveNumber = true;
                    MakingBike.FrameSize = userNumber;
                }

            } while (haveNumber == false);

            System.Console.WriteLine("Enter a price for the bike:");

            haveNumber = false;

            do
            {
                
                string userInput = Console.ReadLine();
                decimal userNumber;

                bool parsed = Decimal.TryParse( userInput, out userNumber );

                if (!parsed)
                Console.WriteLine("Please enter a number.");

                else
                {
                    haveNumber = true;
                    MakingBike.Price = userNumber;
                }

            } while (haveNumber == false);

            System.Console.WriteLine("Enter a location for the bike, for example Backstock or Floor:");

            MakingBike.Location = Console.ReadLine();

            System.Console.WriteLine("You created a bike with the following information:");
            System.Console.WriteLine("Build: " + MakingBike.Build);
            System.Console.WriteLine("Brand: " + MakingBike.Brand);
            System.Console.WriteLine("Color: " + MakingBike.Color);
            System.Console.WriteLine("Frame Material: " + MakingBike.FrameMaterial);
            System.Console.WriteLine("Frame Size: " + MakingBike.FrameSize);
            System.Console.WriteLine("Price: " +  (string.Format("{0:$#.00}", MakingBike.Price )) );
            System.Console.WriteLine("Location: " + MakingBike.Location);

            System.Console.WriteLine("Now I am going to make a bicycle with the default constructor.");

            Homework3.Bicycle DefaultBike = new Homework3.Bicycle();

            System.Console.WriteLine("Default bike created with the following information:");
            System.Console.WriteLine("Build: " + DefaultBike.Build);
            System.Console.WriteLine("Brand: " + DefaultBike.Brand);
            System.Console.WriteLine("Color: " + DefaultBike.Color);
            System.Console.WriteLine("Frame Material: " + DefaultBike.FrameMaterial);
            System.Console.WriteLine("Frame Size: " + DefaultBike.FrameSize);
            System.Console.WriteLine("Price: " + (string.Format("{0:$#.00}", DefaultBike.Price )));
            System.Console.WriteLine("Location: " + DefaultBike.Location);

            System.Console.WriteLine("Now I am going to switch the prices of the bikes.");

            decimal x = MakingBike.Price;
            decimal y = DefaultBike.Price;

            MakingBike.Switch( ref x,  ref y);

            MakingBike.Price = x;
            DefaultBike.Price = y;

            System.Console.WriteLine("Your bike's price: " +  (string.Format("{0:$#.00}", MakingBike.Price )) );
            System.Console.WriteLine("Default bike's price: " +  (string.Format("{0:$#.00}", DefaultBike.Price )) );

            System.Console.WriteLine("Now I will switch the Brand of the bikes.");

            string aBrand = MakingBike.Brand;
            string bBrand = DefaultBike.Brand;

            MakingBike.Switch( ref aBrand,  ref bBrand);

            MakingBike.Brand = aBrand;
            DefaultBike.Brand = bBrand;

            System.Console.WriteLine("Your bike's brand: " + MakingBike.Brand);
            System.Console.WriteLine("Default bikes's brand: " + DefaultBike.Brand);
           
        }        
    }
}