using OilAndGasTransport.Interfaces;
using OilAndGasTransport.Services;
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
            Console.WriteLine("Введите длину трубы:");
            Length = checkServices.checkInputDouble();
            Console.WriteLine("Введите диаметр трубы:");
            Diameter = checkServices.checkInputDouble();
            Console.WriteLine("В ремонте труба или нет:");
            IsRepairing = checkServices.checkInputBoolean();
            ID += 1;
            lstp.Add(new Pipe(ID, Length, Diameter, IsRepairing));
        }
        public void printPipe()
        {
            foreach (var p1 in lstp)
            {
                Console.WriteLine("\nТруба:");
                Console.WriteLine($"ID: {ID}");
                Console.WriteLine($"Длина трубы: {Length}");
                Console.WriteLine($"Величина диаметра: {Diameter}");
                Console.WriteLine($"В ремонте труба или нет: {IsRepairing}");
            }
        }
    }
}
