using OilAndGasTransport.Interfaces;
using OilAndGasTransport.Services;
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
        CompressorStationServices services = new CompressorStationServices();
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
        public void Add()
        {
            services.AddCompressorStation(new CompressorStation(ID,Name,Wscount,Wsinwork,Efficiency), lstcs);
        }
        public void printCompressorStation()
        {
            services.printCompressorStation(lstcs);
        }
        public void ChangeCompressorStation()
        {
            services.ChangeCompressorStation(lstcs);
        }
    }
}
