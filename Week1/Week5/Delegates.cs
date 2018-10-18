using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{

    ///Delegates should be placed above the class using them to be called by other classes using the namespace 
    /// in order to be seen by both. This class is used by Week5Homework. Placing the delegate in this spot allows 
    /// for both classes to make use of the delegate. It works with METHODS.
    public delegate void passMethod(string type);

}  
