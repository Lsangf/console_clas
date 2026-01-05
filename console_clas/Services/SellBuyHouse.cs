using console_clas.Entity.Building.House;
using console_clas.Entity.Profile;

namespace console_clas.Services
{
    public class SellBuyHouse
    {
        public static void BuySell(PlayersBase player, List<HouseBase> houses, bool BuySell, byte indexHouse)
        {

            if (BuySell && houses[indexHouse].CanBuy)
            {
                player.Balance -= houses[indexHouse].Price;
                player.BuyHouses.Add(houses[indexHouse]);
                Console.WriteLine($"{player.Name} купил дом {houses[indexHouse].Id} за {houses[indexHouse].Price} $.");
            }
            else if (!BuySell && houses[indexHouse].CanSell)
            {
                player.Balance += houses[indexHouse].Price;
                player.BuyHouses.Remove(houses[indexHouse]);
                Console.WriteLine($"{player.Name} продал дом {houses[indexHouse].Id} за {houses[indexHouse].Price} $.");
            }
            else
            {
                Console.WriteLine($"{player.Name} дом {houses[indexHouse].Id} за {houses[indexHouse].Price} $.\nОШИБКА");
            }
        }

    }
}
