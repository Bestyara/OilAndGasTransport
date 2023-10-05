using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilAndGasTransport.Services
{
    internal class checkServices
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
                catch (Exception ex)
                {
                    Console.WriteLine("Попробуйте еще раз:");
                }
            }
        }
        public static int checkInputInt()
        {
            while (true)
            {
                try
                {
                    var inp = Convert.ToInt32(Console.ReadLine());
                    return inp;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Попробуйте еще раз:");
                }
            }
        }
    }
}
