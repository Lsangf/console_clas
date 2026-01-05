using console_clas.Entity.Building.City;
using console_clas.Entity.Building.House;

namespace console_clas.Services
{
    public class CountingHousePrice
    {
        private const short BasePricePerSquareMeter = 3500;
        private const byte PricePerMeterFromCityCenter = 20;

        public static void Calculation(HouseBase House, IEnumerable<BuildingsCity> City)
        {
            int resultPriceDistant = 0;
            foreach (var buildings in City)
            {
                resultPriceDistant += CalculationDistant(House, buildings) * buildings.DistancePriceFactorFor1000m;
            }
            int result = (House.Square * BasePricePerSquareMeter) + (CalculationDistantHouse(House) * PricePerMeterFromCityCenter) + resultPriceDistant;
            House.Price = result;
        }

        public static int CalculationDistant(HouseBase House, BuildingsCity City)
        {
            int resultDistant = (int)Math.Round(Math.Sqrt(Math.Pow(House.CoordinatesHouse.x - City.CoordinatesBuildings.x, 2) + Math.Pow(House.CoordinatesHouse.y - City.CoordinatesBuildings.y, 2)));
            return resultDistant;
        }

        public static int CalculationDistantHouse(HouseBase House)
        {
            int resultDistantHouse = (int)Math.Round(Math.Sqrt(Math.Pow(House.CoordinatesHouse.x, 2) + Math.Pow(House.CoordinatesHouse.y, 2)));
            return resultDistantHouse;
        }
    }
}
