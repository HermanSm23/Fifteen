using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Cells
{
    public class Cell
    {
        public int Number { get; private set; }

        public Cell(int num)
        {
            Number = num;
        }
    }
}
