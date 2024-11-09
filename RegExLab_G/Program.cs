using System;
using System.IO;
namespace RegExLab_G
{
    internal class Program
    {
        static String searchPatt = @"([A-Z]+[a-zA-Z]*(\s+[A-Z]+[a-zA-Z]*){2,})"; // modify regex here...
        static String replacePatt = @"""$1"""; // ...and here
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