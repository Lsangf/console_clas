using console_clas.Building.City;

namespace console_clas.Building.House
{
    public class CountingHousePrice
    {
        public static int Calculation(HouseBase House, IEnumerable<BuildingsCity> City)
        {
            int resultPriceDistant = 0;
            foreach (var buildings in City)
            {
                resultPriceDistant += CalculationDistant(House, buildings) * buildings.DistancePriceFactorFor1000m;
            }
            int result = (House.Square * 3500) + (CalculationDistantHouse(House) * 20) + resultPriceDistant;
            return result;
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
