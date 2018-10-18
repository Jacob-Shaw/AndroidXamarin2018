using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerInfoClass
{
    public class CustomerInfo
    {
        private string _name;
        private string _address;


        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                this._name = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                this._address = value;
            }
        }

        public void CustomerName(string name)
        {
            this._name = name;
        }

        public void CustomerAddress(string address)
        {
            this._address = address;
        }
    }
}
