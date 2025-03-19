namespace task_10_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            int n = int.Parse(Console.ReadLine());
            ArrayGeneration(n);
        }

        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 101); 
                    Console.Write(array[i, j] + "\t"); 
                }
            }
        }
    }
}
