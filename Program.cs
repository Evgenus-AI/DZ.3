class File
{
    static void Main()
    {
        // Задание 1 
        Console.WriteLine("Задание 1");
        int[] numbers = { 1, 3, 5, 4, 7, 8, 9, 10, 11, 12 };

        bool Sort = true;
        int breakInd = -1;

        for (int i = 0; i < 9; i++)
        {
            if (numbers[i] >= numbers[i + 1])
            {
                Sort = false;
                breakInd = i + 2;
                break;
            }
        }

        if (Sort)
            Console.WriteLine("Последовательность упорядочена по возрастанию");
        else
            Console.WriteLine($"Нарушение на позиции {breakInd} (число {numbers[breakInd - 1]})");

        // Задание 2
        Console.WriteLine("");
        Console.WriteLine("Задание 2");
        Console.WriteLine("Введите номер карты (от 6 до 14):");

        try
        {
            int k = int.Parse(Console.ReadLine());

            // Проверка карты, лежит ли она в нужном диапозоне
            if (k < 6 & k > 14)
            {}

            string cardName;
            switch (k)
            {
                case 6:  
                    cardName = "шестёрка";          
                    break;
                case 7:  
                    cardName = "семёрка";           
                    break;
                case 8:  cardName = "восьмёрка";         break;
                case 9:  cardName = "девятка";           break;
                case 10: cardName = "десятка";           break;
                case 11: cardName = "валет";             break;
                case 12: cardName = "дама";              break;
                case 13: cardName = "король";            break;
                case 14: cardName = "туз";               break;
                
                default: cardName = "неизвестная карта"; break;
            }
            Console.WriteLine($"Карта номер {k} — это {cardName}.");
        }
        catch (FormatException) //  если введено не число
        {
            Console.WriteLine("Ошибка!");
        }
        finally
        {
            Console.WriteLine("Конец.");
        }

        // Задание 3
        Console.WriteLine("");
        Console.WriteLine("Задание 3");
        Console.WriteLine("Введите роль: ");
        string role = Console.ReadLine().ToLower();
        string drink;
        switch (role)
        {
            case "jabroni":          drink = "Patron Tequila";        break;
            case "school counselor": drink = "Anything with Alcohol"; break;
            case "programmer":       drink = "Hipster Craft Beer";    break;
            case "bike gang member": drink = "Moonshine";             break;
            case "politician":       drink = "Your tax dollars";      break;
            case "rapper":           drink = "Cristal";               break;
            default:                 drink = "Beer";                  break;
        }
        Console.WriteLine($"Напиток: {drink}");



        // Задание 4
        Console.WriteLine("");
        Console.WriteLine("Задание 4");
        Console.WriteLine("Введите номер дня недели: ");
        int dayNumber = int.Parse(Console.ReadLine());

        // Проверка на диапозон
        if (dayNumber >= 1 & dayNumber <= 7)
        {
            // Преобразуем число в значение enum
            DayOfWeek day = (DayOfWeek)dayNumber;
            Console.WriteLine("День недели: " + day);


            // Задание 5
            Console.WriteLine("");
            Console.WriteLine("Задание 5");

            string[] toys = { "Hello Kitty", "Unicorn", "Barbie doll", "Slime", "Hello Kitty", "Ball", "Barbie doll", "Teddy bear" };
            int dollCount = 0;
            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    dollCount++;
                }
            }
            Console.WriteLine($"В сумке {dollCount} куклы.");
        }
    }
}