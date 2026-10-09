using System;
using System.Runtime.InteropServices;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] names = { "января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            Console.Write("Введите номер дня (1-365): ");
            int day = Convert.ToInt32(Console.ReadLine());

            int month = 0;
            while (day > days[month])
            {
                day = day - days[month];
                month++;            
            }

            Console.WriteLine(day + " " + names[month]);
        }
    }
}