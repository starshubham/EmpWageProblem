using System;

namespace uc1Prob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IsPresent = 1;
            Random ran = new Random();
            int CheckEmployee = ran.Next(0, 2);

            if (IsPresent == CheckEmployee)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
