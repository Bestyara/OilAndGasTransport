﻿using OilAndGasTransport.Models;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace OilAndGasTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressorStation cs = new CompressorStation();
            Pipe p = new Pipe();
            char key = '1';
            while (key != '0')
            {
                Console.WriteLine("Введите одну из цифр ниже:");
                Console.WriteLine("1.Добавить трубу");
                Console.WriteLine("2.Добавить КС");
                Console.WriteLine("3.Просмотр всех объектов");
                Console.WriteLine("4.Редактировать трубу");
                Console.WriteLine("5.Редактировать КС");
                Console.WriteLine("6.Сохранить данные в файл");
                Console.WriteLine("7.Загрузить данные из файла");
                Console.WriteLine("0.Выход\n");
                key = Console.ReadKey(true).KeyChar;
                Console.Clear();
                switch (key)
                {
                    case '1':
                        p.Add();//Может только через сервисы обращаться?
                        Console.Clear();
                        break;
                    case '2':
                        cs.Add();
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("Все объекты:");
                        p.printPipe();
                        cs.printCompressorStation();
                        Console.WriteLine("\nНажмите любую клавишу для выхода в главное меню");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '4':
                        p.changePipe();
                        Console.Clear();
                        break;
                    case '5':
                        cs.ChangeCompressorStation();
                        Console.Clear();
                        break;
                    case '6':
                        File.WriteAllText("DataFile.txt", "");
                        p.savePipe();
                        cs.saveCompressorStation();
                        Console.WriteLine("Сохранение произошло успешно");
                        Console.WriteLine("\nНажмите любую клавишу для выхода в главное меню");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '7':
                        StreamReader sr = new StreamReader("DataFile.txt");
                        p.loadPipe();
                        cs.loadCompressorStation();
                        Console.WriteLine("Загрузка данных из файла произошла успешно");
                        Console.WriteLine("\nНажмите любую клавишу для выхода в главное меню");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '0':
                        Console.WriteLine("Программа завершена успешно!");
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод, попробуйте еще раз");
                        break;
                }
            }
        }
    }
}
