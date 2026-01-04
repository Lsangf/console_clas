using console_clas.Building.City;
using console_clas.Building.House;
using console_clas.Entity.Profile;

namespace console_clas.Core_
{
    public class GameCore
    {
        public static void Main(List<HouseBase> houses, BuildingsCity[] buildings, PlayersBase player)
        {
            short i = 0;

            List<int> ListPrices = [];

            foreach (var house in houses)
            {
                house.PriceUpdate(buildings);

                house.PrintInfo();

                Console.WriteLine();
                ListPrices.Add(house.Price);
                i++;
            }

            buildings[0].PrintInfo();
            buildings[1].PrintInfo();
            buildings[2].PrintInfo();

            Console.Write($"\nAll Prices: ");
            foreach (var price in ListPrices)
            {
                Console.Write($"{price} $ | ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Id: {player.Id} Name: {player.Name} Balance: {player.Balance} $\n");
            Console.WriteLine("Нажмите любую клавишу чтобы выйти");
            Console.ReadLine();
        }
    }
}
