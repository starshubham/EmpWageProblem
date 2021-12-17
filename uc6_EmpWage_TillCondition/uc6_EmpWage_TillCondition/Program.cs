using System;

// Calculate Wages till a condition of totalworking hours of 100
// or max days is  20 is reached for a month

namespace uc6_EmpWage_TillCondition
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDays = 20;
        public const int maxHrsInMonth = 100;

        static void Main(string[] args)
        {
            // Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            // Computation
            while (totalEmpHrs < maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case isPartTime: 
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Hrs: " + totalEmpHrs);
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
