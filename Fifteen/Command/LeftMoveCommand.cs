using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Command
{
    public class LeftMoveCommand : ICommand
    {
        private Field field;
        public LeftMoveCommand(Field field)
        {
            this.field = field;
        }

        public void Execute()
        {
            field.MoveLeft();
        }

        public void Undo()
        {
            field.MoveRight();
        }
    }
}
