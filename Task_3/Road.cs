using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Road
    {
        public double Length {  get; set; }
        public double Width { get; set; }
        public int NumberOfLanes { get; set; }
        public string CurrentTrafficLevel {  get; set; }

        public Road(double legth, double width, int numberoflanes, string currenttrafficlevel)
        {
            Length = legth;
            Width = width;
            NumberOfLanes = numberoflanes;
            CurrentTrafficLevel = currenttrafficlevel;
        }
    }
}
