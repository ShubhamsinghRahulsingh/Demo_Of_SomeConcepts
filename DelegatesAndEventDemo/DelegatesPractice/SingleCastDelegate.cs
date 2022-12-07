using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    public class SingleCastDelegate
    {
        public static void Divide(int a, int b)
        {
            Console.WriteLine("Quotient is : " + (a / b));
        }
    }
}
