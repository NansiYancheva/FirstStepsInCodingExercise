using System;

namespace Basketball
{
    class Program
    {
        static void Main()
        {
//Input
int annualTax = int.Parse(Console.ReadLine());
            //Action
            double pricePerShoes = annualTax - (0.40 * annualTax);
            double pricePerClothes = pricePerShoes - (0.20 * pricePerShoes);
            double pricePerBall = 0.25 * pricePerClothes;
            double pricePerAccessories = 0.20 * pricePerBall;
            //Output
            Console.WriteLine(annualTax + pricePerAccessories + pricePerBall + pricePerClothes + pricePerShoes);
        }
    }
}
