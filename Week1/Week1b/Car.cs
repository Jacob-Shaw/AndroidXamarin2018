using System;

//Extends
public class Car : Vehicle 
{
    public override void CloseWindow() 
    {
        Console.WriteLine("My Car window is closed!");
    }
}