namespace numbercheck
{
    delegate bool Number(int number);

    class Program
    {
        public static bool EvenNumber(int number)
        {
            return number % 2 == 0;
        }
        public static bool OddNumber(int number)
        {
            return number % 2 != 0;
        }
        public static bool DefaultNumber(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static bool FibonacciNumber(int number)
        {
            if (number < 0)
                return false;
            int a = 0, b = 1;
            while (a < number)
            {
                int new_num = a;
                a = b;
                b = new_num + b;
            }
            return a == number;
        }

        static void Main(string[] args)
        {
            Number[] checks = { EvenNumber, OddNumber, DefaultNumber, FibonacciNumber };
            int choice = 0;
            int[] numbers = {1, 2, 3, 4, 5, 6};
            while (choice != 5)
            {
                Console.WriteLine("\nВыберите проверку:");
                Console.WriteLine("1 - Проверка на четность");
                Console.WriteLine("2 - Проверка на нечетность");
                Console.WriteLine("3 - Проверка на простое число");
                Console.WriteLine("4 - Проверка на число Фибоначчи");
                Console.WriteLine("5 - Выход");
                Console.Write("Ваш выбор: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 4)
                {
                    foreach (int number in numbers)
                    {
                        bool result = checks[choice - 1](number);
                        Console.WriteLine($"Число {number}: " + (result ? "Да" : "Нет"));
                    }
                }
            }
        }
    }
}
