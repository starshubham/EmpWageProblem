using System;

namespace uc4_EmpWage_SwitchCase
{
    class Program
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        static void Main(string[] args)
        {
            // Constants
            int emp_Wage_Per_Hour = 20;

            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case isFullTime:
                    Console.WriteLine("Employee is present full time.");
                    empHrs = 8;
                    break;
                case isPartTime:
                    Console.WriteLine("Employee is present part time.");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent.");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * emp_Wage_Per_Hour;
            Console.WriteLine("Total Emp Wage: " + empWage);
        }
    }
}
