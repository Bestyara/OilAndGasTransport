namespace OilAndGasTransport
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Добавить трубу");
            Console.WriteLine("2.Добавить КС");
            Console.WriteLine("3.Просмотр всех объектов");
            Console.WriteLine("4.Редактировать трубу");
            Console.WriteLine("5.Редактировать КС");
            Console.WriteLine("6.Сохранить");
            Console.WriteLine("7.Загрузить");
            Console.WriteLine("0.Выход");
            var key = Console.ReadKey(true).KeyChar;
            if (key >= 48 && key <= 57)
            {
                Console.WriteLine("Все хорошо!");
            }
            else
            {
                Console.WriteLine("Неправильный ввод!");
            }

        }
    }
}
