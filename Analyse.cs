using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssesment1
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters

            List<int> values = new List<int>();

            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            int vowelTotal = 0;
            int notVowelTotal = 0;
            int capitalVowelTotal = 0;
            int capitalNotVowelTotal = 0;
            int sentancecount = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var notVowels = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            var capitalVowels = new HashSet<char> {'A', 'E', 'I', 'O', 'U',};
            var CapitalNotVowels = new HashSet<char> { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
            var sentanceEnders = new HashSet<char> { '.', '!' };

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowelTotal++;
                }
                else if (notVowels.Contains(input[i]))
                {
                    notVowelTotal++;
                }
                else if (capitalVowels.Contains(input[i]))
                {
                    capitalVowelTotal++;
                }
                else if (CapitalNotVowels.Contains(input[i]))
                {
                    capitalNotVowelTotal++;
                }
                else if (sentanceEnders.Contains(input[i]))
                {
                    sentancecount++;
                }
            }

            int vowelsFinal = vowelTotal + capitalVowelTotal;
            int notVowelsFinal = notVowelTotal + capitalNotVowelTotal;
            int capitalLetters = capitalVowelTotal + capitalNotVowelTotal;
            int notcapitals = vowelTotal + notVowelTotal;


            values[0] = sentancecount;
            values[1] = vowelsFinal;
            values[2] = notVowelsFinal;
            values[3] = capitalLetters;
            values[4] = notcapitals;

            //Console.WriteLine("Number of vowels are: " + vowelsFinal );
            //Console.WriteLine("Number of not vowels are: " + notVowelsFinal);
            //Console.WriteLine("Number of capitals are: " + capitalLetters);
            //Console.WriteLine("Number of non capitals are: " + notcapitals);
            //Console.ReadLine();


            return values;
        }
    }
}
