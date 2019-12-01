using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Cells
{
    public interface ICellFactory
    {
        Cell GetCell(int num);
    }
}
