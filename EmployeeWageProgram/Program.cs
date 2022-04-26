using System;

namespace EmployeeWageProgram
{
    class Program
    {
        //UC3 Add part time emp and wage
        static void Main(string[] args)
        {
            //Constants
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
