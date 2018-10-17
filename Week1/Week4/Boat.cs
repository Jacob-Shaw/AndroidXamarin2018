using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceObserver;
using ClassMaterial.Week1;

namespace Decorator
{
    public class Boat : OrderDecorator
    {
        decimal _thisBoatPrice;

        public Boat(IOrder newOrder, decimal boatPrice) : base(newOrder)
        {
            _thisBoatPrice = boatPrice;
            Console.WriteLine("Boat = $" + _thisBoatPrice);
        }

        public override string GetOrder
        {
            get { return (tempOrder.GetOrder); }
        }

        public override decimal Price
        {
            get { return tempOrder.Price + _thisBoatPrice; }
        }
    }
}