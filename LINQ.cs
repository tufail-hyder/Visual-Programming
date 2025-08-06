using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Opertaions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Tufail Haider \t\t Reg No:FA22-BCS-014\n");
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the Values {i + 1}:");
                int Value = Convert.ToInt32(Console.ReadLine());
                list.Add(Value);
            }

            Console.WriteLine("\nThe Values in List are: " + string.Join(", ", list));

            list.Sort();
            Console.WriteLine("\nSorted List in Ascending Order: " + string.Join(", ", list));

            int maxValue = list.Max();
            Console.WriteLine("\nMaximum Value in List is: "+maxValue);
            
            int minValue = list.Min();
            Console.WriteLine($"\nMinimum Value in list is: "+minValue);

            list.Reverse();
            Console.WriteLine("\nList in Descending Order: " + string.Join(", ", list));


        }
    }
}
