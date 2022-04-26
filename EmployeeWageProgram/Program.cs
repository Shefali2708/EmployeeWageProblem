using System;

namespace EmployeeWageProgram
{
    class Program
    {
        //Calculate emp daily wage
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Constants
            int FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 4;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
