using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCTURE
{
    using System;
        struct Employee
        {
            public int Id;
            public string Name;

            public void Display()
            {
            Console.WriteLine("\nEmployee Name: " + Name);
            Console.WriteLine("Employee ID: " + Id);
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Tufail Haider \t\t Reg No:FA22-BCS-014");

            Employee emp;

            emp.Name = "Tufail Haider";
            emp.Id= 101;

            emp.Display();
        }

    }
}
