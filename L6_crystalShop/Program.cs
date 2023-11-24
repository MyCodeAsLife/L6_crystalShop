using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_crystalShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minPriceCrystal = 10;
            int maxPriceCrystal = 16;
            int pricePerCrystal = random.Next(minPriceCrystal, maxPriceCrystal);
            int userMoney = 0;
            int userCrystals = 0;
            int desiredCountOfCrystals = 0;

            Console.Write("Сколько у вас монет?: ");
            userMoney = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Приветствуем в нашем магазине.\nСегодня цена за кристалл составляет: {pricePerCrystal}\n");
            Console.Write("Сколько кристаллов вы желаете приобрести?: ");
            desiredCountOfCrystals = Convert.ToInt32(Console.ReadLine());

            userMoney -= desiredCountOfCrystals * pricePerCrystal;
            userCrystals += desiredCountOfCrystals;

            Console.WriteLine($"\nУ вас монет: {userMoney}, кристаллов: {userCrystals}\n");
        }
    }
}
