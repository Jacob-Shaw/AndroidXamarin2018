using System;



namespace Week1.Week2
{
    /*
        To remove the reference that shows up above each variable add the below item to your settings.
        "csharp.referencesCodeLens.enabled": false,
     */
    public class NumericTypes
    {

        #region Integral - Signed

        // range -128 to 127
        private sbyte _mySbyteValue = 2;

        // range -32,768 to 32,767
        private short _myShortValue = 4;

        // range -2,147,483,648 to 2,147,483,647
        private int _myIntValue = 25000;

        // range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        private long _myLongValue = 1_234_567L;
        private long _myLongValue2 = 0x5F;
        #endregion

        #region Integral - Unsigned

        // range 0 - 255
        private byte _myByteValue = 3;

        // range 0 - 65,535
        private ushort _myUshortValue = 35;

        // range 0 to 4,294,967,295
        private uint _myUInt = 2345U;

        // range 0 to 18,446,744,073,709,551,615
        private ulong _myULong = 1234UL;
        #endregion

        #region Real

        // range ±1.5 x 10 superscript−45 to ±3.4 x 10 superscript38
        private float _myFloatValue = -123.6589F;

        // range ±5.0 × 10 superscript−324 to ±1.7 × 10 superscript308
        private double _myDoubleValue = 12.34D;
        private double _myDoubleValue2 = 1E06;
        private double _myDoubleValue3 = 12.34;

        // range ±1.0 x 10 superscript-28 to ±7.9228 x 10 superscript28
        private decimal _myDecimalValue = 12.234M;

        #endregion

        /*
                There are additional parts to Conversion Operators not shown in these examples.
                They will be covered in Advanced C# later in this course.
                These are simple examples of converting.
         */

        /*
            The conversion operator converts from a source type to a target type.
            The source type provides the conversion operator. Unlike implicit conversions
            , explicit conversion operators must be invoked by means of a cast.
         */
        public void ConvertFloatToInt()
        {
            int converted = (int)_myFloatValue;
            Console.WriteLine(converted);
        }

        // Example of an implicit conversion
        public void LongFromInt()
        {
            long someValue = _myIntValue;
            Console.WriteLine(someValue);
        }

        /*
            Example of an implicit conversion that takes a method parameter and returns a variable 
            back to who ever called the method.
         */
        public long LongFromInt(int value)
        {
            return value;
        }

        // Method showing the Increment and Decrement
        // myVal++ is equal to myVal = myVal + 1;
        public void IncrementDecrement()
        {
            int myVal = 1, myOtherVal = 10, mySecondVal = 4, mySecondOther = 23;
            int afterVal = myVal++;
            int afterOther = myOtherVal--;
            int beforeVal = --mySecondVal;
            int beforeOther = ++mySecondOther;

            Console.WriteLine(afterVal);
            Console.WriteLine(afterOther);

            Console.WriteLine(myVal);
            Console.WriteLine(myOtherVal);

            Console.WriteLine(beforeVal);
            Console.WriteLine(beforeOther);

        }

        // Method for explaing the Class type for a value.
        public void GetSomeTypes()
        {
            Console.WriteLine(3.0.GetType());
            Console.WriteLine(_myFloatValue.GetType());
        }

        // Method for showing basic Math
        public void BasicMath()
        {
            int myValMath = 5, myOther = 10;

            int addVal = myValMath + myOther;
            int subtractVal = myOther - myValMath;
            int multiplyVal = myOther * myValMath;
            int divisionVal = myValMath / myOther;

            // Values in between ( ) will be evaluated first.
            int total = (addVal * multiplyVal) - divisionVal;

            Console.WriteLine(addVal);
            Console.WriteLine(subtractVal);
            Console.WriteLine(multiplyVal);
            Console.WriteLine(divisionVal);
            Console.WriteLine(total);
        }

        /*
            The checked keyword is used to explicitly enable overflow checking for integral-type
            arithmetic operations and conversions.
            https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked
         */
        public void CheckOperatorType()
        {
            int val = 100, val2 = 100;


            int testValue = checked(val * val2);

            checked
            {
                int myCheck = val * val2;
            }


            Console.WriteLine(testValue);

        }

        // Method for showing special values like NaN, Infinity and true/false
        public void SpecialValues()
        {
            Console.WriteLine(2.0 / 0.0);
            Console.WriteLine(-2.0 / 0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 / -0.0);
            Console.WriteLine(0.0 / 0.0);
            Console.WriteLine((2.0 / -0.0) - (2.0 / 0.0));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0 / 0.0));
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));
        }

    }
}
