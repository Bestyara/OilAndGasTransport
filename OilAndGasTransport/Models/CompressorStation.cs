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
            Console.WriteLine("Введите название компрессорной станции:");
            Name = Console.ReadLine();
            Console.WriteLine("Введите количество цехов:");
            Wscount = checkServices.checkInputInt();
            Console.WriteLine("Введите количество цехов в работе:");
            Wsinwork = checkServices.checkInputInt();
            Console.WriteLine("Введите коэффициент эффективности:");
            Efficiency = checkServices.checkInputDouble();
            ID += 1;
            lstcs.Add(new CompressorStation(ID, Name, Wscount, Wsinwork, Efficiency));
        }
        public void printCompressorStation()
        {
            foreach (var cs1 in lstcs)
            {
                Console.WriteLine("\nКомпрессорная станция:");
                Console.WriteLine($"ID: {ID}");
                Console.WriteLine($"Название: {Name}");
                Console.WriteLine($"Количество цехов: {Wscount}");
                Console.WriteLine($"Количество цехов в работе: {Wsinwork}");
                Console.WriteLine($"Коэффициент эффективности: {Efficiency}");
            }
        }
        public void Change()
        {
            Console.ReadLine();
        }
    }
}
