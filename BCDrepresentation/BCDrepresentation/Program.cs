using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDrepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rep = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001" };
            int number = 0;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            bool neg = number >= 0 ? false : true;
            number *= neg ? -1 : 1;
            int k = 10;
            int nn = 9;
            int revn = number % 10;
            while (number / k > 0)
            {
                revn = revn * 10 + (number / k) % 10;
                nn = nn * 10 + 9;
                k *= 10;
            }
            number = neg ? nn - revn : revn;
            Console.Write((neg ? rep[9] : rep[0]) + " ");
            while (number > 0)
            {
                Console.Write(rep[number % 10] + " ");
                number /= 10;
            }
            Console.ReadLine();
        }
    }
}
