using console_clas.Building.City;
using console_clas.Entity.Profile;
using console_clas.Interface;

namespace console_clas.Building.House
{
    public abstract class HouseBase : IPrintInfo
    {
        private string idHouse;
        private int square;
        private int floors;
        private int rooms;
        private (int x, int y) coordinatesHouse;
        private bool canBuy;
        private bool canSell;

        private int price;

        protected HouseBase(string idHouse, int square, int floors, int rooms, (int x, int y) coordinatesHouse)
        {
            IdHouse = idHouse;
            Square = square;
            Floors = floors;
            Rooms = rooms;
            CoordinatesHouse = coordinatesHouse;
        }

        public string IdHouse
        {
            get { return this.idHouse; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentException("Id дома не может быть пустым");
                this.idHouse = value;
            }
        }

        public int Square
        {
            get { return this.square; }
            protected set
            {
                if (value < 40) 
                    throw new ArgumentException("Площадь не может быть меньше 40m²");
                this.square = value;
            }
        }

        public int Floors
        {
            get { return this.floors; }
            protected set
            {
                if (value < 1) 
                    throw new ArgumentException("Этажи не могут быть равны 0 или отрицательному числу");
                this.floors = value;
            }
        }

        public int Rooms
        {
            get { return this.rooms; }
            protected set
            {
                if (value < 1)
                    throw new ArgumentException("Комнаты не могут быть равны 0 или отрицательному числу");
                this.rooms = value;
            }
        }

        public (int x, int y) CoordinatesHouse
        {
            get { return this.coordinatesHouse; }
            protected set
            {
                if (value.x < 0 || value.y < 0)
                    throw new ArgumentException("Координаты не могут быть отрицательными");
                this.coordinatesHouse = value;
            }
        }

        public int Price
        {
            get { return this.price; }
            protected set
            {
                if (value < 0) 
                    throw new ArgumentException("Цена не может быть отрицательной");
                this.price = value;
            }
        }

        public bool CanBuy 
        {
            get { return canBuy; } 
            set { canBuy = value; }
        }

        public bool CanSell 
        { 
            get { return canSell; } 
            set { canSell = value; } 
        }

        public void PriceUpdate(IEnumerable<BuildingsCity> City)
        {
           Price = CountingHousePrice.Calculation(this, City);
        }

        public void UpdateCanBuySell(PlayersBase People1)
        {
            CanBuy = ComparisonPlayerData.CanPlayerBuyHouse(this, People1);
            CanSell = ComparisonPlayerData.CanPlayerSellHouse(this, People1);
        }

        public void PrintInfo()
        {
            HousePrintInfo.PrintHouseInfo(this);
        }
    }
}
