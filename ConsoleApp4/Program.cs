namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputData = int.Parse(Console.ReadLine());

            int result =inputData > 0 ? inputData : 0;
            
            Console.WriteLine(result);
        }
    }
}

