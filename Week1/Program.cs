using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle vehicle = new Vehicle("Chevy");
            vehicle.Color = "Blue";

            Vehicle myVehicle = new Vehicle();
            myVehicle.Color = "Red";
            //Console.WriteLine(myVehicle.Color);
            myVehicle.OpenDoor();

            Car myCar = new Car();
            myCar.Color = "Green";

        }
    }


} 
