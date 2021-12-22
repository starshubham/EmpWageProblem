using System;

/*
UC11 - Ability to manage Employee Wage of multiple companies using API approach
UC12 - Refactor to have list of multiple companies to manage Employee Wage.
UC13 - Store the Daily Wage along with the Total Wage.
UC14 - Ability to get the Total Wage when queried by Company.
*/

namespace FinalSolutionForUC11ToUC14
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.addCompanyEmpWage("TCS", 15, 3, 15);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("\nTotal Employee Wage for DMart compnay : " + empWageBuilder.getTotalWage("DMart"));
            Console.WriteLine("Total Employee Wage for Reliance compnay : " + empWageBuilder.getTotalWage("Reliance"));
            Console.WriteLine("Total Employee Wage for TCS compnay : " + empWageBuilder.getTotalWage("TCS"));
        }
    }
}
