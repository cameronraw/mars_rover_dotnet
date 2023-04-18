namespace MarsRover;

public class South : IOrientation
{
    public IOrientation TurnRight()
        => new West();

    public IOrientation TurnLeft()
        => new East();

    public string CurrentState()
        => "S";
}