using System;
using System.Collections.Generic;
using System.Text;

namespace RowLib
{
    public class Line
    {
        private string line;
        public Line(string line)
        {
            this.line = line;
        }
        public int getSize() {
            return line.Length;
        }
        public string get() {
            return line;
        }
        public void set(string line)
        {
            this.line = line;
        }
        public override string ToString() {
            return line;
        }
    }
}
