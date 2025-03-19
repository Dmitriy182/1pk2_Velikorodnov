namespace task_11_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"До обмена: a = {a}, b = {b}");

           
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"После обмена: a = {a}, b = {b}");
        }
    }
}
