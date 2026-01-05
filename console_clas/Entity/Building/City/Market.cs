namespace console_clas.Entity.Building.City
{
    public class Market : BuildingsCity
    {
        public Market((int x, int y) coordinatesBuildings) : base(coordinatesBuildings)
        {
            Name = "Market";
            DistancePriceFactorFor1000m = 5;
        }
    }
}
