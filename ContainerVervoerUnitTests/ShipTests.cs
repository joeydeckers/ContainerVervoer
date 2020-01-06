using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerVervoer;

namespace ContainerVervoerUnitTests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void AddContainerResultToSucceed()
        {
            //arrange
            Ship testShip = new Ship(4, 4);
            
            //act
            testShip.AddContainer(1, 1, 200);

            //assert
            Assert.AreEqual(1, testShip.containersToSort.Count);
        }

        [TestMethod]
        public void AddContainerResultToFail()
        {
            //arrange
            Ship testShip = new Ship(4, 4);

            //act
            testShip.AddContainer(0, 0, 2000000);

            //assert
            Assert.AreEqual(0, testShip.containersToSort.Count);
        }

        [TestMethod]
        public void SortContainerResultToSucceed()
        {
            //arrange
            Ship testShip = new Ship(4, 4);

            //act
            testShip.AddContainer(0, 0, 2000);
            testShip.AddContainer(0, 0, 2000);
            testShip.AddContainer(0, 0, 2000);
            testShip.AddContainer(0, 0, 2000);

            testShip.SortContainers();

            //assert
            Assert.AreEqual(1, testShip.stacks.Count);
        }

        [TestMethod]
        public void CreateRowsResultToSucceed()
        {
            //arrange & act
            Ship testShip = new Ship(4, 4);

            //assert
            Assert.AreEqual(4, testShip.rows.Count);
        }

        [TestMethod]
        public void AddStackToRowResultToSucceed()
        {
            //arrange 
            Ship testShip = new Ship(4, 4);
            testShip.AddContainer(0, 0, 2000);
            testShip.AddContainer(0, 0, 2000);
            testShip.AddContainer(0, 0, 2000);
            testShip.AddContainer(0, 0, 2000);
            testShip.SortContainers();

            //act
            testShip.AddStackToRow();
            //assert
            Assert.AreEqual(0, testShip.stacks.Count);
        }

        [TestMethod]
        public void AddStackToRowResultToFail()
        {
            //arrange 
            Ship testShip = new Ship(1, 1);
            testShip.AddContainer(1, 0, 2000);
            testShip.AddContainer(1, 0, 2000);
            testShip.AddContainer(1, 0, 2000);
            testShip.AddContainer(1, 0, 2000);
            testShip.SortContainers();

            //act
            testShip.AddStackToRow();
            //assert
            Assert.AreEqual(3, testShip.stacks.Count);
        }

        [TestMethod]
        public void ShipCheckBalanceResultToBeBelanced()
        {
            //arrange 
            Ship testShip = new Ship(2, 2);
            testShip.AddContainer(1, 0, 2000);
            testShip.AddContainer(1, 0, 2000);
            testShip.AddContainer(1, 0, 2000);
            testShip.AddContainer(1, 0, 2000);
            testShip.SortContainers();
            testShip.AddStackToRow();

            //act
            bool result = testShip.IsInBalance;
            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShipCheckBalanceResultToBeBelancedNot()
        {
            //arrange 
            Ship testShip = new Ship(2, 2);
            testShip.AddContainer(1, 0, 20000);
            testShip.SortContainers();
            testShip.AddStackToRow();

            //act
            bool result = testShip.IsInBalance;
            //assert
            Assert.IsFalse(result);
        }
    }
}
