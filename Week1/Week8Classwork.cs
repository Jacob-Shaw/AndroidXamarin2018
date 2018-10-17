using Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMaterial.Week1
{
    public static class Week8Classwork
    {
        public static void RunWeek7Classwork()
        {
            AnonymousTypeExample();


            void AnonymousTypeExample()
            {
                CollectionExamples mySample = new CollectionExamples();

                var myDinos =
                    from dino in mySample.MyListExample()
                    select new { dino.Size, dino.Teeth, dino.Skin };

                foreach (var item in myDinos)
                {
                    Console.WriteLine("Size = {0}, Teeth = {1}, Skin = {2}", item.Size, item.Teeth, item.Skin);
                }
            }
            
        }
    }
}
