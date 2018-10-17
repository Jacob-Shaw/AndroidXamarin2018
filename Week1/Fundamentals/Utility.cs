namespace ClassMaterial.Week1.Fundamentals
{
    public static class Utility
    {

        //private static int _yo = 3;
        const int _years = 10;
        //static int _number = 2;


        static Utility()
        {
            System.Console.WriteLine("Hello static");
        }

        public static int AddTwoNumbers( int value1, int value2)
        {
            return value1 + value2;
        }


    }
}