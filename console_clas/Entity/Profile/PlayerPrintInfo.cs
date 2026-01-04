using console_clas.Building.House;

namespace console_clas.Entity.Profile
{
    public class PlayerPrintInfo
    {
        public static void PrintHouseInfo(PlayersBase player)
        {
            Console.WriteLine($"ID:         {player.Id}");
            Console.WriteLine($"Имя:        {player.Name}");
            Console.WriteLine($"Балланс:    {player.Balance} $");
        }
    }
}
