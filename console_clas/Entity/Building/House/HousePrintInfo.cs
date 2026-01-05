namespace console_clas.Entity.Building.House
{
    public class HousePrintInfo
    {
        public static void PrintHouseInfo(HouseBase house)
        {
            Console.WriteLine($"ID:         {house.Id}");
            Console.WriteLine($"Площадь:       {house.Square}");
            Console.WriteLine($"Этажей:         {house.Floors}");
            Console.WriteLine($"Комнат:         {house.Rooms}");
            Console.WriteLine($"Координаты: {house.CoordinatesHouse}");
            Console.WriteLine($"Price:      {house.Price} $");
        }
    }
}
