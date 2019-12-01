using System;
using Fifteen.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFifteen.Fields
{
    [TestClass]
    public class FieldNumbersTests
    {
        [TestMethod]
        public void Create_Field_With_Size_5x5_Then_Check_Correct_Lenght_25()
        {
            var fieldFactory = new FieldNumbers();
            var field = fieldFactory.GetField(5);

            Assert.IsTrue(field.Length == 25);
        }

        [TestMethod]
        public void Create_Field_With_Size_50x50_Then_Check_Correct_Lenght_50()
        {
            var fieldFactory = new FieldNumbers();
            var field = fieldFactory.GetField(50);

            Assert.IsTrue(field.Length == 2500);
        }

        [TestMethod]
        public void Create_Field_With_Size_5x5_Then_Check_Correct_Number_On_Position_1x1()
        {
            var fieldFactory = new FieldNumbers();
            var field = fieldFactory.GetField(5);

            Assert.IsTrue(field[1,1].Number == 7);
        }

        [TestMethod]
        public void Create_Field_With_Size_5x5_Then_Check_Uncorrect_Number_On_Position_0x4()
        {
            var fieldFactory = new FieldNumbers();
            var field = fieldFactory.GetField(5);

            Assert.IsFalse(field[0,4].Number == 7);
        }

        [TestMethod]
        public void Create_Field_With_Size_5x5_Then_Check_Last_Cell()
        {
            var fieldFactory = new FieldNumbers();
            var field = fieldFactory.GetField(5);

            Assert.IsTrue(field[4, 4] == null);
        }
    }
}
