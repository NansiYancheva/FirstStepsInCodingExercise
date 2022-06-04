using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main()
        {
            //Input
            int pagesBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());   
            int days = int.Parse(Console.ReadLine());
            //Action
            int pagesPerDay = pagesBook / days;
            int hoursPerDay = pagesPerDay / pagesPerHour;
            //Output
            Console.WriteLine(hoursPerDay);

        }
    }
}

