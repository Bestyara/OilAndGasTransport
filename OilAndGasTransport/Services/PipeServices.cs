using OilAndGasTransport.Models;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilAndGasTransport.Services
{
    internal class PipeServices
    {
        public void AddPipe(Pipe p,List<Pipe> lstp)
        {
            Console.WriteLine("Введите длину трубы:");
            p.Length = checkServices.checkInputDouble();
            Console.WriteLine("Введите диаметр трубы:");
            p.Diameter = checkServices.checkInputDouble();
            Console.WriteLine("В ремонте труба или нет:");
            p.IsRepairing = checkServices.checkInputBoolean();
            p.ID = lstp.Count+1;
            lstp.Add(new Pipe(p.ID, p.Length, p.Diameter, p.IsRepairing));
        }
        public void printPipe(List<Pipe> lstp)
        {
            foreach (var p1 in lstp)
            {
                Console.WriteLine("\nТруба:");
                Console.WriteLine($"ID: {p1.ID}");
                Console.WriteLine($"Длина трубы: {p1.Length}");
                Console.WriteLine($"Величина диаметра: {p1.Diameter}");
                Console.WriteLine($"В ремонте труба или нет: {p1.IsRepairing}");
            }
        }
        public void changePipe(List<Pipe> lstp)
        {
            Console.WriteLine("Введите ID трубы, параметры которой вы хотите изменить:");
            var c = checkServices.checkInputInt();
            Pipe? p = lstp
                .Where(x => x.ID == c)
                .FirstOrDefault();
            if (p == null)
                Console.WriteLine("Трубы с таким ID нет");
            else 
            {
                lstp.Remove(p);
                Console.WriteLine("Какой параметр изменить?");
                Console.WriteLine("1 - Длина трубы");
                Console.WriteLine("2 - Диаметр трубы");
                Console.WriteLine("3 - Труба в ремонте или нет");
                var kc = Console.ReadKey(true).KeyChar;
                Console.WriteLine("Введите значение:");
                while (kc == '1' || kc == '2' || kc == '3')
                {
                    switch (kc)
                    {
                        case '1':
                            p.Length = checkServices.checkInputDouble();
                            kc = '0';
                            break;
                        case '2':
                            p.Diameter = checkServices.checkInputDouble();
                            kc = '0';
                            break;
                        case '3':
                            p.IsRepairing = checkServices.checkInputBoolean();
                            kc = '0';
                            break;
                        default:
                            Console.WriteLine("Неправильный ввод, попробуйте еще раз");
                            kc = Console.ReadKey(false).KeyChar;
                            break;
                    }
                }
                lstp.Insert(p.ID-1,p);
                Console.WriteLine("Изменение произошло успешно!");
            }
        }
        public void savePipe(List<Pipe> lstp)
        {
            foreach (var p in lstp)
            {
                File.AppendAllText("DataFile.txt",$"Труба #{p.ID}\nДлина трубы: {p.Length}\nДиаметр трубы: {p.Diameter}\nТруба в ремонте или нет: {p.IsRepairing}\n\n");
            }
        }
        public void loadPipe(List<Pipe> lstp) 
        {
            

        }
    }
}
