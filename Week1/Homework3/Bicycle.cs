using System;
using System.Collections.Generic;

namespace ClassMaterial.Week1.Homework3
{
    /*  This is a modified Bicycle class used earlier. It is to have a constructor, 
    properties, generics and a property set to private. This Bicycle class has the 
    same name as another Bicycle class with the use of the namespace to differentiate
    between them. */

    public class Bicycle
    {
        //Fields
        private string _build = "UNKNOWN";
        private string _color = "UNKNOWN";        
        private string _brand = "UNKNOWN";
        
        private string _frameMaterial = "UNKNOWN";
        private int _frameSize = 0 ;

        /* default price is set high to avoid mistake of being sold for a loss */
        private decimal _price = 100000m;  
        
        private decimal _previousPrice = 0m;

        private string _location = "UNKNOWN";  //Backstock, Floor, Sold

        private string _previousLocation = "UNKNOWN";

        //This will keep track of the number of Bikes that have been created
        public static int BikesCreated = 0;
        //This will keep track of the number of Bikes in inventory
        public static int BikesInShop = 0;
         
   
        //Properties - provide access to fields
        public decimal Price 
        { 
            get
            {    return _price;     
            }             
            set
            { 
                this._price = value;
            }             
        }        
        public string Color 
        {
            get 
            {    return _color;
            }
            set 
            {
                this._color = value;
            }
        }

        public string Location 
        {
            get 
            {    return _location;
            }
            set 
            {
                this._location = value;
            }
        }
        public string Brand
        {
            get 
            {    return _brand;
            }
            set 
            {   
                this._brand = value;
            }
        }
        public string Build 
        {
            get 
            {
                return _build;
            }
            set 
            {   
                this._build = value;
            }
        }
        public string FrameMaterial 
        {
            get 
            {   return _frameMaterial;
            }
            set 
            {   
                this._frameMaterial = value;
            }
        }
        public int FrameSize 
        {
            get 
            {
                return _frameSize;
            }
            set 
            {
                
                this._frameSize = value;
            }
        }

        //Private Property Example
        private decimal PreviousPrice
        {
            get
            {
                return this._previousPrice;
            }
            set
            {
                this._previousPrice = value;
            }
            
        }

        //Methods

        //Generic method for switching items
        //Not exciting, but demonstrates the basics of 
        //developing a method without the need for knowing 
        //the types used

        public void Switch <T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        

        //Constructors for Bicycle
        public Bicycle()
        {}
              

        public Bicycle( string build, string brand, string color, string framematerial, int framesize, decimal price, string location )
        {
            Console.WriteLine("Bicycle added to Inventory");
            
            this._build = build;
            this._brand = brand;
            this._color = color;
            this._frameMaterial = framematerial;
            this._frameSize = framesize;
            this._price = price;
            this._location = location;
            
            BikesCreated++;
        }        

        public void Deconstruct()
        {
           System.Console.WriteLine("Bicycle deconstructed!" );
        }

        ~Bicycle()
        {
           System.Console.WriteLine("Bicycle destroyed.");
        }

    }
}