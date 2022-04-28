using System;

namespace EmployeeWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            //Check emp is present or abesent
            EmpAttendanceUC1.EmployeeAttendance();

            //Calculate Daily Employee Wage
            EmpWageUC2.EmployeeWage();
        }
    }
}
