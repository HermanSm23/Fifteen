using Fifteen.Cells;
using Fifteen.Command;
using Fifteen.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    public class Field
    {
        public int Size { get; private set; }
        private Cell[,] Cells;
        public PointCell PointCell { get; set; }
        public Stack<ICommand> commands;
        IFieldFactory FieldFactory { get; set; }
        IFieldCreator FieldCreator { get; set; }

        public Field(int size)
        {
            Size = size;
            FieldFactory = new FieldNumbers();
        }

        public int?[,] GetField()
        {
            var size = Cells.GetLength(0);
            var cells = new int?[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    cells[i, j] = Cells[i, j]?.Number;
                }
            return cells;
        }

        public void SwapArrayElements(ref Cell cellA, ref Cell cellB)
        {
            Cell Celltemp = cellA;
            cellA = cellB;
            cellB = Celltemp;
        }

        public void MoveRight()
        {
            if (PointCell.Y < Cells.GetLength(1) - 1)
            {
                SwapArrayElements(ref Cells[PointCell.X, PointCell.Y],
                    ref Cells[PointCell.X, PointCell.Y + 1]);
                PointCell.Y++;
            }
        }

        public void MoveLeft()
        {
            if (PointCell.Y > 0)
            {
                SwapArrayElements(ref Cells[PointCell.X, PointCell.Y],
                    ref Cells[PointCell.X, PointCell.Y - 1]);
                PointCell.Y--;
            }
        }

        public void MoveUp()
        {
            if (PointCell.X > 0)
            {
                SwapArrayElements(ref Cells[PointCell.X - 1, PointCell.Y],
                    ref Cells[PointCell.X, PointCell.Y]);
                PointCell.X--;
            }
        }

        public void MoveDown()
        {
            if (PointCell.X < Cells.GetLength(0)-1)
            {
                SwapArrayElements(ref Cells[PointCell.X + 1, PointCell.Y],
                    ref Cells[PointCell.X, PointCell.Y]);
                PointCell.X++;
            }
        }

        public void SetGenerator(IFieldFactory fieldFactory)
        {
            FieldFactory = fieldFactory;
        }

        public void GenerateField()
        {
            Cells = FieldFactory.GetField(Size);
            PointCell = new PointCell(Size - 1, Size - 1);
        }

        public void MixCells(int iterCount)
        {
            FieldCreator.Create(this, iterCount);
        }

        public void Move(ICommand command)
        {
            command.Execute();
            commands.Push(command);
        }

        public void UndoCommand()
        {
            if (commands.Count != 0)
            {
                var lastCommand = commands.Pop();
                lastCommand.Undo();
            }
        }
    }
}
