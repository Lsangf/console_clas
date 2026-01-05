using console_clas.Entity.Building.City;
using console_clas.Entity.Building.House;
using console_clas.Entity.Profile;

namespace console_clas.Services
{
    internal class PrintAllInfoGame
    {
        public static void PrintInfoGame(PlayersBase player, List<HouseBase> houses, BuildingsCity[] buildings)
        {
            Console.WriteLine("----- Информация об игроке -----");
            PlayerPrintInfo.PrintPlayerInfo(player);
            Console.WriteLine();
            Console.WriteLine("----- Информация о домах -----");
            foreach (var house in houses)
            {
                HousePrintInfo.PrintHouseInfo(house);
                Console.WriteLine();
            }
            Console.WriteLine("----- Информация о зданиях города -----");
            foreach (var building in buildings)
            {
                BuildingPrintInfo.PrintBuildingInfo(building);
                Console.WriteLine();
            }
        }
    }
}
