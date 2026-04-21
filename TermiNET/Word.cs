using System;
using System.Collections.Generic;
using System.Text;

namespace TermiNET
{
    public class Word
    {
        public string Rword { get; set; }
        public string Eword { get; set; }

        public Word(string rword, string eword) 
        {
            Rword = rword;
            Eword = eword;
        }
        public void Print() 
        {
            Console.Write($"\n{Rword}, {Eword}.");
        }
        public void PrintR()
        {
            Console.Write($"\n{Rword}.");
        }
        public void PrintE()
        {
            Console.Write($"\n{Eword}.");
        }
    }
}
