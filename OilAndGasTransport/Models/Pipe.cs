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
        private int _id = 0;
        public int ID 
        {
            get 
            {
                return _id;
            }
            set 
            {
                _id = value; 
            }
        }
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
        public void Add()
        {
            ID += 1;
            lstp.Add(new Pipe(ID,Length,Diameter,IsRepairing));
        }
    }
}
