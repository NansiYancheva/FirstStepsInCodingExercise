using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main()
        {
            //Input
            double depositSum = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());
            //Action
            double endSum = depositSum + depositMonths * ((depositSum * (lihva/100))/12);
            //Output
            Console.WriteLine(endSum);

        }
    }
}