using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Customer
    {
        public int a, b;
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()//parameterless constructor
        {
            Id = 101;
            Name = "Shubham";
        }
        public Customer(int id)//parameterised constructor
        {
            Id = id;
        }
        public void Print()//parameterless method
        {

        }
        public void Test(int a)//parameterised method
        {

        }
    }
}
