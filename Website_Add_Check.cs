using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Regular_Expression
{
    internal class Website_Add_Check
    {
        public Website_Add_Check()
        {
            string pattern = @"^(https?://)?(www\.)?[\w-]+(\.[a-zA-Z]{2,}){1,2}(/[\w-]*)*(/)?$";
            string[] websites = {
            "https://www.example.com",
            "http://example.co.uk",
            "www.example.com/index.html",
            "invalid.website",
            "https://",
           
        };

           
            foreach (string website in websites)
            {
                bool isValid = Regex.IsMatch(website, pattern, RegexOptions.IgnoreCase);

                Console.WriteLine($"Website: {website}");
                Console.WriteLine($"Is Valid: {isValid}");
                Console.WriteLine();
            }
        }
    }
}
