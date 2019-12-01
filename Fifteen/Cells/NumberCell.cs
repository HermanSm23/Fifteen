using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Cells
{
    public class NumberCell : ICellFactory
    {

        public Cell GetCell(int num)
        {
            if (num > 0)
                return new Cell(num);
            else
                return new Cell(-1);
        }
    }
}
