using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class WorkStation: Computer, IConnectable
    {
        public WorkStation(string ipaddress, int power, string ostype): base(ipaddress, power, ostype)
        {
            IPaddress = ipaddress;
            Power = power;
            OStype = ostype;
        }
        public void Connect(Computer target)
        {
            Console.WriteLine($"Workstation {IPaddress}  is connected to  {target.IPaddress}");
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Workstation {IPaddress}  is disconnected from  {target.IPaddress}");
        }
    }
}
