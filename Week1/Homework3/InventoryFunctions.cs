using System;


namespace InventoryFunctions
{/*                 This is under construction. :)
    public class InventoryFunctions
    {
        // static namelist
        private string Choice = "";

        private string Build = "";
        private string Brand = "";
        private string Color = "";
        private string FrameMaterial = "";
        private string FrameSize = "";
        private string Price = ""; 
        private string Location = "";

        private bool ExitToSelectionScreen = false;

        public void RunMainMenu()
        {
            SelectionScreen();
        }




        public static void SelectionScreen()
        {

            string choice;
            Console.WriteLine("                                         BIKE SHOP INVENTORY MANAGER");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("(A) Add Inventory (C) Change Price  (D) Display Inventory (L) Location Change (R) Remove Inventory (X) Exit");
            Console.WriteLine("Selection:");
            choice = Console.ReadLine().ToUpper();

            if( choice == "X") 
                System.Environment.Exit(0);

            Console.Clear();
            MainMenuSelection(choice);
        }

               
        private static void MainMenuSelection(string choice)
        {
            switch(choice)
            {
                case "A":
                AddInventory();
                break;

                case "C":
                ChangePrice();
                break;

                case "D":
                DisplayInventory();
                break;

                case "L":
                LocationChange();
                break;

                case "R":
                RemoveInventory();
                break;

                default:
                SelectionScreen(); 
                break;
            } 
        }


        
        static void AddInventory()
        {
            System.Console.Clear();
            System.Console.WriteLine("                              Add Inventory:");
            System.Console.WriteLine("");
            System.Console.WriteLine("Select:");
            System.Console.WriteLine("(M) Men's     (W) Women's      (B) Boy's      (G) Girl's    (X) Exit to Main Menu" );
            
            Choice = Console.ReadLine().ToUpper();

            if( Choice == "X") 
                SelectionScreen();
            else
            {
                switch(Choice)
                {

                    case "M":
                        Build = "Men's";
                    break;

                    case "W":
                        Build = "Women's";
                    break;

                    case "B":
                        Build = "Boy's";
                    break;

                    case "G":
                        Build = "Girl's";
                    break;

                    default:
                        AddInventory();
                    break;

                }
            }
        }
            
            System.Console.Clear();
            System.Console.WriteLine("                              Add Inventory:");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please type the Brand of the Bike or press (X) to Exit:");
            Choice = Console.ReadLine().ToUpper();

            if( Choice == "X") 
                SelectionScreen();
            else
            {
                Brand = Choice;
            }

            System.Console.Clear();
            System.Console.WriteLine("                              Add Inventory:");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please type the Color of the Bike or press (X) to Exit:");
            Choice = Console.ReadLine().ToUpper();

            if( Choice == "X") 
                SelectionScreen();
            else
            {
                Color = Choice;
            }

            System.Console.Clear();
            System.Console.WriteLine("                              Add Inventory:");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please type the Frame Material of the Bike or press (X) to Exit:");
            Choice = Console.ReadLine().ToUpper();

            if( Choice == "X") 
                SelectionScreen();
            else
            {
                FrameMaterial = Choice;
            }

            System.Console.Clear();
            System.Console.WriteLine("                              Add Inventory:");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please type the Frame Size of the Bike or press (X) to Exit:");
            Choice = Console.ReadLine().ToUpper();

            if( Choice == "X") 
            SelectionScreen();
            else
            {
                FrameSize = Choice;
            }

            System.Console.Clear();
            System.Console.WriteLine("                              Add Inventory:");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please type the Price of the Bike or press (X) to Exit:");
            Choice = Console.ReadLine().ToUpper();

            if( Choice == "X") 
            SelectionScreen();
            else
            {
                FrameSize = Choice;
            }


            bool locationChosen = false;

            while( locationChosen == false)
            {
                System.Console.Clear();
                System.Console.WriteLine("                              Add Inventory:");
                System.Console.WriteLine("");
                System.Console.WriteLine("And lastly, please Select the location of the Bike or press (X) to Exit:");
                System.Console.WriteLine("(B) BackStock   (F) Floor   (S) Sold");
                Choice = Console.ReadLine().ToUpper();

                if( Choice == "X") 
                SelectionScreen();
                else
                {
                    switch(Choice)
                    {

                        case "B":
                            Location = "BACKSTOCK";
                            locationChosen = true;
                        break;

                        case "F":
                            Location = "FLOOR";
                            locationChosen = true;
                        break;

                        case "S":
                            Location = "SOLD";
                            locationChosen = true;
                        break;

                        default:
                            
                        break;
                    }

                }

            }



                

            






        }
        */
        /* 
                  private string _color = "black";        
            private string _brand = "Generic";
            private string _build = "Men's";
            private string _frameMaterial = "Steel";
            private int _frameSize = 14;
            private int _currentPrice

        */
        /*
        static void ChangePrice()
        {

            //add last price field
            //change the price of 

        }

        static void DisplayInventory()
        {
            //need an array to store all bikes--Ilist!
            //print all bikes to screen
        }

        static void LocationChange()
        {
                
            //backstock, floor, sold
        }


        static void RemoveInventory()
        {

        }

        static void Swap <T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

     */   
}
