using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class Hats
    {
        public string HatType { get; set; }

        public int HatSize { get; set; }

        public delegate void TryOn(string type);

        public Hats(string type, int size)
        {
            this.HatType = type;
            this.HatSize = size;
        }

        public Hats()
        {
            TryOn myHat = TryOnHat;
            TryALargerHat("fedora", 7, myHat);
        }

        //2nd part example
        public Hats(int size)
        {
            this.HatSize = size;
        }

        //Method for a delegate
        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        }

        public void TryALargerHat(string type, int oldSize, TryOn another)
        {
            another("I tried on a " + type + " hat at size " + (oldSize + 1).ToString());
        }

        //2nd part example
        public void FindLuckHat(string message)
        {
            Console.WriteLine("Luck hat is {0}", message);
        }

        //2nd part example
        public void FindUglyHat(string message)
        {
            Console.WriteLine("Ugly hat is {0}", message);
        }
    }
}
