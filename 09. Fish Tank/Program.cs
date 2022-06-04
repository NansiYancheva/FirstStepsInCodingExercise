using System;

namespace FishTank
{
    class Program
    {
        static void Main()
        {
            //Input
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            //Action
            int obem = length * width * height;
            double obemLiters = obem / 1000.00;
            double capacity = percentage / 100.00;
            double totalliters = obemLiters * (1 - capacity);
            //Output
            Console.WriteLine(totalliters);



        }
    }
}