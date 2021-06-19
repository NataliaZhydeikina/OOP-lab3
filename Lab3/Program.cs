using System;
using RowLib;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterLine line1 = new LetterLine("abc def ghi");
            LetterLine line2 = new LetterLine(new char[]{ 'j', 'k', 'l', 'm', 'n', 'o'});
            Console.WriteLine(line1.get());
            Console.WriteLine(line2.get());
            Console.WriteLine(line1.getLetters());
            Console.WriteLine(line2.getLetters());
            Console.WriteLine(line1.getSize());
            Console.WriteLine(line2.getSize());
            line1.rightShift();
            line2.rightShift();
            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}
