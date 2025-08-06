using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Tufail Haider \t\t Reg No: FA22-BCS-014 ");

            int[,,] tempretureReadings = new int[3, 4, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"\nEnter the Tempreture Data for Location {i+1}, Day {j+1} ");

                    Console.Write("Morning Data: ");
                    tempretureReadings[i, j, 0]=Convert.ToInt32(Console.ReadLine());

                    Console.Write("Evening Data: ");
                    tempretureReadings[i,j,1]=Convert.ToInt32(Console.ReadLine());
                    
                }
            }

            Console.WriteLine("\nTempreture Readings: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nLocation {i+1}:");
                for(int j = 0;j < 4; j++)
                {
                    Console.Write($"\n Day{j+1}: Morning Tempreture= {tempretureReadings[i,j,0]}");
                    Console.Write($"\t Evening Tempreture= {tempretureReadings[i,j,1]}");
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int totalTempreture = 0;
                for (int j = 0; j < 4; j++)
                {
                    totalTempreture = totalTempreture + tempretureReadings[i, j, 0];
                    totalTempreture = totalTempreture + tempretureReadings[i, j, 1];
                }

                double AverageTempreture = (double)totalTempreture / (4*2);
                Console.WriteLine($"\n\nAverage temperature for Location {i+ 1}: {AverageTempreture}");
            }
        }
    }
}
