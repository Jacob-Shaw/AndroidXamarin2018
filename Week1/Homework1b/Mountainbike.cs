using System;

namespace Week1.Homework1b
{

    public class Mountainbike : Bicycle
    {
        private int _sprocket = 30;

        public override int Sprocket 
        {
            get {
                return _sprocket;
            }
        }

        public Mountainbike()
        {
                Console.WriteLine("Mountain Bike");
        }
        
    }
}