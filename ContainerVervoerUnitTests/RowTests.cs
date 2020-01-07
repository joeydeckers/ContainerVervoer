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
            //arrange
            Row testRow = new Row(1, 6, true, true);
            Stack testStackToAdd = new Stack();

            //act
            bool result =  testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void AddStackToRowResultToBeFalse()
        {
            //arrange
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();
            testRow.SetStack(testStackToAddTwo);
            
            //act
            bool result = testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsFalse(result);

        }


        [TestMethod]
        public void AddStackToRowValuableResultToBeTrue()
        {
            //arrange
            Row testRow = new Row(1, 6, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsValuable = false;
            testStackToAdd.ContainsValuable = true;
            testRow.SetStack(testStackToAddTwo);

            //act
            bool result = testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddStackToRowValuableResultToBeFalse()
        {
            //arrange
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsValuable = true;
            testStackToAdd.ContainsValuable = true;
            testRow.SetStack(testStackToAddTwo);

            //act
            bool result = testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void AddStackToRowCooledResultToBeTrue()
        {
            //arrange
            Row testRow = new Row(1, 6, true, true);
            Stack testStackToAdd = new Stack();

            testStackToAdd.ContainsCooled = true;

            //act
            bool result = testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddStackToRowCooledResultToBeFalse()
        {
            //arrange
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsCooled = true;
            testStackToAdd.ContainsCooled = true;
            testRow.SetStack(testStackToAddTwo);

            //act
            bool result = testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddStackToRowSpaceResultToBeTrue()
        {
            //arrange
            Row testRow = new Row(1, 2, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsCooled = true;
            testStackToAdd.ContainsCooled = true;
            testRow.SetStack(testStackToAddTwo);

            //act
            bool result = testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddStackToRowSpaceResultToBeFalse()
        {
            //arrange
            Row testRow = new Row(1, 1, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();

            testStackToAddTwo.ContainsCooled = true;
            testStackToAdd.ContainsCooled = true;
            testRow.SetStack(testStackToAddTwo);

            //act
            bool result = testRow.SetStack(testStackToAdd);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SetLeftWeightTestResultToSucceed()
        {
            //arrange
            Row testRow = new Row(2, 2, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();
            testStackToAdd.AddToStack(new Container(false, false, 200));
            testStackToAdd.AddToStack(new Container(false, false, 200));

            testStackToAddTwo.AddToStack(new Container(false, false, 200));
            testStackToAddTwo.AddToStack(new Container(false, false, 200));

            testRow.SetStack(testStackToAdd);
            testRow.SetStack(testStackToAddTwo);

            //act

            testRow.SetLeftWeight();

            //assert
            Assert.AreEqual(8400, testRow.LeftWeight);
        }

        [TestMethod]
        public void SetLeftWeightRightResultToSucceed()
        {
            //arrange
            Row testRow = new Row(2, 2, true, true);
            Stack testStackToAdd = new Stack();
            Stack testStackToAddTwo = new Stack();
            testStackToAdd.AddToStack(new Container(false, false, 200));
            testStackToAdd.AddToStack(new Container(false, false, 200));

            testStackToAddTwo.AddToStack(new Container(false, false, 200));
            testStackToAddTwo.AddToStack(new Container(false, false, 200));

            testRow.SetStack(testStackToAdd);
            testRow.SetStack(testStackToAddTwo);

            //act

            testRow.SetRightWeight();

            //assert
            Assert.AreEqual(8400, testRow.RightWeight);
        }

    }
}
