using System;
using System.IO;
namespace RegExLab_F
{
    internal class Program
    {

        static String searchPatt = @"\\texttt{([a-zA-Z]+|[0-9]+)\}"; // modify regex here...
        static String replacePatt = @"\begin{ttfamily}$1\end{ttfamily}"; // ...and here
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