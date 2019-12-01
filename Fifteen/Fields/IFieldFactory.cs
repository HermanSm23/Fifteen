using Fifteen.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Fields
{
    public interface IFieldFactory
    {
        Cell[,] GetField(int size);
    }
}
