namespace Task_04_09
{
    internal class Program
    {
        static void Main()
        {
            // Исходный массив
            int[] array = { 1, 9, 3, 9, 4, 5, 3, 6, 2, 5 };

            // Словарь для подсчета вхождений
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Подсчет вхождений элементов
            foreach (int number in array)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            // Вывод уникальных элементов
            Console.WriteLine("Уникальные элементы:");
            foreach (var pair in counts)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}