using OilAndGasTransport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilAndGasTransport.Models
{
    internal class Pipe : IPipe
    {
        public List<Pipe> lstp = new List<Pipe>();
        public int ID { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public bool IsRepairing { get; set; }
        public Pipe() { }
        public Pipe(int id, double length, double diameter, bool isrepairing)
        {
            ID = id;
            Length = length;
            Diameter = diameter;
            IsRepairing = isrepairing;
        }
        public void Add(Pipe cs)
        {
            lstp.Add(cs);
        }
    }
}
