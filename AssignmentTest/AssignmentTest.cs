using Assignment;
//using Assignment.AbstractCommand;
using Assignment.InterfaceCommand;

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

        [TestMethod]
        public void PropertiesTest()
        {
            Robot robot1 = new();
            Assert.AreEqual(robot1.NumCommands, 6);
            const int ExpectedCommands = 10;
            Robot robot2 = new(ExpectedCommands);
            Assert.AreEqual(robot2.NumCommands, ExpectedCommands);

            Assert.AreEqual(robot1.IsPowered, false);
            robot1.IsPowered = true;
            Assert.AreEqual(robot1.IsPowered, true);

            Assert.AreEqual(robot1.X, 0);
            // Moves the robot can move even though it is off!!
            // This is very bad! Not good encapsulation
            robot1.X = -5;
            Assert.AreEqual(robot1.X, -5);

            Assert.AreEqual(robot1.Y, 0);
            robot1.Y = -5;
            Assert.AreEqual(robot1.Y, -5);
        }

        [TestMethod]
        public void CommandTest()
        {
            Robot testrobot = new(1);
            Assert.AreEqual(testrobot.IsPowered, false);
            testrobot.LoadCommand(new OnCommand());
            testrobot.Run();
            Assert.AreEqual(testrobot.IsPowered, true);
        }
    }
}
