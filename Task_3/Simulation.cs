using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Simulation
    {
        public Road Road { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public Simulation(Road road)
        {
            Road = road;
            Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
        public void OptimizeTraffic()
        {
            Vehicles.Sort((a, b) => a.Speed.CompareTo(b.Speed));

            double followingDistance = 5;

            for (int i = 0; i < Vehicles.Count; i++)
            {
                Vehicle currentVehicle = Vehicles[i];

                if (i < Vehicles.Count - 1)
                {
                    Vehicle aheadVehicle = Vehicles[i + 1];

                    double safeDistance = currentVehicle.Speed / 2;

                    if (aheadVehicle != null && (aheadVehicle.SizeClass > currentVehicle.SizeClass || aheadVehicle.Speed < currentVehicle.Speed) &&
                        (aheadVehicle.Speed - currentVehicle.Speed) < safeDistance)
                    {
                        currentVehicle.Stop();
                        Console.WriteLine($"Safe distance tracking: {currentVehicle.Type} has stopped.");
                    }
                    else
                    {
                        currentVehicle.Move();
                    }
                }
                else
                {
                    currentVehicle.Move();
                }
            }
        }
    }
}
