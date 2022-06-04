using System;

namespace Repainting
{
    class Program
    {
        static void Main()
        {
            //Input
            int naylonSM = int.Parse(Console.ReadLine());
            int paintL = int.Parse(Console.ReadLine());
            int razreditelL = int.Parse(Console.ReadLine());
            int hoursForWorkers = int.Parse(Console.ReadLine());
            //Action
            double pricePerNaylon = (2 + naylonSM) * 1.50;
            double pricePerPaint = (paintL + (0.10 * paintL)) * 14.50;
            double pricePerRazreditel = razreditelL * 5.00;
            double pricePertorbichki = 0.40;
            double pricePerWorkers = hoursForWorkers * (0.30 * (pricePerNaylon + pricePerPaint + pricePerRazreditel +pricePertorbichki));
            double totalSum = pricePerNaylon + pricePerPaint + pricePerRazreditel + pricePertorbichki + pricePerWorkers;
            //Output
            Console.WriteLine(totalSum);

        }
    }
}