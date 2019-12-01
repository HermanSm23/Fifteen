using System;
using Fifteen;
using Fifteen.Command;
using Fifteen.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFifteen.Commands
{
    [TestClass]
    public class DownMoveCommandTest
    {
        private readonly FieldGenerators fieldGenerators;

        public DownMoveCommandTest()
        {
            fieldGenerators = new FieldGenerators();
        }

        [TestMethod]
        public void Down_Move_Command_Test_Then_Compare_With_New_Desk()
        {
            var field = fieldGenerators.GenerateField(5);
            var newField = fieldGenerators.GenerateField(5);
            var downMove = new DownMoveCommand(field);

            downMove.Execute();

            Assert.AreNotEqual(field.GetField(), newField.GetField());
        }

        [TestMethod]
        public void Down_Move_Command_Test_Then_Up_Move_Command_Then_Compare_With_New_Desk()
        {

            Field field = fieldGenerators.GenerateField(5);
            Field newField = fieldGenerators.GenerateField(5);
            var downMove = new DownMoveCommand(field);
            var upMove = new UpMoveCommand(field);

            upMove.Execute();
            downMove.Execute();


            Assert.IsTrue((field.PointCell.X == newField.PointCell.X) && (field.PointCell.Y == newField.PointCell.Y));
        }
    }
}
