using console_clas.Entity.Profile;

namespace console_clas.Building.House
{
    public class ComparisonPlayerData
    {
        public static bool CanPlayerBuyHouse(HouseBase house, Players People1)
        {
            if (People1.Balance < house.Price)
                return false;
            return true;
        }

        public static bool CanPlayerSellHouse(HouseBase house, Players People1)
        {
            if (People1.BuyHouses.Count <= 0)
                return false;
            return true;
        }
    }
}
