using Fifteen.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen.Fields
{
    public class FieldCreator : IFieldCreator
    {
        public void Create(Field field, int iterCount)
        {
            var random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < iterCount; i++)
            {
                switch (random.Next() % 4)
                {
                    case 0:
                        field.MoveDown();
                        break;
                    case 1:
                        field.MoveUp();
                        break;
                    case 2:
                        field.MoveLeft();
                        break;
                    case 3:
                        field.MoveRight();
                        break;
                }
            }
        }
    }
}
