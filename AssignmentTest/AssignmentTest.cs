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
            Robot testRobot = new() { IsPowered = true };
            Assert.AreEqual(testRobot.IsPowered, true);
            testRobot.IsPowered = false;
            Assert.AreEqual(testRobot.IsPowered, false);
        }

        [TestMethod]
        public void WestCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.X, 0);
            testRobot.LoadCommand(new WestCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new WestCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, -2);
            testRobot.Run();
            Assert.AreEqual(testRobot.X, -4);
        }

        [TestMethod]
        public void EastCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.X, 0);
            testRobot.LoadCommand(new EastCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new EastCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 2);
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 4);
        }

        [TestMethod]
        public void SouthCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.Y, 0);
            testRobot.LoadCommand(new SouthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new SouthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, -2);
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, -4);
        }

        [TestMethod]
        public void NorthCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.Y, 0);
            testRobot.LoadCommand(new NorthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new NorthCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 2);
            testRobot.Run();
            Assert.AreEqual(testRobot.Y, 4);
        }

        [TestMethod]
        public void BachataCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.X, 0);
            Assert.AreEqual(testRobot.Y, 0);
            testRobot.LoadCommand(new BachataCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, 0);
            Assert.AreEqual(testRobot.Y, 0);

            testRobot.IsPowered = true;
            testRobot.LoadCommand(new BachataCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.X, -6);
            Assert.AreEqual(testRobot.Y, 0);
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
        public void OnCommandTest()
        {
            Robot testrobot = new();
            Assert.AreEqual(testrobot.IsPowered, false);
            testrobot.LoadCommand(new OnCommand());
            testrobot.Run();
            Assert.AreEqual(testrobot.IsPowered, true);
            testrobot.Run();
            Assert.AreEqual(testrobot.IsPowered, true);
        }

        [TestMethod]
        public void OffCommandTest()
        {
            Robot testRobot = new();
            Assert.AreEqual(testRobot.IsPowered, false);
            testRobot.IsPowered = true;
            testRobot.LoadCommand(new OffCommand());
            testRobot.Run();
            Assert.AreEqual(testRobot.IsPowered, false);
            testRobot.Run();
            Assert.AreEqual(testRobot.IsPowered, false);
        }
        [TestMethod]
        public void TestAssignCommand()
        {
            Robot robot = new();
            string[] validCommands = { "on", "off", "north", "south", "east", "west" };

            bool result = true;
            foreach (string command in validCommands)
            {
                result &= Program.AssignCommand(robot, command);
            }
            Assert.AreEqual(result, true);
        }
    }
}
