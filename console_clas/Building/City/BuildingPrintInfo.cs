using console_clas.Building.House;

namespace console_clas.Building.City
{
    internal class BuildingPrintInfo
    {
        public static void PrintBuildingInfo(BuildingsCity building)
        {
            Console.WriteLine($"Name:       {building.Name}");
            Console.WriteLine($"Координаты: {building.CoordinatesBuildings}");
        }

    }
}
