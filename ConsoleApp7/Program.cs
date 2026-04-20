using System.Security.Cryptography;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] SalaryArray;
            string InputString;
            int InputInt;
            int CountSalary;

            int CountBonusSalary;
            int MiddleSalary;

            Console.WriteLine("Эта программа менеджер зарплат");
            Console.WriteLine("Введите сколько максимально будет зарплат: 1-10");

            CountSalary = GetValidatedInt();
            SalaryArray = new int[CountSalary];

            for (int i = 0; i < SalaryArray.Length; i++)
            {
                Console.WriteLine($"Введди зарплату №{i + 1}. Остановить написание зарплат: 'Next' ");
                InputString = Console.ReadLine();

                if (InputString == "Next" || InputString == "next") break;

                InputInt = int.TryParse(InputString, out InputInt) ? InputInt : 0;

                SalaryArray[i] = InputInt;
            }

            SalaryArray = SalaryArray.Where(x => x != 0).ToArray();

            MiddleSalary = SalaryArray.Sum() / SalaryArray.Length;

            Console.WriteLine($"Введди бонус к зарплате");

            while (true)
            {
                CountBonusSalary = int.TryParse(Console.ReadLine(), out CountSalary) ? CountSalary : 0;

                if (CountBonusSalary > 0) break;
                else Console.WriteLine("Введено не число повтори заново!");
            }

            for (int i = 0; i < SalaryArray.Length; i++)
            {
                SalaryArray = SalaryArray.Select(x => x < MiddleSalary ? x + CountBonusSalary : x).ToArray();
            }

            Console.WriteLine();
            Console.ReadLine();

        }
        static public int GetValidatedInt()
        {
            int userInput;

            if (!int.TryParse(Console.ReadLine(), out userInput)) userInput = 0;

            if (userInput == 0)
            {
                Console.WriteLine("Введено не число, повторите заново!");
                GetValidatedInt();
            }

            int limitedValue = ClampToRange(userInput, 10, 1);
            return limitedValue;
        }
        static public int ClampToRange(int value, int max, int min)
        {
            if (value > max) return value = max;
            else if (value < min) return value = min;
            else return value;
        }
        static public void PrintResult(int[] valueArray)
        {
            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine($"Зарплата №{i + 1}: {valueArray[i]}");
            }
        }
    }
}