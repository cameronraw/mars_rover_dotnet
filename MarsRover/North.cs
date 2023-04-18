namespace MarsRover;

public class North : IOrientation
{
    public IOrientation TurnRight() 
        => new East();

    public IOrientation TurnLeft()
        => new West();

    public string CurrentState()
        => "N";
}