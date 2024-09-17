using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Common;
namespace Tutorial
{
    // enum
    enum Alpha { A, B, C, D, E };
    class Program
    {
        // pass by ref 
        public static void swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
        // there is pass by out -> it's used if I want the func to write first
        public static void total(int a , int b, out int s ,out int m)
        {
            s = a + b;
            m = a * b; 
        }
        public static void Mainv1(string[] args)
        {
            StringBuilder sb = new StringBuilder("hello cc#");
            sb.Remove(6, 1);
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetType()); // type

            // ArrayList
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            List<int> mapped = list.Select(x => x * 2).ToList(); // Map function
            Console.WriteLine("############");
            foreach (int i in mapped)
            {
                Console.WriteLine(i);
            }
            List<int> filtered = list.Where(x => x > 2).ToList(); // Filter function
            Console.WriteLine("############");
            foreach (int i in filtered)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("############");

            int sum = list.Aggregate((acc, n) => acc + n); // Reduce

            Console.WriteLine(sum);

            // Dict
            Dictionary<string, string> dict = new Dictionary<string, string> {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key3", "value3" }
            };

            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.WriteLine(new string('*', 50));

            // convert str to int
            string StrNum = "1234";
            Console.WriteLine((Convert.ToInt16(StrNum)).GetType());

            // Sorting
            string[] names = { "Ahmed", "Amir", "Mohamed", "Amen", "Adam", "Shahd" };
            List<string> NamesList = names.ToList(); // convert arr to list
            NamesList.Sort((x, y) => x.Length - y.Length); // sorting like js
            foreach (string i in NamesList)
                System.Console.WriteLine(i);
            Console.WriteLine(new string('*', 30));
            // sorting with OrderBy , ThenBy
            var sortedByLengthThenLastLetter = names.OrderBy(p => p.Length).ThenBy(p => p[p.Length - 1]).ThenByDescending(p => p[0]).ToList();
            foreach (string i in sortedByLengthThenLastLetter)
                System.Console.WriteLine(i);
            Console.WriteLine(new string('*', 30));

            // Binary Search
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 6;
            int result = Array.BinarySearch(arr, target);
            Console.WriteLine($"The target {target} is found at index {result}");

            
            int a = 5, b = 6;
            swap(ref a, ref b);
            Console.WriteLine($"a :{a} ,b:{b}");

            total(a, b, out int s, out int m);
            Console.WriteLine($"sum :{s}, multiply: {m}");

            // stop watch
            Stopwatch MyS = new Stopwatch();
            MyS.Start();
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"{i}");
            MyS.Stop();
            Console.WriteLine(MyS);


            // struct
            //TypeA rr = new();
            //rr.Print();

            PhoneBook phoneBook = new PhoneBook(5);
            phoneBook[4] = "mazen";
            phoneBook["mazen"] = 22;
            phoneBook.Print();


            // Stop Terminal
            Console.Read();


        }
    }
}