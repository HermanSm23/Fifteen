using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fifteen;
using Fifteen.Command;
using Fifteen.Fields;

namespace UnitTestsForFifteen.Commands
{
    [TestClass]
    public class UpMoveCommandTest
    {
        private readonly FieldGenerators fieldGenerators;

        public UpMoveCommandTest()
        {
            fieldGenerators = new FieldGenerators();
        }

        [TestMethod]
        public void Up_Move_Command_Test_Then_Compare_With_New_Desk()
        {
            var field = fieldGenerators.GenerateField(5);
            var newField = fieldGenerators.GenerateField(5);
            var upMove = new UpMoveCommand(field);

            upMove.Execute();

            Assert.AreNotEqual(field.GetField(), newField.GetField());
        }

        [TestMethod]
        public void Up_Move_Command_Test_Then_Down_Command_Then_Compare_With_New_Desk()
        {

            // \_(*_*)_/
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
