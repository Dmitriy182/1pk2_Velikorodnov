namespace task_11_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Исходные значения: a = {a}, b = {b}");

            
            Calculate(ref a, ref b, out int sum, out int product);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }

        static void Calculate(ref int x, ref int y, out int sum, out int product)
        {
            sum = x + y;       
            product = x * y;    
        }
    }
}
