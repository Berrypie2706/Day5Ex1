using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noe;
            Console.WriteLine("Enter Number of employees");
            noe = int.Parse(Console.ReadLine());
            double[][] Emp = new double[noe][];
            for (int i = 0; i < noe; i++)
            {
                Console.WriteLine($"Enter number of working days for Employee {i + 1}");
                int workingDays = int.Parse(Console.ReadLine());
                double[] salaryData = new double[workingDays];
                for (int j = 0; j < workingDays; j++)
                {
                    Console.WriteLine($"Enter salary for Day{j + 1}");
                    double salary = int.Parse(Console.ReadLine());
                    salaryData[j] = salary;
                }
                Emp[i] = salaryData;

            }
            Console.WriteLine("daily salary for employees :");
            for (int i = 0; i < Emp.Length; i++)

            {
                Console.WriteLine($"Salary of employee {i + 1}");
                for (int j = 0; j < Emp[i].Length; j++)
                {
                    Console.WriteLine($"Salary on Day{j + 1}\t" + "\n" + Emp[i][j]);
                }
            }



            Console.ReadKey();
        }
    }
}
