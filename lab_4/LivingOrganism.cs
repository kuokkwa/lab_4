using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class LivingOrganism
    {
        public int Enegry {  get; set; }
        public int Age {  get; set; }
        public int Size {  get; set; }

        public LivingOrganism(int enegry, int age, int size)
        {
            Enegry = enegry;
            Age = age;
            Size = size;
        }
    }
}
