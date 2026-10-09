using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] names = { "января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            try
            {
                Console.Write("Введите номер дня (1-365): ");
                int day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 365)
                {
                    throw new Exception("Число должно быть от 1 до 365, подумай!!! И поменяй число");
                }
                int month = 0;
                while (day > days[month])
                {
                    day -= days[month];
                    month++;
                }
                Console.WriteLine(day + " " + names[month]);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}