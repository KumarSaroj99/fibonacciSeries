using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in the Fibonacci series: ");
            int terms = Convert.ToInt32(Console.ReadLine());
            GenerateFibonacciSeries(terms);
            Console.ReadLine();
        }

        static void GenerateFibonacciSeries(int n)
        {
            int first = 0, second = 1, next;

            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");
                next = first + second;
                first = second;
                second = next;
            }
            
        }
    }
}
