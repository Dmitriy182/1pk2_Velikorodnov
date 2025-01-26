namespace Task_03_05
{ 
    internal class Program
    {
        /*Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.*/
        static void Main(string[] args)
        {
            int count = 20;
            while (count > 50)
            {
                if (count % 3 == 0)
                    if (count % 5 != 0)
                    {
                        Console.WriteLine(count);
                    }
                count--;
            }
        }
    }
}