namespace console_clas.Entity.Building.City
{
    public abstract class BuildingsCity : GameEntity
    {
        private string name;
        private (int x, int y) coordinatesBuildings;
        private int distancePriceFactorFor1000m;

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (value == null) 
                    throw new ArgumentException("Имя не может быть пустым");
                this.name = value;
            }
        }

        public (int x, int y) CoordinatesBuildings
        {
            get { return this.coordinatesBuildings; }
            protected set
            {
                if (value.x < 0 || value.y < 0) 
                    throw new ArgumentException("Координаты не могут быть отрицательными");
                this.coordinatesBuildings = value;
            }
        }

        public int DistancePriceFactorFor1000m
        {
            get { return distancePriceFactorFor1000m; }
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Коэффициент не может быть отрицательным");
                distancePriceFactorFor1000m = value;
            }
        }

        protected BuildingsCity((int x, int y) coordinatesBuildings)
        {
            CoordinatesBuildings = coordinatesBuildings;
        }
    }
}
