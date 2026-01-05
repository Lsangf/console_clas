using console_clas.Entity.Building.City;
using console_clas.Entity.Building.House;
using console_clas.Entity.Profile;

namespace console_clas.Core_
{
    internal class Core
    {
        private static readonly Random random = new();
        private const byte CountHouse = 12;
        private const byte MinSquare = 40;
        private const short MaxSquare = 401;
        private const byte MinCoordinates = 0;
        private const short MaxCoordinates = 1001;

        public static void Main()
        {
            PlayersBase player = CreatePlayer();
            List<HouseBase> houses = [];

            GasStation gas = new((random.Next(MinCoordinates, MaxCoordinates), random.Next(MinCoordinates, MaxCoordinates)));
            Market market = new((random.Next(MinCoordinates, MaxCoordinates), random.Next(MinCoordinates, MaxCoordinates)));
            Metro metro = new((random.Next(MinCoordinates, MaxCoordinates), random.Next(MinCoordinates, MaxCoordinates)));

            BuildingsCity[] buildings = [gas, market, metro];

            for (int i = 0; i < CountHouse; i++)
            {
                houses.Add(CreateHouse());
            }
            GameCore.Main(houses, buildings, player);

        }

        public static HouseBase CreateHouse()
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

        public static PlayersBase CreatePlayer()
        {
            byte lengthName = 5;
            string name = GenerateRandomName(lengthName);

            return new RealPlayer(name, 100000, []);

        }

        public static string GenerateRandomName(byte length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            char[] buffer = new char[length];

            for (int i = 0; i < length; i++)
            {
                buffer[i] = chars[random.Next(chars.Length)];
            }

            return new string(buffer);
        }
    }
}
