using Assignment.InterfaceCommand;

namespace Assignment
{
    static class Program
    {
        static void Main()
        {
            // Run your RobotTester class here -> RobotTester.TestRobot()
            Robot newRobot = new()
            {
                IsPowered = true
            };
            newRobot.LoadCommand(new BachataCommand());
            newRobot.Run();
            Console.WriteLine($"x={newRobot.X} /n y={newRobot.Y}");
        }
    }
}
