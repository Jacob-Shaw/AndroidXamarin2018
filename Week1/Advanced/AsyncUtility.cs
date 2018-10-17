using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Advanced
{
    public class AsyncUtility
    {
        public async Task<string> BottlesOfBeerAsync()
        {
            int beernum = 99;
            string word = "bottles";
            string result = "";

            while (beernum > 0)
            {

                if (beernum == 1)
                {
                    word = "bottle"; //singular
                }


                Console.WriteLine(beernum + " " + word + "of beer on the wall,");
                Console.WriteLine(beernum + " " + word + "of beer,");
                Console.WriteLine("Take one down,");
                Console.WriteLine("Pass it around,");

                beernum--;

                if (beernum > 0)
                {
                    Console.WriteLine(beernum + " " + word + "of beer on the wall");
                }
                else
                {
                    result = await Task.FromResult<string>("No more bottles of beer on the wall!");
                }

            }

            return result;
        }

        
    }
}
