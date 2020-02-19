using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allt_för_alla_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            
            string input = Console.ReadLine();

            Console.WriteLine(Square(StringToInt(input)));

            Console.ReadLine();
        }

        static int StringToInt(string input)
        {
            int.TryParse(input, out int result);

            return result;
        }

        static int Square(int input)
        {
            int square = input * input;
            
            return square;
        }

        static void Hello()
        {
            Console.WriteLine("Hello and welcome to me simple program that squares your desired value");
            Console.WriteLine("\nPlease enter a value above 0 and press enter");
        }
    }
}
