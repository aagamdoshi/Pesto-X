using System;
using System.Linq;

namespace PrudentailWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 999; // Read input from code 
            bool isNeg = false;
            if (a < 0)
                isNeg = true;
            countNonDuplicatewithDictionary(a, isNeg);
        }

        private static void countNonDuplicatewithDictionary(int a, bool isNeg)
        {
            string digits = a.ToString();
            if (isNeg)
            {
                digits = digits.Substring(1);
            }
            int len = digits.Length;
            int[] maxAr = new int[len + 1];
            for (int i = 0; i <= len; i++)
            {
                string a1 = digits.Substring(0, i) + '5';
                string a2 = digits.Substring(i);
                var amax = a1 + a2;
                maxAr[i] = Int32.Parse(amax);
               
            }
            if(isNeg)
                Console.WriteLine(Int32.Parse("-"+ maxAr.Min()));
            else
                Console.WriteLine(maxAr.Max());
            Console.ReadLine();
        }
     
    }
}

