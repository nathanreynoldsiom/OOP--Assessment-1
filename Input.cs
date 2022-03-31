using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssesment1
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        bool isValid = false;

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            // Loops the text doesnt end in a *
            while (isValid == false)
            {

                // user input
                Console.WriteLine("Please enter your text with an * at the end of your input" );
                text = Console.ReadLine();

                // checks for * at the end of the text
                foreach (var i in text)
                {
                    if (i.ToString() == "*")
                    {
                        isValid = true;
                    }
                }
            }

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {

            return text;
        }

    }
}
