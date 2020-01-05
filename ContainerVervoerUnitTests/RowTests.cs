using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerVervoer;
using System.Collections.Generic;
using System.Linq;

namespace ContainerVervoerUnitTests
{
    [TestClass]
    public class RowTests
    {
        [TestMethod]
        public void AddStackToRowResultToBeTrue()
        {
            Row testRow = new Row(1, 6, true, true);
            Stack testStackToAdd = new Stack();

            bool result =  testRow.SetStack(testStackToAdd);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void AddStackToRowResultToBeFalse()
        {
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();
            testRow.SetStack(testStackToAddTwo);

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsFalse(result);

        }


        [TestMethod]
        public void AddStackToRowValuableResultToBeTrue()
        {
            Row testRow = new Row(1, 6, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsValuable = false;
            testStackToAdd.ContainsValuable = true;
            testRow.SetStack(testStackToAddTwo);

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddStackToRowValuableResultToBeFalse()
        {
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsValuable = true;
            testStackToAdd.ContainsValuable = true;
            testRow.SetStack(testStackToAddTwo);

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsFalse(result);
        }


        [TestMethod]
        public void AddStackToRowCooledResultToBeTrue()
        {
            Row testRow = new Row(1, 6, true, true);
            Stack testStackToAdd = new Stack();

            testStackToAdd.ContainsCooled = true;

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddStackToRowCooledResultToBeFalse()
        {
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsCooled = true;
            testStackToAdd.ContainsCooled = true;
            testRow.SetStack(testStackToAddTwo);

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddStackToRowSpaceResultToBeTrue()
        {
            Row testRow = new Row(1, 2, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsCooled = true;
            testStackToAdd.ContainsCooled = true;
            testRow.SetStack(testStackToAddTwo);

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddStackToRowSpaceResultToBeFalse()
        {
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsCooled = true;
            testStackToAdd.ContainsCooled = true;
            testRow.SetStack(testStackToAddTwo);

            bool result = testRow.SetStack(testStackToAdd);

            Assert.IsFalse(result);
        }

        // tests maken voor gewicht toevoegen
    }
}
