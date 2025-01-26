
namespace Task_02_02
{
    internal class Program
    {
        /* Найти значение выражения
         * при a = 8, b = 14, с = π/4
         */
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double part1 = Math.Pow(a - 1, 1.0 / 3.0);
            double part2 = Math.Pow(b + part1, 1.0 / 4.0); //числитель
            double part3 = Math.Abs(a - b);
            double part4 = Math.Sin(Math.Pow(c, 2)) + Math.Tan(c);
            double part5 = part3 * part4; //знаменатель
            double part6 = part2 / part5; //итог

            Console.WriteLine(part6);
        }
    }
}
