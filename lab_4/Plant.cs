using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Plant: LivingOrganism, IReproducible
    {
        public bool Green {  get; set; }
        public bool Leaves { get; set; }

        public Plant(int energy, int age, int size, bool green, bool leaves): base(energy, age, size)
        {
            Green = green; 
            Leaves = leaves;
        }
        public void Reproduce()
        {
            Console.WriteLine("Plants are reproducing...");
        }
    }
}
