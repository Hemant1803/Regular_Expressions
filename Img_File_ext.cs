using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    internal class Img_File_ext
    {
        public Img_File_ext()
        {
            string pattern = @"^.+\.(jpg|jpeg|png|gif|bmp)$";

            string[] fileNames = { "image.jpg", "photo.png", "picture.gif", "document.txt", "logo.bmp", "not_an_image.pdf" };
            foreach (string fileName in fileNames)
            {
                bool isMatch = Regex.IsMatch(fileName, pattern, RegexOptions.IgnoreCase);
                Console.WriteLine($"File Name: {fileName}");
                Console.WriteLine($"Is Valid: {isMatch}");
                Console.WriteLine();
            }
        }
    }
}
