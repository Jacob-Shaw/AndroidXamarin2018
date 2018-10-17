using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BoatOrder : IOrder
    {     
        public string GetOrder
        {
            get { return ""; }
            set { }
        }

        public decimal Price
        {
            get { return 0m; }
            set {  }
        }
    }
}