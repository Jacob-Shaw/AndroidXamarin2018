using System;
using ClassMaterial.Week1.Fundamentals;

namespace ClassMaterial.Week1.Week3
{
    public class Square : Shape
    {
        //properties
        public int Length { get; set;}
        public int Height { get; set;}
        public string Color {get; set;}

        public double Radius;

        public override int Sides { set; get;}
        
        //Constructor
        public Square( int length = 10, int height = 10)
        {
            this.Length = length;
            this.Height = height;
        }
        
        public Square()
        {

        }

        
        //method


        public void Deconstruct( out int length, out int height)//////////), out int top)
        {
            //Console.WriteLine("this.Length = " + this.Length);
            //System.Console.WriteLine("this.Height = " + this.Height);

            length = this.Length;

            height = this.Height;
            //////////top = this.Height;
            Console.WriteLine("Deconstructed");
        }

        public override double Area()
        {

            Sides = 4;

            
            return 45.0;
        }

        public override void MyCoolMethod()
        {

        }

        

    
    }
}