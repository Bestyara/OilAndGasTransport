using OilAndGasTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OilAndGasTransport.Services
{
    internal class CompressorStationServices
    {
        public void AddCompressorStation(CompressorStation cs, List<CompressorStation> lstcs)
        {
            Console.WriteLine("Введите название компрессорной станции:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите количество цехов:");
            var wscount = checkServices.checkInputInt();
            Console.WriteLine("Введите количество цехов в работе:");
            var wsinwork = checkServices.checkInputInt();
            Console.WriteLine("Введите коэффициент эффективности:");
            var efficiency = checkServices.checkInputDouble();
            cs.ID = lstcs.Count+1;
            lstcs.Add(new CompressorStation(cs.ID, name, wscount, wsinwork, efficiency));
        }
        public void printCompressorStation(List<CompressorStation>lstcs)
        {
            foreach (var cs1 in lstcs)
            {
                Console.WriteLine("\nКомпрессорная станция:");
                Console.WriteLine($"ID: {cs1.ID}");
                Console.WriteLine($"Название: {cs1.Name}");
                Console.WriteLine($"Количество цехов: {cs1.Wscount}");
                Console.WriteLine($"Количество цехов в работе: {cs1.Wsinwork}");
                Console.WriteLine($"Коэффициент эффективности: {cs1.Efficiency}");
            }
        }
        public void ChangeCompressorStation(List<CompressorStation> lstcs)
        {
            Console.WriteLine("Введите ID компрессорной станции, параметры которой вы хотите изменить:");
            var c = checkServices.checkInputInt();
            CompressorStation? cs = lstcs
                .Where(x => x.ID == c)
                .FirstOrDefault();
            if (cs == null)
                Console.WriteLine("Компрессорной станции с таким ID нет");
            else
            {
                lstcs.Remove(cs);
                Console.WriteLine("Какой параметр изменить?");
                Console.WriteLine("1 - Название компрессорной станции");
                Console.WriteLine("2 - Количество цехов");
                Console.WriteLine("3 - Количество цехов в работе");
                Console.WriteLine("4 - Коэффициент эффективности");
                var kc = Console.ReadKey(true).KeyChar;
                Console.WriteLine("Введите значение:");
                while (kc == '1' || kc == '2' || kc == '3' || kc == '4')
                {
                    switch (kc)
                    {
                        case '1':
                            cs.Name = Console.ReadLine();
                            kc = '0';
                            break;
                        case '2':
                            cs.Wscount = checkServices.checkInputInt();
                            kc = '0';
                            break;
                        case '3':
                            cs.Wsinwork = checkServices.checkInputInt();
                            kc = '0';
                            break;
                        case '4':
                            cs.Efficiency = checkServices.checkInputDouble();
                            kc = '0';
                            break;
                        default:
                            Console.WriteLine("Неправильный ввод, попробуйте еще раз");
                            kc = Console.ReadKey(false).KeyChar;
                            break;
                    }
                }
                lstcs.Insert(cs.ID - 1, cs);
                Console.WriteLine("Изменение произошло успешно!");
            }
        }
        public void saveCompressorStation(List<CompressorStation> lstcs)
        {
            foreach (var cs in lstcs)
            {
                File.AppendAllText("DataFile.txt", $"Компрессорная станция #{cs.ID} \nНазвание компрессорной станции: {cs.Name} \nКоличество цехов: {cs.Wscount} \nКоличество цехов в работе: {cs.Wsinwork} \nКоэффициент эффективности: {cs.Efficiency} \n\n");
            }
        }
        public void loadCompressorStation(List<CompressorStation> lstcs)
        {
            lstcs.Clear();
            StreamReader sr = new StreamReader("DataFile.txt");
            var obj = "";
            do
            {
                //Поле ID
                obj = sr.ReadLine();
                if (obj[0] == 'К')
                {
                    var id = obj.IndexOf('#') + 1;
                    while (obj.Length < id && !(obj[id].Equals(" ")))
                        id++;
                    var chid = Convert.ToInt32(obj.Substring(obj.IndexOf('#') + 1, id - obj.IndexOf('#')));
                    //Свойство Name
                    var nm = sr.ReadLine();
                    int i = nm.IndexOf(':') + 2;
                    while (nm.Length < i && !(nm[i].Equals(" ")))
                        i++;
                    var sname = nm.Substring(nm.IndexOf(':') + 2, i - nm.IndexOf(':'));
                    //Свойство Wscount
                    var wsc = sr.ReadLine();
                    i = wsc.IndexOf(':') + 2;
                    while (wsc.Length < i && !(wsc[i].Equals(" ")))
                        i++;
                    var chwsc = Convert.ToInt32(wsc.Substring(wsc.IndexOf(':') + 2, i - wsc.IndexOf(':')));
                    //Свойство Wsinwork
                    var wsinw = sr.ReadLine();
                    i = wsinw.IndexOf(':') + 2;
                    while (wsinw.Length < i && !(wsinw[i].Equals(" ")))
                        i++;
                    var chwsinw = Convert.ToInt32(wsinw.Substring(wsinw.IndexOf(':') + 2, i - wsinw.IndexOf(':')));
                    //Свойство коэффициент эффективности
                    var eff = sr.ReadLine();
                    i = eff.IndexOf(':') + 2;
                    while (eff.Length < i && !(eff[i].Equals(" ")))
                        i++;
                    var cheff = Convert.ToInt32(eff.Substring(eff.IndexOf(':') + 2, i - eff.IndexOf(':')));
                    //Добавляем трубу в список
                    lstcs.Add(new CompressorStation(chid, sname, chwsc, chwsinw, cheff));
                    sr.ReadLine();
                }
                else
                {
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    sr.ReadLine();
                    //sr.ReadLine();
                }
            } while (sr.Peek()!=-1);
        }
    }
}
