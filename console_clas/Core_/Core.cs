using console_clas.Building.City;
using console_clas.Building.House;

namespace console_clas.Core_
{
    internal class Core
    {
        private static readonly Random random = new();
        static short i = 0;
        private const byte CountHouse = 12;
        private const byte MinSquare = 40;
        private const short MaxSquare = 401;
        private const byte MinCoordinates = 0;
        private const short MaxCoordinates = 1001;

        public static void Main()
        {
            while (true)
            {
                try
                {
                    List<HouseBase> houses = [];

                    GasStation gas = new((random.Next(MinCoordinates, MaxCoordinates), random.Next(MinCoordinates, MaxCoordinates)));
                    Market market = new((random.Next(MinCoordinates, MaxCoordinates), random.Next(MinCoordinates, MaxCoordinates)));
                    Metro metro = new((random.Next(MinCoordinates, MaxCoordinates), random.Next(MinCoordinates, MaxCoordinates)));

                    BuildingsCity[] buildings = [gas, market, metro];

                    for (int i = 0; i < CountHouse; i++)
                    {
                        houses.Add(CreateHouse());
                    }
                    GameCore.Main(houses, buildings);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.Clear();
                    i++;
                    Console.WriteLine($"=={ex.Message} | {i} ==");
                }
            }
        }

        public static HouseBase CreateHouse()
        {
            while (true) 
            {
                try
                {
                    int square = random.Next(MinSquare, MaxSquare);
                    int x = random.Next(MinCoordinates, MaxCoordinates);
                    int y = random.Next(MinCoordinates, MaxCoordinates);

                    if (square <= 100) return new RealHouse(square, 1, 1, (x, y));
                    if (square <= 200) return new RealHouse(square, 1, 2, (x, y));
                    if (square <= 250) return new RealHouse(square, 2, 3, (x, y));
                    if (square <= 300) return new RealHouse(square, 2, 4, (x, y));
                    return new RealHouse(square, 3, 5, (x, y));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"=={ex.Message}==");
                }
            }
        }
    }
}
