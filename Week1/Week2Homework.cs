using System;

namespace ClassMaterial.Week1
{
    public static class Week2Homework
    {
        public static void RunWeek2Homework()
        {
            // Homework Week 2

            /* Accept a grade and get back a description of the grade. 
            If a grade entered is not correct, display a message 
            that it is not a valid grade. */

            string[] grades = { "Excellent", "Very Good", "Good", "Average", "Fail" };
            
            GradeDescriptions Gradelist = new GradeDescriptions();

            Gradelist.GetGradeDescription(grades);

            //Display the first 10 natural numbers
            Console.WriteLine("\n" + "The first 10 natural numbers are:");

            int numbersToDisplay = 10;


            for(int i = 1; i < (numbersToDisplay + 1) ; i++ )
            {
                Console.Write(i);

                if( i < numbersToDisplay )
                {
                    Console.Write(", ");
                }
            }
        }
    }
}