using console_clas.Entity.Building.City;
using console_clas.Entity.Building.House;
using console_clas.Entity.Profile;
using console_clas.Services;

namespace console_clas.Core_
{
    public class GameCore
    {
        public static void GameRun(List<HouseBase> houses, BuildingsCity[] buildings, PlayersBase player)
        {
            while (true)
            {
                short i = 0;
                // BuySell = true - buy, false - sell
                bool BuySell;
                byte indexHouse;
                string[] acceptedData;

                List<int> ListPrices = [];

                foreach (var house in houses)
                {
                    CountingHousePrice.Calculation(house, buildings);
                    ComparisonPlayerData.CanPlayerBuyHouse(house, player);
                    ComparisonPlayerData.CanPlayerSellHouse(house, player);
                    ListPrices.Add(house.Price);
                    i++;
                }

                PrintAllInfoGame.PrintInfoGame(player, houses, buildings);

                Console.Write($"\nAll Prices: ");
                foreach (var price in ListPrices)
                {
                    Console.Write($"{price} $ | ");
                }
                Console.WriteLine("\n");

                acceptedData = ConsoleValue.ConsoleValueAcceptance(houses.Count);
                BuySell = Convert.ToBoolean(acceptedData[1]);
                indexHouse = Convert.ToByte(acceptedData[0]);

                SellBuyHouse.BuySell(player, houses, BuySell, indexHouse);

                PrintAllInfoGame.PrintInfoGame(player, houses, buildings);

                Console.WriteLine("Q - Выход");
                if (Console.ReadLine()!.ToUpper() == "Q")
                {
                    break;
                }
            }
        }
    }
}