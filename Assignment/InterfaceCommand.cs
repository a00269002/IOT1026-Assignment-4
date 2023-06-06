namespace Assignment.InterfaceCommand;

public interface RobotCommand
{
    void Run(Robot robot); // Interfaces are public and abstract by default.
}

class OffCommand : RobotCommand
{
    public void Run(Robot robot) => robot.IsPowered = false;
}

class OnCommand : RobotCommand
{
    public void Run(Robot robot) => robot.IsPowered = true;
}

class WestCommand : RobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
}

class EastCommand : RobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
}

class SouthCommand : RobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
}

class NorthCommand : RobotCommand
{
    public void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
}
