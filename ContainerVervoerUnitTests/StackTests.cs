using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerVervoer;

namespace ContainerVervoerUnitTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void AddContainerToStackResultToBeTrue()
        {
            // Arrange
            var testStack = new Stack();
            var testContainer = new Container(true, false, 5000);

            //act
            bool resultToBeTrue = testStack.AddToStack(testContainer);

            //assert
            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void AddContainerToStackWeightToBeFalse()
        {
            // Arrange
            var testStack = new Stack();
            var testContainer = new Container(true, false, 5000);
            var testContainerTwo = new Container(true, false, 50000);
            var testContainerThree = new Container(true, false, 50000);
            testStack.AddToStack(testContainerTwo);
            testStack.AddToStack(testContainerThree);

            //act
            bool resultToBeFalse = testStack.AddToStack(testContainer);

            //assert
            Assert.IsFalse(resultToBeFalse);
        }

        [TestMethod]
        public void AddContainerToStackValuableResultToBeTrue()
        {
            //arrange
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);

            //act
            bool resultToBeTrue = testStack.AddToStack(testContainer);

            //assert
            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void AddContainerToStackValuableResultToBeFalse()
        {
            //arrange
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);
            var testContainerTwo = new Container(true, true, 5000);

            testStack.AddToStack(testContainerTwo);

            //act
            bool resultToBeFalse = testStack.AddToStack(testContainer);

            //assert
            Assert.IsFalse(resultToBeFalse);
        }

        [TestMethod]
        public void CheckIfContainerIsValuableResultToBeTrue()
        {
            //arrange
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);

            //act
            testStack.AddToStack(testContainer);
            bool resultToBeTrue = testStack.ContainsValuable;

            //assert
            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void CheckIfContainerIsValuableResultToBeFalse()
        {
            //arrange
            var testStack = new Stack();
            var testContainer = new Container(false, false, 5000);

            //act
            testStack.AddToStack(testContainer);
            bool resultToBeFalse = testStack.ContainsValuable;
            //assert
            Assert.IsFalse(resultToBeFalse);
        }


        [TestMethod]
        public void CheckIfContainerIsCooledResultToBeTrue()
        {
            //arrange
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);
            testStack.AddToStack(testContainer);

            //act
            bool resultToBeTrue = testStack.ContainsCooled;

            //assert
            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void CheckIfContainerIsCooledResultToBeFalse()
        {
            //arrange
            var testStack = new Stack();
            var testContainer = new Container(false, false, 5000);
            testStack.AddToStack(testContainer);

            //act
            bool resultToBeFalse = testStack.ContainsCooled;

            //assert
            Assert.IsFalse(resultToBeFalse);
        }

        [TestMethod]
        public void CheckIfSetValuableContainerOnTopResultToBeTrue()
        {
            //arrange
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);
            var testContainerTwo = new Container(false, false, 5000);

            //act
            testStack.AddToStack(testContainerTwo);
            testStack.AddToStack(testContainer);


            //assert
            Assert.AreEqual(testStack.Containers[1].IsValuable, true);
        }

        
    }
}
