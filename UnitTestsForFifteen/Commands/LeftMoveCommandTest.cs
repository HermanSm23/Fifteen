using System;
using Fifteen;
using Fifteen.Command;
using Fifteen.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFifteen.Commands
{
    [TestClass]
    public class LeftMoveCommandTest
    {
        private readonly FieldGenerators fieldGenerators;

        public LeftMoveCommandTest()
        {
            fieldGenerators = new FieldGenerators();
        }

        [TestMethod]
        public void Left_Move_Command_Test_Then_Compare_With_New_Desk()
        {
            var field = fieldGenerators.GenerateField(5);
            var newField = fieldGenerators.GenerateField(5);

            var leftMove = new LeftMoveCommand(field);

            leftMove.Execute();

            Assert.AreNotEqual(field.GetField(), newField.GetField());
        }

        [TestMethod]
        public void Left_Move_Command_Test_Then_Right_Command_Then_Compare_With_New_Desk()
        {
            var field = fieldGenerators.GenerateField(5);
            var newField = fieldGenerators.GenerateField(5);
            var leftMove = new LeftMoveCommand(field);
            var rightMove = new RightMoveCommand(field);

            leftMove.Execute();
            rightMove.Execute();

            Assert.IsTrue((field.PointCell.X == newField.PointCell.X) && (field.PointCell.Y == newField.PointCell.Y));
        }
    }
}
