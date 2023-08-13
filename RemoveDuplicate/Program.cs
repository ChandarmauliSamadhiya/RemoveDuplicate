using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 5 };
            List<int> uniqueNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (!uniqueNumbers.Contains(num))
                {
                    uniqueNumbers.Add(num);
                }
            }

            Console.WriteLine("Array with duplicates removed:");
            foreach (int num in uniqueNumbers)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
