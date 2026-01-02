using console_clas.Building.City;
using console_clas.Building.House;

namespace console_clas.Core_
{
    public class GameCore
    {
        public static void Main(List<HouseBase> houses, BuildingsCity[] buildings)
        {
            short i = 0;

            List<int> ListPrices = [];

            foreach (var house in houses)
            {
                Console.WriteLine($"Дом {i} | Площадь: {house.Square} Этажей: {house.Floors} Комант: {house.Rooms} Координаты: {house.CoordinatesHouse}");

                house.PriceUpdate(buildings);

                Console.WriteLine($"Цена: {house.Price} $");
                Console.WriteLine();
                ListPrices.Add(house.Price);
                i++;
            }
            Console.WriteLine($"{buildings[0].Name}, {buildings[0].DistancePriceFactorFor1000m}, {buildings[0].CoordinatesBuildings}");
            Console.WriteLine($"{buildings[1].Name}, {buildings[1].DistancePriceFactorFor1000m}, {buildings[1].CoordinatesBuildings}");
            Console.WriteLine($"{buildings[2].Name}, {buildings[2].DistancePriceFactorFor1000m}, {buildings[2].CoordinatesBuildings}");

            Console.Write($"All Prices: ");
            foreach (var price in ListPrices)
            {
                Console.Write($"{price} $ | ");
            }
            Console.WriteLine("\nНажмите любую клавишу чтобы выйти");
            Console.ReadLine();
        }
    }
}
