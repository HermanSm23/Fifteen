using Fifteen;
using Fifteen.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsForFifteen
{
    public class FieldGenerators
    {
        public Field GenerateField(int size)
        {
            var field = new Field(size);
            field.SetGenerator(new FieldNumbers());
            field.GenerateField();
            return field;
        }
    }
}
