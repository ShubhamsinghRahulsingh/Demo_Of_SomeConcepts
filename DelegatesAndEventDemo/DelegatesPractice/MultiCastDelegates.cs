using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    public class MultiCastDelegates
    {
        public static void Addition(int a, int b)
        {
            Console.WriteLine("Sum is: " + (a + b));
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Product is: " + (a * b));
        }
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine("Subtract is: " + (a - b));
        }
    }
}
