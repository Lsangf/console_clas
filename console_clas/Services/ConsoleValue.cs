namespace console_clas.Services
{
    public class ConsoleValue
    {
        public static string[] ConsoleValueAcceptance()
        {
            while (true)
            {
                string[] result = {"", ""};
                Console.WriteLine("\n====Введите индекс дома от 0====");
                result[0] = Console.ReadLine()!;
                Console.Write("\nДействие\n[1] - Buy\n[2] - Sell\n> ");
                result[1] = Console.ReadLine()!;
                switch (result[1])
                {
                    case "1":
                        result[1] = "true";
                        break;
                    case "2":
                        result[1] = "false";
                        break;
                    default:
                        Console.WriteLine("не верное значение");
                        continue;
                }
                return result;
            }
        }
    }
}
