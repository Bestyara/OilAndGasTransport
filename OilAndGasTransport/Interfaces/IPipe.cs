using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilAndGasTransport.Interfaces
{
    internal interface IPipe
    {
        public int ID { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public bool IsRepairing { get; set; }
    }
}
