using System;
using System.Collections.Generic;
namespace LambdaExpressionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lambda Expression Part");
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);
            Retreiving_TopTwoRecords_ForAge_LessThan60(listPersonsInCity);
            CheckingForTeenager(listPersonsInCity);
            FindingSomeoneByName(listPersonsInCity, "Shubham");
            RemoveSomeoneFromTheList(listPersonsInCity, "Ajay");
            FindAverageOfAges(listPersonsInCity);
        }
        //UC1
        public static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("235467867", "Shubham", "Rampuri Colony,Saharanpur", 26));
            listPersonsInCity.Add(new Person("235456739", "Rahul", "Lakhan Colony,Bareilly", 25));
            listPersonsInCity.Add(new Person("235423434", "Ajay", "Bihar  Colony,MBD", 65));
            listPersonsInCity.Add(new Person("267867867", "Mahesh", "khanpura,Deoband", 30));
            listPersonsInCity.Add(new Person("564467867", "Rakesh", "Brijshan,dehradun", 17));
            listPersonsInCity.Add(new Person("876467867", "Tejasvee", "Rishwar colony,Roorkee", 90));
            Console.WriteLine();
            foreach (Person person in listPersonsInCity)
            {
                Console.WriteLine("Person Data Management:\n"+"SSN: "+person.SSN+" |  Name:"+person.Name+" |  Address: "+person.Address+" |  Age: "+person.Age);
            }
            Console.WriteLine();
        }
        //UC2
        public static void Retreiving_TopTwoRecords_ForAge_LessThan60(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Top Two with age greater than 60 are:");
            foreach(Person person in listPersonsInCity.FindAll(e => (e.Age<60)).Take(2).ToList())
            {
                Console.WriteLine("Name : "+person.Name+"\t\tAge:"+person.Age);
            }
            Console.WriteLine();
        }
        //UC3
        public static void CheckingForTeenager(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine("Yes We Have Some Teenager in the list");
            }
            else
            {
                Console.WriteLine("Sorry We Don't Have Any Teenager in the list");
            }
            Console.WriteLine();
        }
        //UC4
        public static void FindingSomeoneByName(List<Person> listPersonsInCity,string name)
        {
            if (listPersonsInCity.Any(e => e.Name.Equals(name)))
            {
                Console.WriteLine("Yes {0} is there in the list", name);
            }
            else
            {
                Console.WriteLine("Sorry  {0} is not there in the list", name);
            }
            Console.WriteLine();
        }
        //UC5
        public static void RemoveSomeoneFromTheList(List<Person> listPersonsInCity, string name)
        {
            bool find = true;
           foreach(Person person in listPersonsInCity.FindAll(e => (e.Name==name)))
           {
                find = false;
               listPersonsInCity.Remove(person);
                Console.WriteLine("Person is Removed Successfully");
           }  
           if(find)
           {
                Console.WriteLine("Person Not Found");
           }
            else
            {
                foreach (Person person in listPersonsInCity)
                {
                    Console.WriteLine("Modified Person Data Management:\n" + "SSN: " + person.SSN + " |  Name:" + person.Name + " |  Address: " + person.Address + " |  Age: " + person.Age);
                }
            }
            Console.WriteLine();
        }
        //UC6
        public static void FindAverageOfAges(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Average of Ages :"+listPersonsInCity.Average(e=>e.Age));
        }
    }
}