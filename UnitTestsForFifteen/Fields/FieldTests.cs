using System;
using Fifteen;
using Fifteen.Cells;
using Fifteen.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForFifteen
{
    [TestClass]
    public class FieldTests
    {
        private readonly FieldGenerators fieldGenerators;

        public FieldTests()
        {
            fieldGenerators = new FieldGenerators();
        }

        [TestMethod]
        public void Check_On_Exists_Field_With_Size_3()
        {
            var field = fieldGenerators.GenerateField(3);

            Assert.IsNotNull(field);
        }

        [TestMethod]
        public void Check_On_Exists_Field_With_Size_20()
        {
            var field = fieldGenerators.GenerateField(20);

            Assert.IsNotNull(field);
        }
    }
}