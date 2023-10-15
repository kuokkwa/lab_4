namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Road road = new Road(1.0, 1.0, 1, "1");

            Vehicle car = new Vehicle(81, "Medium", 2, "Car");
            Vehicle truck = new Vehicle(72.5, "Large", 3, "Bus");
            Vehicle motorbike = new Vehicle(63, "Small", 1, "Motorbike");

            Simulation simulation = new Simulation(road);

            simulation.AddVehicle(car);
            simulation.AddVehicle(truck);
            simulation.AddVehicle(motorbike);

            simulation.OptimizeTraffic();

            Console.ReadKey();
        }
    }
}