using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Display
    {
        private int size;
        private int colors;
        public int Size { get; set; }
        public int Colors { get; set; }
        public Display(int _size, int _colors)
        {
            this.size = _size;
            this.colors = _colors;
        }
    }
}
