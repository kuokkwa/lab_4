using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Network
    {
        private List<Computer> computers = new List<Computer>();

        public void AddDevice(Computer computer)
        {
            computers.Add(computer);
        }

        public void ConnectDevice(Computer source, Computer target)
        {
            if (source is IConnectable)
            {
                ((IConnectable)source).Connect(target);
            }
            else
            {
                Console.WriteLine($"{source.GetType().Name} cannot set connection");
            }
        }

        public void DisconnectDevice(Computer source, Computer target)
        {
            if (source is IConnectable)
            {
                ((IConnectable)source).Disconnect(target);
            }
            else
            {
                Console.WriteLine($"{source.GetType().Name} cannot terminate connection.");
            }
        }
    }
}
