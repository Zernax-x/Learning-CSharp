using System.Security.Cryptography;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа менеджер зарплат");

            Console.WriteLine("Сколько всего зарплат? 1-10");
            int count = ClampToRange(GetValidatedInt(), 10, 1);

            int[] SalaryArray = new int[count];
            FillSaralies(SalaryArray);

            SalaryArray = SalaryArray.Where(x => x > 0).ToArray();

            int middle = (int)SalaryArray.Average();

            Console.WriteLine("Введите бонус");
            int bonus = GetValidatedInt();

            SalaryArray = SalaryArray.Select(x => x < middle ? x + bonus : x).ToArray();

            PrintResult(SalaryArray);

            Console.ReadLine();
        }
        static public int GetValidatedInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
                    return result;
                Console.WriteLine("Неверный ввод, нужно положительное число");
            }
        }
        static public int ClampToRange(int value, int max, int min)
        {
            if (value > max) return value = max;
            if (value < min) return value = min;
            return value;
        }
        static public void PrintResult(int[] array)
        {
            Console.WriteLine("\nИтоговый список:");
            foreach (var s in array) Console.WriteLine(s);
        }
        static void FillSaralies(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Зарплата №{i + 1} (или 'next')");
                string input = Console.ReadLine();
                if (input?.ToLower() == "next") break;

                if (int.TryParse(input, out int var)) array[i] = var;
            }
        }
    }
}