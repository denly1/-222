namespace Practica2
{
    internal class Program
    {
        static void Main()
        {

            Actions();
        }
        static void ugaday()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            Console.WriteLine("Угадай число от 1 до 100");

            bool guessed = false;

            while (!guessed)
            {
                Console.Write("Введите ваше предположение: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Харош,угадал!)");
                    guessed = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Надо больше");
                }
                else
                {
                    Console.WriteLine("Надо меньше");
                }
            }

            Console.WriteLine("Спасибо за игру. Нажмите любую клавишу, чтобы выйти.");
            Console.ReadKey();
        }
        static void Tablica()
        {
            string[,] gar = new string[10, 10];

            for (int ryad =1 ; ryad < 10; ryad++)
            {
                for (int mesto = 1 ; mesto < 10; mesto++)
                {
                    gar[ryad, mesto] = (ryad* mesto).ToString();
                    Console.Write(gar[ryad, mesto] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void podelity()
         {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Делители числа {number}:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
        Console.ReadKey();
    }

        static void Actions()
        {
            while (true)
            {
                Console.WriteLine("1) Игра угадай число");
                Console.WriteLine("2) Таблица умножения");
                Console.WriteLine("3) Найти делители числа");
                Console.WriteLine("4) Выйти из программы");
                Console.WriteLine("Введите действие: ");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    ugaday();
                }
                else if (action == 2)
                {
                    Tablica();
                }
                else if (action == 3)
                {
                    Console.WriteLine("Введите число: ");
                    podelity();
                }
                else if (action == 4)
                {
                    break;
                }
            }

        }
    }
}
