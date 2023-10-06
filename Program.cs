using System.Text.RegularExpressions;

namespace Regular_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; ) {
                Console.WriteLine( "\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
                Console.WriteLine("Select A Programe You Want To Run");
            Console.WriteLine("\n1.A C# program to find sequences of lowercase letters joined by an underscore. \n2.Regular expression to fetch all HTML tags from a given string.\n3.Count the number of occurrences of the pattern\n4.Regular expression to find valid file names with an image file type extension.\n5.Regular expression to validate a website address format.");
           
                int option = Convert.ToInt32(Console.ReadLine());
               

            switch (option)
            {
                case 1:
                    Undersore undersore = new Undersore();
                    break;
                case 2:
                    Html_Tags tag = new Html_Tags();
                    break;
                case 3:
                    Num_Occurrences num_Occurrences = new Num_Occurrences();
                    break;
                case 4:
                    Img_File_ext img_File_Ext = new Img_File_ext();
                    break;
                case 5:
                    Website_Add_Check website_Add_Check = new Website_Add_Check();
                    break;
                    case 6:
                    Console.WriteLine("Exit");
                    return;
            }
               

            }
        }
    }
}