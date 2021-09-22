using System;
namespace Day4
{
    class EmpTime
    {
        static void Main(string[] args)
        {
            int fullTime = 2;
            int partTime = 1;
            int empRate = 50;

            int empWage = 0;
            int hours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == fullTime)
                hours = 8;
            else if (empCheck == partTime)
                hours = 4;
            else
                hours = 0;
            empWage = empRate * hours;
            Console.WriteLine("Employee Wage :" + empWage);

        }
    }
}
