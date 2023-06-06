using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void PowerTest()
        {
            Robot testRobot = new Robot();
            testRobot.IsPowered = true;
            Assert.AreEqual(testRobot.IsPowered, true);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.IsPowered, false);
        }

        [TestMethod]
        public void WestTest()
        {
            Robot testRobot = new Robot();
            testRobot.IsPowered = true;
            Assert.AreEqual(testRobot.X--, 0);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.X--, -1);
        }

        [TestMethod]
        public void EastTest()
        {
            Robot testRobot = new Robot();
            testRobot.IsPowered = true;
            Assert.AreEqual(testRobot.X++, 0);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.X++, 1);
        }

        [TestMethod]
        public void SouthTest()
        {
            Robot testRobot = new Robot();
            testRobot.IsPowered = true;
            Assert.AreEqual(testRobot.Y--, 0);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.Y--, -1);
        }

        [TestMethod]
        public void NorthTest()
        {
            Robot testRobot = new Robot();
            testRobot.IsPowered = true;
            Assert.AreEqual(testRobot.Y++, 0);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.Y++, 1);
        }
    }
}
