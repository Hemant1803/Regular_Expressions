using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    internal class Undersore
    {
        public Undersore() 
        {
            string pattern = @"[a-z]+(_[a-z]+)+";


            string[] Strings = { "hemant_sharma","hello world","this_is_a_long_sequence_of_lowercase_letters" };


            foreach (string String in Strings)
            {
                bool isMatch = Regex.IsMatch(String, pattern);
                Console.WriteLine($"Input: {String}");
                Console.WriteLine($"Match: {isMatch}");
                Console.WriteLine();
            }
        }
    
    }
}
