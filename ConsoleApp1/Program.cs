namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            int a = 5;
            int b = 2;
            double result = (double) (a + b) / 2;
            Console.WriteLine(result);

            Console.WriteLine("Второе задание");
            int a2, b2, c2;
            if (int.TryParse(Console.ReadLine(), out a2) & int.TryParse(Console.ReadLine(), out b2) & int.TryParse(Console.ReadLine(), out c2))
            {
                int sum = a2 + b2 + c2;
                int product = a2 * b2 * c2;
                Console.WriteLine(sum);
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Не удалось преобразовать переменные");
            }
            Console.WriteLine("Третие задание");
            double rubles = 1000, dollars = 10, Rubles = 100, Dollars = 1;

            double mymoneyInDollars = (double) rubles / Rubles;
            double mymoneyInRubles = (double) dollars * Rubles;
            Console.WriteLine(mymoneyInRubles + " " + mymoneyInDollars);
        }
    }
}
