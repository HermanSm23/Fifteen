using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Cells
{
    public class PointCell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointCell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
