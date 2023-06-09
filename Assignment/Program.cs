using Assignment.InterfaceCommand;

namespace Assignment
{
    static class Program
    {
        public static bool AssignCommand(Robot robot, string command)
        {
            switch (command)
            {
                case "on":
                    robot.LoadCommand(new OnCommand());
                    break;
                case "off":
                    robot.LoadCommand(new OffCommand());
                    break;
                case "north":
                    robot.LoadCommand(new NorthCommand());
                    break;
                case "south":
                    robot.LoadCommand(new SouthCommand());
                    break;
                case "east":
                    robot.LoadCommand(new EastCommand());
                    break;
                case "west":
                    robot.LoadCommand(new WestCommand());
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid command - Try again");
                    Console.ResetColor();
                    return false;
            }
            return true;
        }
        static void Main()
        {
            // Run your RobotTester class here -> RobotTester.TestRobot()
            Robot newRobot = new();
            Console.WriteLine("Give 6 commands to the robot. Possible commands are: \n on \n off \n north \n south \n east \n west");
            for (int input = 0; input < 6; input++)
            {
                Console.Write($"Assign command #{input + 1}: ");
                bool commandAdded = AssignCommand(newRobot, Console.ReadLine());
                if (!commandAdded)
                {
                    input--;
                }
            }
            newRobot.Run();
        }
    }
}
