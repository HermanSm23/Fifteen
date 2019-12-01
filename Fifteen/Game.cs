using Fifteen.Cells;
using Fifteen.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    public class Game
    {
        private static Game game;
        private Field Field;
        private IFieldCreator FieldCreator;

        private Game()
        {
            FieldCreator = new FieldCreator();
        }

        public static Game getInstance()
        {
            if (game == null)
                game = new Game();
            return game;
        }

        public int?[,] GetField()
        {
            return Field.GetField();
        }

        public void SetGenerator(IFieldCreator fieldCreator)
        {
            FieldCreator = fieldCreator;
        }
    }
}