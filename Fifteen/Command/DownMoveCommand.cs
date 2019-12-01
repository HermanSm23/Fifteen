using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Command
{
    public class DownMoveCommand : ICommand
    {
        private Field field;
        public DownMoveCommand(Field field)
        {
            this.field = field;
        }

        public void Execute()
        {
            field.MoveDown();
        }

        public void Undo()
        {
            field.MoveUp();
        }
    }
}
