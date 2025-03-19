namespace task_10_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40, 50 };

            Console.Write("Введите число для поиска: ");
            int number = int.Parse(Console.ReadLine());

            int index = FindIndex(array, number);

            if (index != -1)
            {
                Console.WriteLine($"Элемент найден на индексе: {index}");
            }
            else
            {
                Console.WriteLine("Элемент не найден.");
            }
        }

        static int FindIndex(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}
