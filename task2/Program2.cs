class Task2
{
    static void Main(string[] args)
    {
        getEvenNumber(10);
    }

    static int getEvenNumber(int arraySize)
    {
        int[] numbers = new int[arraySize];
        Random random = new Random();
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000); //100 - 999
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Массив {string.Join(",", numbers)}");
        Console.WriteLine($"Количество чётных чисел в массиве. {count}");
        return count;
    }
}