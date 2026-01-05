using console_clas.Entity.Building.House;
using console_clas.Entity.Profile;

namespace console_clas.Services
{
    public class ComparisonPlayerData
    {
        public static void CanPlayerBuyHouse(HouseBase house, PlayersBase People1)
        {
            if (People1.Balance < house.Price)
                house.CanBuy = false;
            house.CanBuy = true;
        }

        public static void CanPlayerSellHouse(HouseBase house, PlayersBase People1)
        {
            if (People1.BuyHouses.Count <= 0)
                house.CanSell = false;
            house.CanSell = true;
        }
    }
}
