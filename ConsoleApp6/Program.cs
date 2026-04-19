using System.Data;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] arrayMap = new string[2, 3];
            string a = Console.ReadLine();
                while (true)
                {
                for (int y = 0; y < arrayMap.GetLength(0); y++)
                {
                    for (int x = 0; x < arrayMap.GetLength(1); x++)
                    {
                        int inputData;
                        Console.WriteLine("Напиши слово:");
                        arrayMap[y, x] = Console.ReadLine();
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Все слова:");

                for (int y = 0; y < arrayMap.GetLength(0); y++)
                {
                    for (int x = 0; x < arrayMap.GetLength(1); x++)
                    {
                        Console.Write(arrayMap[y, x] + "\t");
                    }
                    Console.WriteLine();


                }
                } 
        }
    }
}
