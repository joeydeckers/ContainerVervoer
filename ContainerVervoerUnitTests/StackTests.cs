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
            var testStack = new Stack();
            var testContainer = new Container(true, false, 5000);

            bool resultToBeTrue = testStack.AddToStack(testContainer);

            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void AddContainerToStackWeightToBeFalse()
        {
            var testStack = new Stack();
            var testContainer = new Container(true, false, 5000);
            var testContainerTwo = new Container(true, false, 50000);
            var testContainerThree = new Container(true, false, 50000);
            testStack.AddToStack(testContainerTwo);
            testStack.AddToStack(testContainerThree);

            bool resultToBeFalse = testStack.AddToStack(testContainer);

            Assert.IsFalse(resultToBeFalse);
        }

        [TestMethod]
        public void AddContainerToStackValuableResultToBeTrue()
        {
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);

            bool resultToBeTrue = testStack.AddToStack(testContainer);

            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void AddContainerToStackValuableResultToBeFalse()
        {
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);
            var testContainerTwo = new Container(true, true, 5000);

            testStack.AddToStack(testContainerTwo);

            bool resultToBeFalse = testStack.AddToStack(testContainer);

            Assert.IsFalse(resultToBeFalse);
        }

        [TestMethod]
        public void CheckIfContainerIsValuableResultToBeTrue()
        {
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);


            testStack.AddToStack(testContainer);
            bool resultToBeTrue = testStack.ContainsValuable;
            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void CheckIfContainerIsValuableResultToBeFalse()
        {
            var testStack = new Stack();
            var testContainer = new Container(false, false, 5000);


            testStack.AddToStack(testContainer);
            bool resultToBeFalse = testStack.ContainsValuable;
            Assert.IsFalse(resultToBeFalse);
        }


        [TestMethod]
        public void CheckIfContainerIsCooledResultToBeTrue()
        {
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);


            testStack.AddToStack(testContainer);
            bool resultToBeTrue = testStack.ContainsCooled;
            Assert.IsTrue(resultToBeTrue);
        }

        [TestMethod]
        public void CheckIfContainerIsCooledResultToBeFalse()
        {
            var testStack = new Stack();
            var testContainer = new Container(false, false, 5000);


            testStack.AddToStack(testContainer);
            bool resultToBeFalse = testStack.ContainsCooled;
            Assert.IsFalse(resultToBeFalse);
        }

        [TestMethod]
        public void CheckIfSetValuableContainerOnTopResultToBeTrue()
        {
            var testStack = new Stack();
            var testContainer = new Container(true, true, 5000);
            var testContainerTwo = new Container(false, false, 5000);

            testStack.AddToStack(testContainerTwo);
            testStack.AddToStack(testContainer);

            Assert.AreEqual(testStack.Containers[1].IsValuable, true);
        }

        
    }
}
