namespace console_clas.Entity.Building.City
{
    public class Metro : BuildingsCity
    {
        public Metro((int x, int y) coordinatesBuildings) : base(coordinatesBuildings)
        {
            Name = "Metro";
            DistancePriceFactorFor1000m = 15;
        }
    }
}
