namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal(70, 5, 5, true, true);
            Plant flower = new Plant(20, 2, 3, true, true);
            Microorganism bacteria = new Microorganism(1, 1, 1, true, true);

            Ecosystem ecosystem = new Ecosystem();
            ecosystem.Organisms.Add(cat);
            ecosystem.Organisms.Add(flower);
            ecosystem.Organisms.Add(bacteria);

            ecosystem.SimulateEcosystem();

            Console.ReadKey();
        }
    }
}