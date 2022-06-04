using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main()
        {
            //Input
            int packetPens = int.Parse(Console.ReadLine());
            int packetMarkers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());
            //Action
            double pricePens = packetPens * 5.80;
            double priceMarkers = packetMarkers * 7.20;
            double priceLiters = liters * 1.20;
            double sumForAllMaterials = pricePens + priceMarkers + priceLiters;
            double discount = percentDiscount / 100.00;
            double endSum = sumForAllMaterials - sumForAllMaterials * discount;
            //Output
            Console.WriteLine(endSum);


        }
    }
}
