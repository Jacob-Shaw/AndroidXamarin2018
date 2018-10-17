using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PriceObserver
{
    public class PriceMonitor
    {
        public decimal PriceAlert = 30;

        public PriceMonitor(PriceWatch price)
        {
            price.ValueChanged += ValueHasChanged;
            PriceAlert = price.CurrentPrice;
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            PriceWatch myPrice = (PriceWatch)sender;

            if (myPrice.CurrentPrice > myPrice.CurrentBudget)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("You are over your budget! \a ( $" + myPrice.CurrentPrice + " )");
                Console.WriteLine("That is $" + (myPrice.CurrentPrice - myPrice.CurrentBudget) + " too much!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You are on budget. " + "$" + myPrice.CurrentPrice + " spent so far.");
                Console.WriteLine();
            }
        }
    }
}
