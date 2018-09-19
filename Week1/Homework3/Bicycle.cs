using System;

namespace ClassMaterial.Week1.Homework3
{

    /*  This is a modified Bicycle class used earlier. It is to have a constructor, 
    properties, generics and a property set to private. This Bicycle class has the 
    same name as another Bicycle class with the use of the namespace to differentiate
    between them. */

    /*  NEED TO TRY TO INCLUDE:

    
    
    TIMER
    CHECKED
    STRING INTERPOLATION PG 41 $ {X}
    ARRAY OF HOUSES-PAPERTYPE
    
    OUT MODIFIER
    PARAMS FOR NUMBER OF HOUSES OR PAPERS
    
    NAMED ARGUMENTS X:2, Y:1
    VAR
    ?? DEFAUL
    ?.
    
    NAME HIDING
    READONLY INSIDE OF CONSTRUCTOR
    DECLARE MULTIPLE FIELDS TOGETHER P80
    OVERLOADING METHODS
    LAMBDA
    internal / protected
    nonpublic constructor
    
    object initializers
    tuples 10

    
        !!!!!!GENERICS!!!!!!!!!!!!!!!!


    */

    public class Bicycle
    {
        //Fields
        private string _color = "black";        
        private string _brand = "Generic";
        private string _build = "Men's";
        private string _frameMaterial = "Steel";
        private int _frameSize = 14;

        //Has an understood private field HasBell
        public bool HasBell { get; set; }

        public int Pedal { get; set; }

        public string Name { get; set;} = "Bob";
        
        //This will keep track of the number of Bikes that have been created
        public static int BikesCreated = 0;



        //Steering - Left = -1, Forward = 0, Right = 1
        private int _steer = 0;        




        //Properties - provide access to fields
        public string Color 
        {
            get 
            {
                return _color;
            }
            set 
            {
                Console.WriteLine(value);
                this._color = value;
            }
        }

        public string Brand
        {
            get 
            {
                return _brand;
            }
            set 
            {
                Console.WriteLine(value);
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
                Console.WriteLine(value);
                this._build = value;
            }
        }

        public string FrameMaterial 
        {
            get 
            {
                return _frameMaterial;
            }
            set 
            {
                Console.WriteLine(value);
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
                Console.WriteLine(value);
                this._frameSize = value;
            }
        }
        public virtual void RingBell()
        {
            Console.WriteLine("Ring!");
        }

        public virtual void PedalBike()
        {

        }

        public virtual void Steer()
        {

        }

        //Constructors for Bicycle
        public Bicycle()
        {
            Console.WriteLine("Bicycle created with default constructor.");

            //Using the increment operator to increase the 
            // number of bikes created
            BikesCreated++;

        } 

         //This constructor for Bicycle accepts a string to use 
         // as the name of the bicycle
        public Bicycle( string name )
        {
            Console.WriteLine("Bicycle created with single string constructor.");

            //Using "this." allows the Name field of this particular
            // creation of a bicycle object to be referenced.
            this.Name = name;
            BikesCreated++;
        } 

        // This constructor takes three parameters and  
        public Bicycle( string name, string brand = "Generic")
        {
            Console.WriteLine("Bicycle created with double string constructor.");


            //this.Name = name;
            BikesCreated++;
        }

        //public Bicycle()

         void Swap <T> (ref T a, ref T b)
                {
                    T temp = a;
                    a = b;
                    b = temp;
                }




        public void Deconstruct()
        {
           System.Console.WriteLine("Bicycle " + this.Name + "destroyed!" );
        }

        //Destructor or Finalizer
        ~Bicycle()
        {
            System.Console.WriteLine("Goodbye bicycle " + this.Name + ".");
        }


    }
}