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
            //HelloWorld();
            
            Welcome();
            
            string input = Console.ReadLine().Trim();

            bool numberTrue = input.All(char.IsDigit);

            while (input.Length == 0 || numberTrue == false)
            {
                Console.WriteLine("Please enter a number");
                input = Console.ReadLine();
                numberTrue = input.All(char.IsDigit);
            }

            Console.WriteLine(Square(StringToInt(input)));

            Console.ReadLine();
        }

        static int StringToInt(string input)
        {
            bool tryParse = int.TryParse(input, out int result);

            return result;
        }

        static int Square(int input)
        {
            int square = input * input;
            
            return square;
        }

        static void Welcome()
        {
            Console.WriteLine("Hello and welcome to me simple program that squares your desired value");
            Console.WriteLine("\nPlease enter a value above 0 and press enter");
        }

        static void HelloWorld()
        {
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
