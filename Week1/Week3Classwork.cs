using System;
using Fundamentals;
using ClassMaterial.Week1.Fundamentals;
using System.Collections.Generic;


namespace ClassMaterial.Week1
{
    public static class Week3Classwork
    {
        public static void RunWeek3Classwork()
        {
            
            //Week 3 in class
            //Deconstructor
            //ClassMaterial.Week1.Week3.Square MySquare0 = new ClassMaterial.Week1.Week3.Square(11,22);


            ClassMaterial.Week1.Week3.Square MySquare = new ClassMaterial.Week1.Week3.Square(3,3);  //

            //var (length, height) = MySquare;    //
            
            int length = 5, height = 5;//////////, top = 100;


            MySquare.Deconstruct(out length, out height);//////////, out top); 

            System.Console.WriteLine("MySquare.Length = " + MySquare.Length); //

            (length, height) = MySquare;

            System.Console.WriteLine("2nd MySquare.Length = " + MySquare.Length);

            //ClassMaterial.Week1.Week3.Square MySquare2 = new ClassMaterial.Week1.Week3.Square(,);

            //MySquare.Deconstruct(out length, out height);

            System.Console.WriteLine(length);  //


            //ClassMaterial.Week1.Week3.Square MySquare3 = new ClassMaterial.Week1.Week3.Square(3,3);


            ClassMaterial.Week1.Week3.Square yourSquare = 
                new ClassMaterial.Week1.Week3.Square{Length = 5, Height = 5, Color = "Blue"}; 

            Dinosaur dino1 = new Dinosaur();

            dino1.Size = 10;

            TRex tRex = new TRex();
            tRex.Size = 20;

            Dinosaur dino2 = new TRex();  //upcasting

            //Now play with private, public, protected and sealed of the 
            //  base and child class to see 
            //  what you can access with the dot operator
            dino2.Eat();

            Dinosaur dino3 = new Pterodactyl(); //upcasting
            dino3.Eat();


            Dinosaur dino4 = new Dinosaur();
            dino4 = (TRex)tRex;
            dino4.Eat();
            dino4 = (Pterodactyl)dino3;
            dino4.Eat();

            System.Console.WriteLine("Now let's try an IS:");

            Dinosaur[] dinoArray = {dino1, tRex, dino2, dino3};

            foreach ( Dinosaur item in dinoArray)
            {
                if( item is TRex)
                {
                    item.Eat();
                }

                /* 
                if( item is Pterodactyl)
                {
                    item.Sleep();

                }

                */                 
            }
            
            System.Console.WriteLine(Utility.AddTwoNumbers(10101, 1010));
            System.Console.WriteLine(Utility.AddTwoNumbers(10101, 1010));
       
            var dinoList = new List<Dinosaur>(10000);
         
            dinoList.Add(dino1);
            dinoList.Add(tRex);
            dinoList.Add(dino2);
            dinoList.Add(dino3);

            foreach (var item in dinoList)
                Console.WriteLine(item);
            
            dinoList.ForEach(item => Console.Write(item + ","));

            System.Console.WriteLine("Week3Classwork");
        }
    }
}