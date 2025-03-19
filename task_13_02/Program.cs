namespace task_13_02
{
    class Pet;
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Pet pet = new Pet(); 
            pet.Name = "Ася";
            pet.Kind = "Кошка";
            pet.Age = "4";
            pet.Weight = "5";
            pet.Health = "Здорова";
            Console.WriteLine(pet.GetInfoAnimal());
            Console.WriteLine();
           


            pet.WeightChange("8");
            pet.HealthChange("Не здоров");
            Console.WriteLine(pet.GetInfoAnimal());
            Console.WriteLine();
            


            Pet peT = new Pet();
            peT.Name = "Бобик";
            peT.Kind = "Собака";
            peT.Age = "6";
            peT.Weight = "11";
            peT.Health = "Здоров";
            Console.WriteLine(peT.GetInfoAnimal());
        }
    }
}
