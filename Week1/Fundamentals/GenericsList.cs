using System;

namespace ClassMaterial.Week1.Fundamentals
{
    public class GenericsList<T> 
    

    {
        public void Add (T input) {}

        

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}