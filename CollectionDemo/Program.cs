using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Collection Part");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\nSelect from the following\n1.DictionaryDemo\n2.ListDemo\n3.StackDemo\n4.QueueDemo\n5.SetDemo\n6.Exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        dictionaryDemo();
                        break;
                    case 2:
                        listDemo();
                        break;
                    case 3:
                        stackDemo();
                        break;
                    case 4:
                        queueDemo();
                        break;
                    case 5:
                        setDemo();
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }            
        }
        public static void dictionaryDemo()//no duplicacy will give exception
        {
            Console.WriteLine("\nIn Dictionary Demo");
            Dictionary<int,string> dictionary = new Dictionary<int,string>();//create dictionary with key int type and value string type
            dictionary.Add(100, "Shubham");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Raj");
            Console.WriteLine("Access value using Key(key=100):" + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary");
            foreach(var element in dictionary)
            {
                Console.WriteLine("Key= "+element.Key+" Value= "+element.Value);
            }
        }
        public static void listDemo()//Duplicacy is allowed
        {
            Console.WriteLine("\nIn List Demo");
            List<string> list = new List<string>();//creating list
            //Addint objects to the list
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            Console.WriteLine("\nIterating List");
            Console.Write("Data in List are as: ");
            foreach (var element in list)
            {
                Console.Write(element+" ");
            }
        }
        public static void stackDemo()//Duplicacy allowed
        {
            Console.WriteLine("\nIn Stack Demo");
            //creating Queue
            Stack<string> stack = new Stack<string>();
            stack.Push("Divya");
            stack.Push("Sidharth");
            stack.Push("Lalit");
            stack.Push("Snehal ");
            stack.Push("Prerna");
            stack.Push("Lalit");
            Console.WriteLine("Head: " + stack.Peek());//only return not delete the element
            Console.WriteLine("\nIterating the Stack Elements:");
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            string pop=stack.Pop();
            Console.Write("Popped Element is: "+pop);//will delete the top most element
            Console.WriteLine("\nIterating Stack Elements after Popping one element :");
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }

        }
        public static void queueDemo()//Duplicacy allowed
        {
            Console.WriteLine("\nIn Queue Demo");
            //creating Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Singh");
            queue.Enqueue("Jaishankar ");
            queue.Enqueue("Rajesh Kumar");
            queue.Enqueue("Vijay Singh");
            Console.WriteLine("Head: "+queue.Peek());
            Console.WriteLine("\nIterating the Queue Elements:");
            foreach(var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue=queue.Dequeue();
            Console.Write("Dequeue Element is:"+dequeue);//delete first entered element
            Console.WriteLine("\nIterating the queue elements after Dequeue one element :");
            //Iterating the queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void setDemo()//No duplicate object is stored
        {
            Console.WriteLine("\nIn Set Demo");
            HashSet<string> set =new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}