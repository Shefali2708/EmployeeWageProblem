using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProgram
{
    class EmpPartTimeUC3
    {
        //Add Part time Employee & Wage
        //UC3
        public static void EmployeePartTime()
        {
            //CONSTANT
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //VARIABLE
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //COMPUTATION
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
            //empWage = 8 * 20;
            //empWage = 160
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
