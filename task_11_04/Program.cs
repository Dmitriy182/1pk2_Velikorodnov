namespace task_11_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double average = Calculate(1, 2, 3, 4, 5);
            Console.WriteLine($"Среднее значение: {average}");
        }

        static double Calculate(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым.");
            }

            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}
