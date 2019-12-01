using System;
using Fifteen.Cells;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFifteen
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void Check_On_Exist_Cell_With_Positive_Number_Test1()
        {
            var cellFactory = new NumberCell();
            var cell = cellFactory.GetCell(1);

            Assert.IsTrue(cell.Number == 1);
        }

        [TestMethod]
        public void Check_On_Exist_Cell_With_Positive_Number_Test2()
        {
            var cellFactory = new NumberCell();
            var cell = cellFactory.GetCell(50);

            Assert.IsTrue(cell.Number == 50);
        }

        [TestMethod]
        public void Check_On_Exist_Cell_With_Negative_Number_Test1()
        {
            var cellFactory = new NumberCell();
            var cell = cellFactory.GetCell(-1);

            Assert.IsTrue(cell.Number == -1);
        }

        [TestMethod]
        public void Check_On_Exist_Cell_With_Negative_Number_Test2()
        {
            var cellFactory = new NumberCell();
            var cell = cellFactory.GetCell(-50);

            Assert.IsTrue(cell.Number == -1);
        }

        [TestMethod]
        public void Compare_Two_Cells_On_True()
        {
            var cellFactory = new NumberCell();
            var cell1 = cellFactory.GetCell(5);
            var cell2 = cellFactory.GetCell(5);

            Assert.IsTrue(cell1.Number == cell2.Number);
        }

        [TestMethod]
        public void Compare_Two_Cells_On_False()
        {
            var cellFactory = new NumberCell();
            var cell1 = cellFactory.GetCell(5);
            var cell2 = cellFactory.GetCell(1);

            Assert.IsFalse(cell1.Number == cell2.Number);
        }
    }
}
