using System;

namespace Fundamentals
{
    public class Dinosaur

    {
        private string _teeth;
        private string _something;
        private int _size;
        public string Color { protected set; get; } = "Green";


        public int Size 
        { 
            set
            {
                this._size = value;
            } 
            
            get
            {
                if (_size > 200)
                {
                    System.Console.WriteLine("Your huge");
                }

                return _size;        
            }
        }

        public bool Skin { set; get; }

        public string Teeth
        {
            set
            {
                this._teeth = value;
            }

            get
            {
                return _teeth;
            }
        }

        /* 
        public  void Sleep()
        {
            System.Console.WriteLine("Sleep");
        }

        */

        public virtual void Eat()
        {
            Console.WriteLine("Dinosaur Eat");
        }

        public class Raptor : Dinosaur
        {
            public void Group()
            {
                Color = "Brown";
            }
        }


    }

    public class TRex : Dinosaur
    {
        public void Stomp()
        {
            Color = "Blue";
            System.Console.WriteLine("Stomp");
        }

        public override void Eat()
        {
            Console.WriteLine("Trex Eat");
        }

         
        private void Sleep()
        {
            System.Console.WriteLine("Sleep");
        }
        


    }
}