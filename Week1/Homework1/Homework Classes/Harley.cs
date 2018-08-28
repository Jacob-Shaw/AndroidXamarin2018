using System;

// Harley is using inheriting from the Bicycle class using Inheritance with the ":"
public class Harley : Bicycle
{
    private bool _headLightOn = false;

        public bool HeadLightOn
    {
        get 
        {
                return _headLightOn;
        }

        set 
        {
            this._headLightOn = value;
                
            if (_headLightOn == true)
            {
                Console.WriteLine("The headlight is on.");
            }
            else
            {
                Console.WriteLine("The headlight is off.");  
            }
                
                
        }
    }
   
    //This demonstrates polymorphism, when RingBell is called, it will Beep instead of Ring
    public override void RingBell()
    {
         Console.WriteLine("Beep!");
         
    }
    
    public Harley()
    {
        Brand = "Harley Davidson";
    }
}