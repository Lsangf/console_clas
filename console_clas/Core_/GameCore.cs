using console_clas.Building.City;
using console_clas.Building.House;

namespace console_clas.Core_
{
    public class GameCore
    {
        public static void Main(List<HouseBase> houses, BuildingsCity[] buildings)
        {
            foreach (var house in houses)
            {
                Console.WriteLine($"Площадь: {house.Square} Этажей: {house.Floors} Комант: {house.Rooms} Координаты: {house.CoordinatesHouse}");

                house.PriceUpdate(buildings);

                Console.WriteLine($"Цена: {house.Price} $");
                Console.WriteLine();
            }
            Console.WriteLine($"{buildings[0].Name}, {buildings[0].DistancePriceFactorFor1000m}, {buildings[0].CoordinatesBuildings}");
            Console.WriteLine($"{buildings[1].Name}, {buildings[1].DistancePriceFactorFor1000m}, {buildings[1].CoordinatesBuildings}");
            Console.WriteLine($"{buildings[2].Name}, {buildings[2].DistancePriceFactorFor1000m}, {buildings[2].CoordinatesBuildings}");
        }

    }
}
