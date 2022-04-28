using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProgram
{
    //Calculate Wages till a condition of total working hours of 100 or max days os 20 is reached for a month
    //UC5

    class EmpWageForMonth20DaysUC5
    {
        //CONSTANT
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public static void ForMonth()
        {
            //VARIABLE
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //COMPUTATION
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
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
                empWage = empHrs * EMP_RATE_PER_HOUR; //empwage = 8 * 20 = 160
                totalEmpWage += empWage;
                //totalempwage = totalempwage + empwage
                //totalempwage = 0 + 160 = 160
                Console.WriteLine("Emp Wage UC5 : " + empWage);
            }
            Console.WriteLine("Total Emp Wage UC5 : " + totalEmpWage);
        }
    }
}
