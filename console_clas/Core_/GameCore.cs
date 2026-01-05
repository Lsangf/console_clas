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
            short i = 0;
            bool buyHouse = false;
            bool sellHouse = false;

            List<int> ListPrices = [];

            foreach (var house in houses)
            {
                CountingHousePrice.Calculation(house, buildings);

                HousePrintInfo.PrintHouseInfo(house);

                Console.WriteLine();
                ListPrices.Add(house.Price);
                i++;
            }

            BuildingPrintInfo.PrintBuildingInfo(buildings[0]);
            BuildingPrintInfo.PrintBuildingInfo(buildings[1]);
            BuildingPrintInfo.PrintBuildingInfo(buildings[2]);

            Console.Write($"\nAll Prices: ");
            foreach (var price in ListPrices)
            {
                Console.Write($"{price} $ | ");
            }
            Console.WriteLine("\n");
            PlayerPrintInfo.PrintPlayerInfo(player);






            Console.WriteLine("Нажмите любую клавишу чтобы выйти");
            Console.ReadLine();
        }
    }
}