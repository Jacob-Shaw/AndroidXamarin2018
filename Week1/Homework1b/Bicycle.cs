using System;

namespace Week1.Homework1b
{
    public class Bicycle
    {
        private string _seat;

        private int _sprocket = 20;


        public virtual int Sprocket
        {
            get {
                return _sprocket;
            }
        }

        public string Seat
        {
            set
            {
                this._seat = value;
            }

            get
            {
                return _seat;
            }
        }

        
    public Bicycle()
    {
       Console.WriteLine("Bicycle default");
    }
    public Bicycle(string type)
    {
       Console.WriteLine("String type");
    }


        public string Wheels{ set; get; } 

        public string HandleBars{ set; get; }
    }
}