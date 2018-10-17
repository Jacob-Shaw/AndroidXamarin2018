using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceObserver
{
    public class PriceWatch
    {
        public event EventHandler ValueChanged;

        private decimal _currentPrice;
        private  decimal _currentBudget;

        public PriceWatch()
        {
            _currentPrice = 0;
            _currentBudget = 0;
        }

        public virtual decimal CurrentPrice  
        {
            set
            {
               this._currentPrice = value;  
                OnValueChanged();
            }
            get
            { return _currentPrice; }   
        }

        public virtual decimal CurrentBudget  
        {
            set
            {
                this._currentBudget = value;  
                OnValueChanged();
            }
            get
            { return this._currentBudget; }   
        }

        protected void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }
    }
}
