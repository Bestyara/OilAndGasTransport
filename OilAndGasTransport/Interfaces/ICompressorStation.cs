using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilAndGasTransport.Interfaces
{
    internal interface ICompressorStation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Wscount { get; set; }
        public int Wsinwork { get; set; }
        public double Efficiency { get; set; }

    }
}
