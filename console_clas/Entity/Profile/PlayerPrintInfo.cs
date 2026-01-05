namespace console_clas.Entity.Profile
{
    public class PlayerPrintInfo
    {
        public static void PrintPlayerInfo(PlayersBase player)
        {
            Console.WriteLine($"ID:         {player.Id}");
            Console.WriteLine($"Имя:        {player.Name}");
            Console.WriteLine($"Балланс:    {player.Balance} $");
        }
    }
}
