using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceObserver
{
    public class PriceChangeNotifier
    {
        public PriceChangeNotifier(PriceWatch price)
        {
            price.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            PriceWatch myPrice = (PriceWatch)sender;
        }
    }
}
