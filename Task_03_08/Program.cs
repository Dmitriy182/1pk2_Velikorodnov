namespace Task_03_08
{
    internal class Program
    {
        /*Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.*/
        static void Main(string[] args)
        {
            int part1 = 20, part2 = 50;
            while (part2 != part1)
            {
                if (part2 % 3 == 0 & part2 % 5 != 0)
                {
                    Console.WriteLine(part2);

                }
                --part2;

            }
        }
    }
}
