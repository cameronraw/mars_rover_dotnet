namespace MarsRover;

public class MarsRover
{ 
    public void Execute(string commandString)
    {
        CommandConvertor.ConvertToCommand(commandString);
    }
}