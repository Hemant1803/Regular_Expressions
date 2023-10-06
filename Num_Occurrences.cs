using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    internal class Num_Occurrences
    {
        public Num_Occurrences() { 


             string pattern = "fox(es)?";
        string input = "Foxes are omnivorous mammals belonging to several genera of the family Canidae. Some people say foxes are cunning. Others just call them fox.";      
        MatchCollection matches = Regex.Matches(input, pattern);                 
        int occurrenceCount = matches.Count;       
        Console.WriteLine($"There are {occurrenceCount} occurrences of the pattern '{pattern}' in the input string.");
    }

    }
}
