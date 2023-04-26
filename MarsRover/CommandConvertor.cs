namespace MarsRover;

public class CommandConvertor
{
    public static void ConvertToCommand(string commandString)
    {
        var charArray = commandString.ToCharArray();
        
        charArray.ToList().ForEach(command =>
        {
            GetCommand(command);
        });
    }

    private static ICommand GetCommand(char commandAsCharacter)
    {
        return commandAsCharacter switch
        {
            'L' => new TurnLeftCommand(),
            'R' => new TurnRightCommand(),
            'M' => Navigator.Move(),
            _ => throw new InvalidCommandException()
        };
    }
}