using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssesment1
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public void results(List<int> values)
        {
            
            Console.WriteLine("Number of sentances: " + values[0]);
            Console.WriteLine("Number of vowels: " + values[1]);
            Console.WriteLine("Number of consonants: " + values[2]);
            Console.WriteLine("Number of upper case letters: " + values[3]);
            Console.WriteLine("Number of lower case letters: " + values[4]);
           
            Console.ReadLine();
        }

    }
}
