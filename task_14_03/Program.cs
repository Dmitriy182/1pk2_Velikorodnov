namespace task_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите неотрицательное целое число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Факториал определен только для неотрицательных чисел.");
            }
            else
            {
                long result = Factorial(number);
                Console.WriteLine($"Факториал числа {number} равен {result}");
            }
        }

        
        static long Factorial(int n)
        {
            if (n == 0) 
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}