using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class OrderDecorator : IOrder
    {
        protected IOrder tempOrder;


        public OrderDecorator(IOrder newOrder)
        {
            tempOrder = newOrder;
        }

        public virtual string GetOrder
        {
            get { return tempOrder.GetOrder; }
            set { }
        }

        public virtual decimal Price
        {
            get { return tempOrder.Price; }
            set { this.Price = value; }
        }
    }
}