using System;
    class EmpWagesForMonth
    {
        static void Main(string[] args)
        {
            const int fullTime = 2;
            const int partTime = 1;
            const int empRate = 50;
            const int totalDays = 20;
            int totalWage = 0;
            int empWage = 0;
            int hours = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            for (int day = 0; day < totalDays; day++)
            {
                switch (empCheck)
                {
                    case fullTime:
                        hours = 8;
                        break;
                    case partTime:
                        hours = 4;
                        break;
                    default:
                        hours = 0;
                        break;
                }

            }
        empWage = hours * empRate;
        totalWage += empWage;
            
            Console.WriteLine("Employee Wage new:" + empWage);

        }
    }

