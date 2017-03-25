using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Input
            Console.WriteLine("Please Enter a Five Digit Number: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            int result = 0;


            // Process
            while (n > 0)
            {
                int remainder = n % 10;
                result = (result * 10) + remainder;
                n = n / 10;
            }


            // Output
            Console.WriteLine(" ");
            Console.WriteLine("Your Number Reversed Is: " + result);
            
            
        }
    }
}
