using System;

    /* This class will return grade descriptions */
    public class GradeDescriptions
    {
        private bool getUserInput = true;
        private string _gradeLetter = "";
        private char _gradeForComparison;
       
        
        public void GetGradeDescription(string[] GradeSystem)
        {            
            GetInput();

            CompareGrade(GradeSystem, _gradeForComparison);
          
        }

        public void GetInput()
        {
            do
            {
                //Tell the user what to do
                Console.WriteLine("\n" + "Please enter the letter grade in question:","\n");
                Console.WriteLine("(Only one letter from A-Z please.)", "\n");

                //Get a grade letter from the user
                _gradeLetter = Console.ReadLine();
                
                //Check to see if the user followed directions
                if (_gradeLetter.Length == 1)
                {
                    //Take the user input and put it into the letterArray
                    char[] letterArray = _gradeLetter.ToCharArray();

                    //Change the array entry for testing
                    char GradeToCompare = letterArray[0];

                    //check for upper or lower case letter
                    if ((GradeToCompare > 64 && GradeToCompare < 91) || (123 > GradeToCompare && GradeToCompare > 96))
                    {
                        //If a letter was entered
                        _gradeForComparison = GradeToCompare;
                        getUserInput = false;
                    }
                    else
                    {
                        //A letter was not entered
                        Console.WriteLine("\n" + "I'm sorry, please try again.");
                    }
                    
                }
                else
                {
                    //If more than one letter was entered
                    Console.WriteLine("\n" + "I'm sorry, please try again.");
                }

            //Loop until a letter is entered
            } while (getUserInput == true);
        }

        //Compare the letter given to the available grade descriptions
        public void CompareGrade(string[] gradeList, char changeChar )
        {
            bool foundDescription = false;

            //Change letter to upper case
            char checkLetter = char.ToUpper (changeChar);

            //Check each grade description for the letter entered
            foreach (string x in gradeList)
            {
                if (x.StartsWith(checkLetter))
                {
                    foundDescription = true;
                    Console.WriteLine("Description of letter \"" + checkLetter + "\" : " + x);

                    //This will cause a break out of the "if" and "foreach" statement
                    break;
                }
                
            }

            if(foundDescription == false)
            {
                Console.WriteLine("The letter \"" + checkLetter + "\" is not a valid grade.");
            }
            
        }        

    }