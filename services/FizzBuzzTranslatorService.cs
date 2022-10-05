using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.services
{
    public class FizzBuzzTranslatorService
    {
        public string TranslateFizzBuzz(int number)
        {
            string translation = string.Empty;
            if (number % 3 == 0)
                translation += "Fizz";
            if (number % 5 == 0)
                translation += "Buzz";
            return translation == string.Empty ? number.ToString() : translation;
        }
    }
}
