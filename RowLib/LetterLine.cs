using System;
using System.Collections.Generic;
using System.Text;

namespace RowLib
{
    public class LetterLine: Line
    {
        public LetterLine(string line) : base(line)
        {

        }
        public LetterLine(char[] line) : base(new string(line))
        {

        }
        public string rightShift() {
            string text = get();
            char lastLetter = text[text.Length-1];
            string substr = text.Substring(0, text.Length - 1);
            text = lastLetter + substr;
            set(text);
            return text;
        }
        public char[] getLetters()
        {
            return get().ToCharArray();
        }
        public void setLetters(char[] line)
        {
            set(new string(line));
        }
    }
}
