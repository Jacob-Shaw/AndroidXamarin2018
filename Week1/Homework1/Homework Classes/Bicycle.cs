using System;
// Using System will allow for access to the Console


/*This is a class which is basically the blueprints for an object.
    Every */
public class Bicycle
{
    //Fields - which are private member variables

    private string _color = "black";
    //private - not accessible outside of the class
    //string - a data type composed of characters in quotes 
    //   (use underscore and camelCase)
    //"color" - is the name I created for the field
    //the equals sign sets a variable to a following value
    //by setting the color to "black" all new objects of this class
    //   will be initialized to the color black
    //all statements in C# end with a semicolon

    //Brand or maker of bike
    private string _brand = "Generic";

    //Men, Women, unisex
    private string _build = "Men's";

    //Alloy, Steel, carbon fiber, etc.
    private string _frameMaterial = "Steel";

    //Size of the bike
    private int _frameSize = 14;
    //int is a whole number from -2,147,483,648 to 2,147,483,647

    //This demonstrates an auto-implemented property
    public bool HasBell { get; set; }

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

    //Constructor - initializes an object of the class type
    public Bicycle()
    {
        Console.WriteLine("O.K.");
    } 
}