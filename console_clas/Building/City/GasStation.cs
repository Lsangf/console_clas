namespace console_clas.Building.City
{
    public class GasStation : BuildingsCity
    {
        public GasStation((int x, int y) coordinatesBuildings) : base(coordinatesBuildings)
        {
            Name = "GasStation";
            DistancePriceFactorFor1000m = 7;
        }
    }
}
