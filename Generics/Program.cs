using MyDict;
using MyList;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> numbers = new MyList<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);
            //Console.WriteLine("There are " + numbers.Count + " items.");

            //var items = numbers.GetItems;
            //for(int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine(items[i]);
            //}

            //numbers.Remove(2);
            //numbers.Remove(4);
            //Console.WriteLine("There are " + numbers.Count + " items.");

            //items = numbers.GetItems;

            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine(items[i]);
            //}

            //numbers.Clear();
            //Console.WriteLine("There are " + numbers.Count + " items.");


            MyDict<string, string> person1 = new MyDict<string, string>();
            person1.Add("name", "Test");
            person1.Add("surname", "test");
            person1.Add("age", "52");
            person1.Add("job", "tester 1");

            // person1.Remove("age");
            // person1.Clear();

            MyDict<string, string> person2 = new MyDict<string, string>();
            person2.Add("name", "Test 2");
            person2.Add("surname", "test 2");
            person2.Add("age", "53");
            person2.Add("job", "tester 2");

            MyDict<string, string> person3 = new MyDict<string, string>();
            person1.Add("name", "Test 3");
            person1.Add("surname", "test 3");
            person1.Add("age", "51");
            person1.Add("job", "tester 3");

            MyList<MyDict<string, string>> persons = new MyList<MyDict<string, string>>();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);

            // Console.WriteLine("There are " + persons.Count + " people.");

            for(int i = 0; i < persons.GetItems.Length; i++)
            {
                persons.GetItems[i].ListItems();
            }
        }
    }
}