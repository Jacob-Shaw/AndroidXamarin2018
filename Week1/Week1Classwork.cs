using System;

namespace ClassMaterial.Week1
{
    public static class Week1Classwork
    {

        public static void RunWeek1Classwork()
        {
            Console.WriteLine("Hello World!");
            Vehicle vehicle = new Vehicle("Chevy");
            vehicle.Color = "Blue";

            Vehicle myVehicle = new Vehicle();
            myVehicle.Color = "Red";
            Console.WriteLine(myVehicle.Color);
            myVehicle.OpenDoor();

            Car myCar = new Car();
            myCar.Color = "Green";
            myCar.OpenDoor();
            myCar.CloseWindow();            
        }
    }
}