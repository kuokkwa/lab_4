using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3
{
    public class Vehicle: IDriveable
    {
        public double Speed {  get; set; }
        public string Size { get; set; }
        public int SizeClass { get; set; }
        public string Type {  get; set; }

        public Vehicle(double speed, string size, int sizeclass, string type)
        {
            Speed = speed;
            Size = size;
            SizeClass = sizeclass;
            Type = type;
        }

        public void Move()
        {
            Console.WriteLine($"{Type} is moving at a speed of {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} has stopped.");
        }
    }
}
