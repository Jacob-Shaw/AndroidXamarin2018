using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Electronics : OrderDecorator
    {
        public Electronics(IOrder newOrder) : base(newOrder)
        {
            Console.WriteLine("Adding Electronics + $500.00");
        }

        public override string GetOrder
        {
            get { return (tempOrder.GetOrder + " Electronics "); }
        }

        public override decimal Price
        {
            get { return tempOrder.Price + 500.00m; }
        }
    }
}