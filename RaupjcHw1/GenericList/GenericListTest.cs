using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListTest
    {
        public static void ListExample(GenericList<int> listOfIntegers)
        {
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5); //[2 ,3 ,4]
            Console.WriteLine(listOfIntegers.Count); // 3
            Console.WriteLine(listOfIntegers.Remove(100)); // false
            Console.WriteLine(listOfIntegers.RemoveAt(5)); // false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0
        }

        public static void ListExampleDouble(GenericList<double> listOfDoubles)
        {
            listOfDoubles.Add(1.1); // [1.1]
            listOfDoubles.Add(2.2); // [1.1 ,2.2]
            listOfDoubles.Add(3.3); // [1.1 ,2.2 ,3.3]
            listOfDoubles.Add(4.4); // [1.1 ,2.2 ,3.3 ,4.4]
            listOfDoubles.Add(5.5); // [1.1 ,2.2 ,3.3 ,4.4 ,5.5]
            listOfDoubles.Add(6.6);
            listOfDoubles.RemoveAt(0); // [2.2 ,3.3 ,4.4 ,5.5,6.6]
            listOfDoubles.Remove(5.5); //[2.2, 3.3, 4.4, 6.6]
            Console.WriteLine(listOfDoubles.Count); // 4
            Console.WriteLine(listOfDoubles.Remove(100)); // false
            Console.WriteLine(listOfDoubles.RemoveAt(5)); // false
            listOfDoubles.Clear(); // []
            Console.WriteLine(listOfDoubles.Count); // 0
            Console.Read();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting generic list test..");

            GenericList<int> list = new GenericList<int>(5);
            ListExample(list);

            GenericList<double> doubleList = new GenericList<double>(5);
            ListExampleDouble(doubleList);

        }
    }
}
