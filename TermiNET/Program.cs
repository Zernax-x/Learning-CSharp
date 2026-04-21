namespace TermiNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Word> Dictionary = new List<Word>()
            {
                new Word("По умолчанию", "By default"),
                new Word("Вручную", "Manually"),
                new Word("Автоматически", "Automatically"),
                new Word("Успешно", "Successfully"),
                new Word("Вместо (чего-то)", "Instead of")
            };

            Console.WriteLine("This programm helps to learning English.");
            while (true)
            {
                Console.WriteLine("What you want to do?");
                Console.WriteLine($"{"1.Write a word in Database.",-30} Select '1'");
                Console.WriteLine($"{"2.Exit from programm.",-30} Select 'Exit'");

                string Input = Console.ReadLine();
                switch (Input)
                {
                    case "1":
                        Console.WriteLine("Write the word first in Russian, then in English, separated by commas.");
                        Input = Console.ReadLine();

                        string[] partsWord = Input.Split(',');
                        string rword = partsWord[0].Trim();
                        string eword = partsWord[1].Trim();

                        Console.WriteLine($"Save {rword} and {eword}?");
                        if (ConfirmSelect()) break;

                        Word input = new Word(rword, eword);
                        Dictionary.Add(input);
                        break;
                }
            }
        }
        
            static bool ConfirmSelect()
            {
                Console.WriteLine("Write select?\tYes-1 or No-2");
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "1") return true;
                    if (input == "2") return false;
                    Console.WriteLine("You write not validation value, write again");
                }
            }
        }
    }
