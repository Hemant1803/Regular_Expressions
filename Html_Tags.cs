using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    internal class Html_Tags
    {
        public Html_Tags() 
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";           
            string pattern = @"<[^>]+>";
            MatchCollection matches = Regex.Matches(input, pattern);            
            Console.WriteLine("Matched HTML Tags:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
