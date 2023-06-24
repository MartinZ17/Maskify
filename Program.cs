using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maskify("4556364607935616"); // should return "############5616"
            Maskify("64607935616");      // should return "#######5616"
            Maskify("1");                // should return "1"
            Maskify("");                 // should return ""
            

            string cc = "64607935616";
            Console.WriteLine(Maskify(cc));
            
            
        }    

        public static string Maskify(string cc)
        {
            string[] digits = new string[cc.Length];
            string result = "";
            for (int i = 0; i < cc.Length; i++)
            {
                digits[i] = cc[i].ToString();
            }
            if (digits.Length >= 4)
            {
                for (int i = 0; i < digits.Length - 4; i++)
                {
                    digits[i] = "#";
                    result += digits[i];

                }
                string lastFour = cc.Substring(cc.Length - 4);
                result += lastFour;
            }
            else
            {
                result = cc;
            }
            return result;
        }
       
    }
}
