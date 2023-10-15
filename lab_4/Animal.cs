using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Animal: LivingOrganism, IPredator, IReproducible
    {
        public bool Wool {  get; set; }
        public bool Ears {  get; set; }

        public Animal(int energy, int age, int size, bool wool, bool ears): base(energy, age, size)
        {
            Wool = wool;
            Ears = ears;
        }
        public void Hunt()
        {
            Console.WriteLine("Animals are hunting...");
        }

        public void Reproduce()
        {
            Console.WriteLine("Animals are reproducing.");
        }
    }
}
