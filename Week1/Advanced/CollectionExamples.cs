using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Fundamentals;

namespace Advanced
{
    public class CollectionExamples
    {
        public void MyArrayListExample()
        {
            ArrayList myList = new ArrayList();
            myList.Add("Hello");
            myList.Add("World");

            Console.WriteLine("Count = " + myList.Count);

            foreach (Object obj in myList)
            {
                Console.WriteLine("type = " + obj);

            }
        }

            public List <Dinosaur> MyListExample()
            {
                List<Dinosaur> myDinos = new List<Dinosaur>();
                myDinos.Add(new Dinosaur() { Size = 50, Teeth = "Serrated", Skin = true });
                myDinos.Add(new Pterodactyl() { Size = 25, Teeth = "Sharp" });
                myDinos.Add(new Dinosaur.Raptor() { Size = 10, Teeth = "Serrated", Skin = false });

                return myDinos;

                /*
                foreach (Dinosaur dinosaur in myDinos)
                {
                    Console.WriteLine(dinosaur.Size);
                }
                */

            }
    }
}
