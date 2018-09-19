using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralGenerator
{
    //Interface
    public interface IRomanNumeralGenerator
    {
        string generate(int number);
    }

    /// <summary>
    /// RomanNumerals class contains a method that converts numbers into Roman Numerals and implements IRomanNumeralGenerator
    /// </summary>
    public class RomanNumerals : IRomanNumeralGenerator
    {
        /// <summary>
        /// Dictionary that will hold all the Numbers To Numberals
        /// </summary>
        private Dictionary<int, string> NumberToNumeralDictionary = new Dictionary<int, string>();
        public RomanNumerals()
        {
            //Populate the dictionary as soon as the constructor is called.
            populateNumeralDictionary();
        }

        /// <summary>
        /// Generate Roman Numerals based on the number passed as a parameter
        /// </summary>
        /// <param name="number">number to be converted to Roman Numerals</param>
        /// <returns>String Roman Numberal</returns>
        public string generate(int number)
        {
            var results = new StringBuilder();

            //Check if the number is between 1 - 3999
            if (number >= 1 && number <= 3999)
            {
                foreach (var item in NumberToNumeralDictionary)
                {
                    while (number >= item.Key)
                    {
                        results.Append(item.Value);
                        number -= item.Key;
                    }
                }
            }
            else
            {
                results.Append("Make sure the number you enter is between 1 and 3999");
            }

            return results.ToString();
        }

        /// <summary>
        /// Populate the dictionary with number and their roman numeral equivalent
        /// </summary>
        private void populateNumeralDictionary()
        {
            NumberToNumeralDictionary.Add(1000, "M");
            NumberToNumeralDictionary.Add(900, "CM");
            NumberToNumeralDictionary.Add(500, "D");
            NumberToNumeralDictionary.Add(400, "CD");
            NumberToNumeralDictionary.Add(100, "C");
            NumberToNumeralDictionary.Add(90, "XC");
            NumberToNumeralDictionary.Add(50, "L");
            NumberToNumeralDictionary.Add(40, "XL");
            NumberToNumeralDictionary.Add(10, "X");
            NumberToNumeralDictionary.Add(9, "IX");
            NumberToNumeralDictionary.Add(5, "V");
            NumberToNumeralDictionary.Add(4, "IV");
            NumberToNumeralDictionary.Add(1, "I");
        }
    }
}
