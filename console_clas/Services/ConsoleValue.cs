namespace console_clas.Services
{
    public class ConsoleValue
    {
        public static string[] ConsoleValueAcceptance(int Length)
        {
            while (true)
            {
                try 
                {
                    string[] result = { "", "" };
                    Console.WriteLine("\n====Введите индекс дома от 0====");
                    int resultString = Convert.ToInt32(Console.ReadLine());

                    if (resultString > Length || resultString < 0)
                    {
                        Console.WriteLine("Недопустимое значение, индекс должен быть равен или больше длине списка");
                        continue;
                    }
                    result[0] = resultString.ToString();

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
                catch (FormatException)
                {
                    Console.WriteLine("Недопустимое значение, только числа");
                    continue;
                }
            }
        }
    }
}
