using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Computer
    {
        public string IPaddress { get; set; }
        public int Power { get; set; }
        public string OStype { get; set; }

        public Computer(string ipaddress, int power, string ostype)
        {
            IPaddress = ipaddress;
            Power = power;
            OStype = ostype;
        }
    }
}
