using DelegatesPractice;
using System;
using System.Security.Cryptography.X509Certificates;

namespace DelegatesAndEvents
{
    class Program
    {
        public delegate void DelegateMethod(int x, int y);//Delegate definition
        public static void Main(string[] args)
        {
            DelegateMethod del = new DelegateMethod(SingleCastDelegate.Divide);//Delegate instantiating
                                                                               // del(20, 5);
            del += MultiCastDelegates.Addition;
            del += MultiCastDelegates.Multiplication;
            del += MultiCastDelegates.Subtraction;
            del(20, 5);
            del(40, 8);
        }
    }
}