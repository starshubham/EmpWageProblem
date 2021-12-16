using System;

namespace uc2EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants
            int is_Full_Time = 1;
            int emp_Wage_Per_Hour = 20;

            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            // Computation
            if (empCheck == is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * emp_Wage_Per_Hour;
            Console.WriteLine("Total Emp Wage: " + empWage);
        }
    }
}
