namespace MarsRover;

public class West : IOrientation
{
    public IOrientation TurnRight()
        => new North();

    public IOrientation TurnLeft()
        => new South();

    public string CurrentState()
        => "W";
}