using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeapYearLibrary;

namespace LeapYearTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = LeapYearChecker
                .IsLeapYear(year);

            if (isLeapYear)
                Console.WriteLine("год високосный");
            else
                Console.WriteLine("год не високосный");
        }
    }
}
