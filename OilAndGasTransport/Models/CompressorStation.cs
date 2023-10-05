using OilAndGasTransport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilAndGasTransport.Models
{
    internal class CompressorStation : ICompressorStation
    {
        public List<CompressorStation> lstcs = new List<CompressorStation>();
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Wscount { get; set; }
        public int Wsinwork { get; set; }
        public double Efficiency { get; set; }
        public CompressorStation() { }//попробовать убрать
        public CompressorStation(int id, string? name, int wscount, int wsinwork, double efficiency)
        {
            ID = id;
            Name = name;
            Wscount = wscount;
            Wsinwork = wsinwork;
            Efficiency = efficiency;
        }
        public void Add(CompressorStation cs)
        { 
            lstcs.Add(cs);
        }
    }
}
