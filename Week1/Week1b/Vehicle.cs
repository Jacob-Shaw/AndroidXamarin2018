using System;

public class Vehicle
{
    //Reference type Field
    private string _color;

    //Normal Property
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
     //Automatic Property
     /*This is a shortcut way of declaring a variable with
     private by default methods */
    public string WheelType { get; set; }



    //Default Constructor has no void in front
    public Vehicle()
    {
        Console.WriteLine("Default Constructor");
    }


    public Vehicle(string type)
    {
        Console.WriteLine(type);
    }


    public void OpenDoor() //Method with no parameters
    {
        Console.WriteLine("Door is open!");
    }

    //Example of plymorphism
    public virtual void CloseWindow()
    {
        Console.WriteLine("Vehicle Window closed");
    }
    
}