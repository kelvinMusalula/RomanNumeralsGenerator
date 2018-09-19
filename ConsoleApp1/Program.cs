using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralGenerator
{
    class Program
    {
        static void Main(string[] args)
        {       
            RomanNumerals romanNumerals = new RomanNumerals();
            //While we are still in the loop, prompt user via the console to type something
            while (true)
            {
                Console.WriteLine("Enter a number you want to convert to Roman Numerals or enter exit to terminate");
                string line = Console.ReadLine().ToLower();
                if (line == "exit")
                {
                    break;//Breakout and terminate the loop
                }

                int number = 0;
                //Convert the text to a number. TryParse will return a boolean that can be used to check if the line is a number.
                bool isNumber = int.TryParse(line, out number);

                //Checks if the text entered is a number
                if (isNumber)
                {
                    //Pass the number to our generate method which returns results as a string.
                    Console.WriteLine(romanNumerals.generate(number));
                }
                else
                {
                    Console.WriteLine("Please make sure you enter a valid number");
                }
                Console.WriteLine("--------------------------------------------------------------");
            }
        }
    }

    

}
