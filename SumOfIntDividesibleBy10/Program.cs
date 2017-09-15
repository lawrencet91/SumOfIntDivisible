using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Divide by: ");
            string divideInput = Console.ReadLine();
            char[] num = userInput.ToCharArray();
            int total = 0;
            foreach(char a in num)
            {
                total += Convert.ToInt32(a.ToString());
            }

            if (total%Convert.ToInt32(divideInput.ToString()) == 0)
            {
                Console.WriteLine(total + " Divisible by " + divideInput);
            }else
            {
                Console.WriteLine(total + " Not divisible by " + divideInput);
            }
            Console.ReadLine();
        }
    }
}
