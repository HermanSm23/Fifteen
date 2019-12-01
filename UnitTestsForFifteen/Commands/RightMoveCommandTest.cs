using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fifteen;
using Fifteen.Command;
using Fifteen.Fields;

namespace UnitTestsForFifteen.Commands
{
    [TestClass]
    public class RightMoveCommandTest
    {
        private readonly FieldGenerators fieldGenerators;

        public RightMoveCommandTest()
        {
            fieldGenerators = new FieldGenerators();
        }

        [TestMethod]
        public void Right_Move_Command_Test_Then_Compare_With_New_Desk()
        {
            var field = fieldGenerators.GenerateField(5);
            var newField = fieldGenerators.GenerateField(5);
            var rightMove = new RightMoveCommand(field);

            rightMove.Execute();

            Assert.AreNotEqual(field.GetField(), newField.GetField());
        }

        [TestMethod]
        public void Right_Move_Command_Test_Then_Left_Command_Then_Compare_With_New_Desk()
        {

            // \_(*_*)_/
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
