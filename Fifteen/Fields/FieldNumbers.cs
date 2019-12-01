using Fifteen.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Fields
{
    public class FieldNumbers : IFieldFactory
    {
        ICellFactory cellFactory;

        public FieldNumbers()
        {
            cellFactory = new NumberCell();
        }

        public Cell[,] GetField(int size)
        {
            var cells = new Cell[size, size];
            var cellNumber = 1;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (i == size - 1 && j == size - 1)
                        break;
                    cells[i, j] = cellFactory.GetCell(cellNumber);
                    cellNumber++;
                }
            return cells;
        }
    }
}
