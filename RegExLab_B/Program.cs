using System;
using System.IO;
namespace RegExLab_B
{
    internal class Program
    {
        static String searchPatt = "([a-z])([A-Z])"; // modify regex here...
        static String replacePatt = "_?_$1$2_?_"; // ...and here
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            while (str != null)
            {
                String newStr = System.Text.RegularExpressions.Regex.Replace(str, searchPatt, replacePatt);
                Console.WriteLine(newStr);
                str = Console.ReadLine();
            }
        }

        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }*/
    }
}