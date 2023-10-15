using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Microorganism: LivingOrganism, IReproducible
    {
        public bool MicrobeType { get; set; }
        public bool MicrobeName { get; set; }

        public Microorganism(int energy, int age, int size, bool microbeType, bool microbeName) : base(energy, age, size)
        {
            MicrobeType = microbeType;
            MicrobeName = microbeName;  
        }
        public void Reproduce()
        {
            Console.WriteLine("Microorganisms are reproducing...");
        }
    }
}
