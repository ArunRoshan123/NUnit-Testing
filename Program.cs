using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeCalculator g1 = new GradeCalculator();

            Console.WriteLine("Enter percentage ");
            var percentage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Student grade : {g1.GetGradeByPercentage(percentage)}");

        }
    }
}
