using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProgram
{
    class EmpAttendance
    {
        //Check emp is present or abesent
        //UC 1
        public static void EmployeeAttendance()
        {
            //CONSTANT
            int FULL_TIME = 1;
            Random random = new Random();

            //COMPUTATION
            int empCheck = random.Next(0, 2);
            if(empCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
