using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Rigging : OrderDecorator
    {
        public Rigging(IOrder newOrder) : base(newOrder)
        {
            Console.WriteLine("Adding Rigging + $25.00");
        }

        public override string GetOrder
        {
            get { return (tempOrder.GetOrder + " Rigging "); }
        }

        public override decimal Price
        {
            get { return tempOrder.Price + 25.00m; }
        }
    }
}