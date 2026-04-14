namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenNumbersCount = 0;
            int oddNumbersCount = 0;

            int currentValue = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                }
                else
                {
                    oddNumbersCount++;
                }
                currentValue++;
            }

            Console.WriteLine($"Всего чётных чисел: {evenNumbersCount}, нечётных: {oddNumbersCount}.");
        }
    }
}
