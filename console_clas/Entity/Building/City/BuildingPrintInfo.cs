namespace console_clas.Entity.Building.City
{
    internal class BuildingPrintInfo
    {
        public static void PrintBuildingInfo(BuildingsCity building)
        {
            Console.WriteLine($"Id:       {building.Id}");
            Console.WriteLine($"Name:       {building.Name}");
            Console.WriteLine($"Координаты: {building.CoordinatesBuildings}");
        }

    }
}
