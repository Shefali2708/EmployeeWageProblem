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

            //Add Part time Employee & Wage
            EmpPartTimeUC3.EmployeePartTime();

            //Solving using Case Statement
            EmpWithSwitchCaseUC4.EmpSwitchCase();

            //Calculate Wages till a condition of total working hours of 100 or max days os 20 is reached for a month
            EmpWageForMonth20DaysUC5.ForMonth();

        }
    }
}
