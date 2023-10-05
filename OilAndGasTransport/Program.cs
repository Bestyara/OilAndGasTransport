using OilAndGasTransport.Models;
using OilAndGasTransport.Services;
using System.ComponentModel;
using System.Threading.Channels;

namespace OilAndGasTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressorStation cs = new CompressorStation();
            Pipe p = new Pipe();
            var key = Console.ReadKey(true).KeyChar;
            while (key != '0')
            {
                Console.WriteLine("\n1.Добавить трубу");
                Console.WriteLine("2.Добавить КС");
                Console.WriteLine("3.Просмотр всех объектов");
                Console.WriteLine("4.Редактировать трубу");
                Console.WriteLine("5.Редактировать КС");
                Console.WriteLine("6.Сохранить");
                Console.WriteLine("7.Загрузить");
                Console.WriteLine("0.Выход\n");
                key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1':
                        p.Add();
                        break;
                    case '2':
                        cs.Add();
                        break;
                    case '3':
                        Console.WriteLine("Все объекты:");
                        p.printPipe();
                        
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
