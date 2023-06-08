// Change to 'using Assignment.InterfaceCommand' when you are ready to test your interface implementation
//using Assignment.AbstractCommand;
using Assignment.InterfaceCommand;

namespace Assignment;

public class Robot
{
    // These are properties, you can replace these with traditional getters/setters if you prefer.
    public int NumCommands { get; }
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }

    private const int DefaultCommands = 6;
    // An array is not the preferred data structure here.
    // You will get bonus marks if you replace the array with the preferred data structure
    // Hint: It is NOT a list either,
    private readonly RobotCommand[] _commands;
    private int _commandsLoaded = 0;

    public override string ToString()
    {
        return $"[{X} {Y} {IsPowered}]";
    }

    /// <summary>
    /// Constructor named "Robot" with no parameters. It has an initializer that calls another constructor
    /// </summary>
    /// <constructor>
    /// <modifier>public</modifier>
    /// <name>Robot</name>
    /// <parameters></parameters>
    /// <initializer>this(DefaultCommands)</initializer>
    /// <body>{ }</body>
    /// </constructor>
    public Robot() : this(DefaultCommands) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Robot"/> class with a specified number of commands.
    /// </summary>
    /// <param name="numCommands">The number of commands for the robot.</param>
    public Robot(int numCommands)
    {
        _commands = new RobotCommand[numCommands];
        NumCommands = numCommands;
    }

    /// <summary>
    /// Executes the loaded commands for the robot and prints the robot's state after each command execution.
    /// </summary>
    public void Run()
    {
        for (var i = 0; i < _commandsLoaded; ++i)
        {
            _commands[i].Run(this);
            Console.WriteLine(this);
        }
    }

    /// <summary>
    /// Loads a command into the robot's command list.
    /// </summary>
    /// <param name="command">The command to be loaded.</param>
    /// <returns>
    /// <c>true</c> if the command was successfully loaded;
    /// otherwise, <c>false</c> if the command list is already full.
    /// </returns>
    public bool LoadCommand(RobotCommand command)
    {
        if (_commandsLoaded >= NumCommands)
            return false;
        _commands[_commandsLoaded++] = command;
        return true;
    }
}
