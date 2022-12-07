using System;
namespace EventsPractice
{
    public delegate void DelEventHandler();
    class Program
    {
        public static event DelEventHandler add;

        public static void Main(string[] args)
        {
            Console.WriteLine("Events Practice Session");
            add +=new DelEventHandler(India);
            add += new DelEventHandler(America);
            add += new DelEventHandler(England);
            add();
            Console.WriteLine("***********EventHandling**************");
            EventHandling.ImplementEvent();
        }
        public static void India()
        {
            Console.WriteLine("Hello India");
        }
        public static void America()
        {
            Console.WriteLine("Hello America");
        }
        public static void England()
        {
            Console.WriteLine("Hello England");
        }
    }
}