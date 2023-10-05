using OilAndGasTransport.Models;
using System.ComponentModel;
using System.Threading.Channels;

namespace OilAndGasTransport
{
    class Program
    {
        public static double checkInputDouble()
        {
            while (true)
            {
                try
                {
                    var inp = Convert.ToDouble(Console.ReadLine());
                    return inp;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Попробуйте еще раз:");
                }
            }
        }
        public static bool checkInputBoolean()
        {
            while (true)
            {
                try
                {
                    var inp = Convert.ToBoolean(Console.ReadLine());
                    return inp;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Попробуйте еще раз:");
                }
            }
        }
        static void Main(string[] args)
        {
            CompressorStation cs = new CompressorStation();
            Pipe p = new Pipe();
            var key = Console.ReadKey(true).KeyChar;
            while (key != '0')
            {
                Console.WriteLine("1.Добавить трубу");
                Console.WriteLine("2.Добавить КС");
                Console.WriteLine("3.Просмотр всех объектов");
                Console.WriteLine("4.Редактировать трубу");
                Console.WriteLine("5.Редактировать КС");
                Console.WriteLine("6.Сохранить");
                Console.WriteLine("7.Загрузить");
                Console.WriteLine("0.Выход");
                key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1':
                        Console.WriteLine("Введите длину трубы:");
                        p.Length = checkInputDouble();
                        Console.WriteLine("Введите диаметр трубы:");
                        p.Diameter = checkInputDouble();
                        Console.WriteLine("В ремонте труба или нет:");
                        p.IsRepairing = checkInputBoolean();
                        p.Add(p);
                        break;
                    case '2':
                        cs.Add(cs);
                        break;
                    case '3':
                        Console.WriteLine("Все объекты:");
                        foreach (var p1 in p.lstp)
                        {
                            Console.WriteLine("Труба:");
                            Console.WriteLine($"ID: {p1.ID}");
                            Console.WriteLine($"Длина: {p1.Length}");
                            Console.WriteLine($"Диаметр: {p1.Diameter}");
                            Console.WriteLine($"В ремонте: {p1.IsRepairing}");
                        }
                        foreach (var cs1 in cs.lstcs)
                        {
                            Console.WriteLine("Компрессорная станция:");
                            Console.WriteLine($"ID: {cs1.ID}");
                            Console.WriteLine($"Название: {cs1.Name}");
                            Console.WriteLine($"Количество цехов: {cs1.Wscount}");
                            Console.WriteLine($"Количество цехов в работе: {cs1.Wsinwork}");
                            Console.WriteLine($"Коэффициент эффективности: {cs1.Efficiency}");
                        }
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод, попробуйте еще раз");
                        break;
                }
            }
            Console.WriteLine("Программа завершена успешно!");
        }
    }
}
