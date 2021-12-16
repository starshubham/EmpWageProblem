using System;

// Calculating Wages for a Month assuming 20 Working Days in a Month

namespace uc5_WageForMonth
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDays = 20;
        static void Main(string[] args)
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            // Computation
            for(int day = 0; day <numOfWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
            }
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
