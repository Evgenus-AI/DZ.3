using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря" };

            try
            {
                Console.Write("Введите год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                bool leap = IsLeapYear(year);
                if (leap)
                    Console.WriteLine($"{year} год високосный");
                else
                    Console.WriteLine($"{year} год не високосный");

                int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (leap)
                    days[1] = 29;
                int maxDay;
                if (IsLeapYear(year))
                    maxDay = 366;
                else
                    maxDay = 365;
                Console.Write($"Введите номер дня (1-{maxDay}): ");
                int day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > maxDay)
                {
                    throw new Exception($"Число должно быть от 1 до {maxDay}");
                }
                int month = 0;
                while (day > days[month])
                {
                    day -= days[month];
                    month++;
                }
                Console.WriteLine($"{day} {names[month]} {year} года");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }
}