using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProgram
{
    class EmpWageUC2
    {
        //Calculate Daily Employee Wage
        //UC2
        public static void EmployeeWage()
        {
            //CONSTANT
            int FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //VARIABLES
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //COMPUTATION
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            //empWage = 12 * 20 = 240
            //empwage = 240
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
