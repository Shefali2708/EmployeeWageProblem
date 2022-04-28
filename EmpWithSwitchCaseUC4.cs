using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProgram
{
    class EmpWithSwitchCaseUC4
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;

        public static void EmpSwitchCase()
        {
            //VARIABLE
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            //COMPUTATION
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case FULL_TIME:
                    empHrs = 8;
                    break;
                case PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            //empwage = 4 * 20 = 80
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
