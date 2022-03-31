
//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssesment1
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file

            Input i = new Input();

            string text = "";
            string fileLocation;

            Console.WriteLine("1. Do you want to enter the text via the keyboard?");
            Console.WriteLine("2. Do you want to read in the text from a file?");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());


            if (userInputNumber == 1)
            {
                text = i.manualTextInput();

            }
            else if (userInputNumber == 2)
            {
                Console.WriteLine("Plesae enture your file location");
            }
            else
            {
                Console.WriteLine("Not a valid imput");
            }

            Console.ReadLine();

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            Analyse a = new Analyse();
            List<int> values = a.analyseText(text);

            // This gives the final results using the report class
            Report r = new Report();
            r.results = values;



        }

    }
}