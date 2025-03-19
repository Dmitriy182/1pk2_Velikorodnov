namespace task_10_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            int n = int.Parse(Console.ReadLine());

            char[,] array = GenerateChar(n);
            PrintChar(array);
        }

        static char[,] GenerateChar(int n)
        {
            char[,] array = new char[n, n];
            Random random = new Random();

           
            char[] russian = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    array[i, j] = russian[random.Next(russian.Length)];
                }
            }

            return array;
        }
 
        static void PrintChar(char[,] array)
        {
            int n = array.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(); 
            }
        }
    }
}
