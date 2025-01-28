namespace Task_04_08
{
    internal class Program
    {
        /* Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
 которых равны */
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); 
            }

            
            Console.WriteLine("Сгенерированный массив:");
            Console.WriteLine(string.Join(", ", numbers));
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (countMap.ContainsKey(number))
                {
                    countMap[number]++;
                }
                else
                {
                    countMap[number] = 1;
                }
            }
            int pairsCount = 0;
            foreach (var count in countMap.Values)
            {
                if (count > 1)
                {
                    pairsCount += (count * (count - 1)) / 2; 
                }
            }

           
            Console.WriteLine($"Количество пар элементов с одинаковыми значениями: {pairsCount}");
        }
    }
}