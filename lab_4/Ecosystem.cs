using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Ecosystem
    {
        public List<LivingOrganism> Organisms { get; set; }

        public Ecosystem()
        {
            Organisms = new List<LivingOrganism>();
        }

        public void SimulateEcosystem()
        {
            foreach (var organism in Organisms)
            {
                if (organism is IReproducible)
                {
                    ((IReproducible)organism).Reproduce();
                }

                if (organism is IPredator)
                {
                    ((IPredator)organism).Hunt();
                }
            }
        }
    }
}
