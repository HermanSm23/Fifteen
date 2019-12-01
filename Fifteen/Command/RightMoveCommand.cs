using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Command
{
    public class RightMoveCommand : ICommand
    {
        private Field field;
        public RightMoveCommand(Field field)
        {
            this.field = field;
        }

        public void Execute()
        {
            field.MoveRight();
        }

        public void Undo()
        {
            field.MoveLeft();
        }
    }
}
