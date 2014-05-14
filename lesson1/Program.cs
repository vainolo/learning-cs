using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // simple variables;
            int a = 1;
            bool b = true;
            String c = "Something";
            var d = 34.5;
            Console.WriteLine("a = {0} is an integer, b = {1} is a boolean, c = {2} is a string, d = {3} is a var", a, b, c, d);
            Console.ReadLine();

            // Arrays
            int[] arr1 = {1,3};
            int[] arr2 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i is {0}.", i);
            }
            Console.ReadLine();

            int j = 5;
            while (j >= 0)
            {
                Console.WriteLine("j is {0}.", j);
                j--;
            }
            Console.ReadLine();

            int k = 5;
            do
            {
                Console.WriteLine("k is {0}.", k);
                k--;
            } while (k >= 0);
            Console.ReadLine();

            int[] l = { 1, 2, 3, 4, 5 };
            foreach (var item in l)
            {
                Console.WriteLine("item is {0}.", item);
            }
            Console.ReadLine();

        }
    }
}
    