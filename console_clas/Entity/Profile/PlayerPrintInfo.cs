namespace console_clas.Entity.Profile
{
    public class PlayerPrintInfo
    {
        public static void PrintPlayerInfo(PlayersBase player)
        {
            Console.WriteLine($"ID:         {player.Id}");
            Console.WriteLine($"Имя:        {player.Name}");
            Console.WriteLine($"Балланс:    {player.Balance} $");
            Console.WriteLine($"Купленные Дома: ");
            if (player.BuyHouses.Count == 0)
            {
                Console.WriteLine(" - Нет купленных домов");
                return;
            }
            else
            {
                foreach (var house in player.BuyHouses)
                {
                    Console.WriteLine($" - {house.Id} за {house.Price} $");
                }
            }
        }   
    }
}
