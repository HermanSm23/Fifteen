using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Command
{
    public class UpMoveCommand : ICommand
    {
        private Field field;
        public UpMoveCommand(Field field)
        {
            this.field = field;
        }

        public void Execute()
        {
            field.MoveUp();
        }

        public void Undo()
        {
            field.MoveDown();
        }
    }
}
