using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.services
{
    public class RangeTranslationService
    {
        public int[] ConvertStringToInteger(string start, string end)
        {
            int[] range = new int[2];
            
            while (!int.TryParse(start, out range[0]))
            {
                Console.WriteLine("Please enter an integer to start the range:");
                start = Console.ReadLine() ?? "none";
            };
            while (!int.TryParse(end, out range[1]))
            {
                Console.WriteLine("Please enter an integer to end the range:");
                end = Console.ReadLine() ?? "none";
            };

            return range;
        }
    }
}
