namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthArray = int.Parse(Console.ReadLine());

            int[] myArray = Enumerable.Range(3, 5).ToArray();

            myArray = Enumerable.Reverse(myArray).ToArray();
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Создан элемент в массиве: [{i}] = {myArray[i]}");
            }
            Console.ReadLine();
        }
    }
}
