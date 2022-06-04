using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main()
        {
            //Input
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());   
            int veggieMenu = int.Parse(Console.ReadLine());
            //Action
            double pricePerChicken = chickenMenu * 10.35;
            double pricePerFish = fishMenu * 12.40;
            double pricePerVeggie = veggieMenu * 8.15;
            double totalSumPerMenues = pricePerChicken + pricePerFish + pricePerVeggie;
            double pricePerDesert = 0.20 * totalSumPerMenues;
            double pricePerDelivery = 2.50;
            //Output
            Console.WriteLine(pricePerDelivery+pricePerDesert+totalSumPerMenues);

        }
    }
}

