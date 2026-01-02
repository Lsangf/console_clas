using console_clas.Building.City;
namespace console_clas.Building.House
{
    public abstract class HouseBase
    {
        private int square;
        private int floors;
        private int rooms;
        private (int x, int y) coordinatesHouse;

        private int price;

        protected HouseBase(int square, int floors, int rooms, (int x, int y) coordinatesHouse)
        {
            Square = square;
            Floors = floors;
            Rooms = rooms;
            CoordinatesHouse = coordinatesHouse;
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

        public void PriceUpdate(IEnumerable<BuildingsCity> City)
        {
           Price = CountingHousePrice.Calculation(this, City);
        }
    }
}
