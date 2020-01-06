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
            testShip.AddContainer(0, 0, 200);

            //assert
            Assert.AreEqual(1, testShip.containersToSort);
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
    }
}
