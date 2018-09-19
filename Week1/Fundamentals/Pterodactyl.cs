using System;

namespace Fundamentals
{
    public class Pterodactyl : Dinosaur
    {
        
        public override void Eat()
        {
                //
                System.Console.WriteLine("Pterodactyl Eat");
        }

        public void Fly()
        {

            //
            System.Console.WriteLine("Fly");
        }

        private void Sleep()
        {
            System.Console.WriteLine("Pterodactyl Sleep");
        }
    }
}