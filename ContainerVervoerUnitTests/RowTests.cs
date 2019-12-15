using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerVervoer;

namespace ContainerVervoerUnitTests
{
    [TestClass]
    public class RowTests
    {
        [TestMethod]
        public void AddStackToRowResultToBeTrue()
        {
            Row testRow = new Row(1, 6, true);
            Stack testStackToAdd = new Stack();

            bool result =  testRow.SetStack(testStackToAdd);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void AddStackToRowResultToBeFalse()
        {
            Row testRow = new Row(1, 1, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();
            testRow.SetStack(testStackToAddTwo);

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsFalse(result);

        }
    }
}
