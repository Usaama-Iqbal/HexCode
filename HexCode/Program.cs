using System;
using System.Text.RegularExpressions;
namespace HexCode
{
    class program
    {
        public static void Main(string[] args) 
        {
            string hc = "#CD5C5C";
            Console.WriteLine("Hex Code: " + hc + " valid : " +test(hc));

            hc = "#EAECEE";
            Console.WriteLine("Hex Code: " + hc + " valid : " + test(hc));

            hc = "#eaecee";
            Console.WriteLine("Hex Code: " + hc + " valid : " + test(hc));

            hc = "#CD5C58C";
            Console.WriteLine("Hex Code: " + hc + " valid : " + test(hc));
        }

        public static bool test(string hc)
        {

            return Regex.IsMatch(hc, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}