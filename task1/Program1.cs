class Task1
{
    static void Main(string[] args)
    {
        Console.Write("Введите число или 'q' для выхода: ");
        InputNumber();
    }
    static void InputNumber()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            int number;
            if (int.TryParse(input, out number))
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                if (sum % 2 == 0)
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
            }
        }
    }
}