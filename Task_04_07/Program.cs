namespace Task_04_07
{
    internal class Program
    {
        static void Main()
        {
            int[] heights = { -150, 160, -145, 170, 155, -160, 165, -140, 175, 185,
                          150, -155, 165, -170, 160, 175, -145, 155, 180, -160,
                          165, 170, -155, -180, 175, 150, -140, 165, 160, -170 };

            int boysCount = 0;
            int girlsCount = 0;
            int boysSum = 0;
            int girlsSum = 0;

            foreach (int height in heights)
            {
                if (height < 0) 
                {
                    boysCount++;
                    boysSum += -height; 
                }
                else 
                {
                    girlsCount++;
                    girlsSum += height;
                }
            }

            double boysAverage = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double girlsAverage = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост мальчиков: {boysAverage:F2}");
            Console.WriteLine($"Средний рост девочек: {girlsAverage:F2}");
        }
    }
}