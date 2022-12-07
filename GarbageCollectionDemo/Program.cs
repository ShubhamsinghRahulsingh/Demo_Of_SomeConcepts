using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the GarbageCollection Part");
            long mem1 = GC.GetTotalMemory(false);
            {
                //Allocating an array and make it unreachable
                int[] values = new int[50000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                //collect Garbage
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
            Console.WriteLine("############################");
            long bytes1 = GC.GetTotalMemory(false);// Get memory in bytes
            byte[] memory = new byte[1000 * 1000 * 10];//Adding ten million bytes
            memory[0] = 1;//set memory(prevent allocation from being optimised out)
            long bytes2 = GC.GetTotalMemory(false);// Get memory in bytes
            long bytes3 = GC.GetTotalMemory(true);// Get memory in bytes
            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2-bytes1);//difference
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3-bytes2);//difference
            Console.ReadLine();
        }
    }
}