namespace MarsRover;

public class East : IOrientation
{
    public IOrientation TurnRight()
        => new South();

    public IOrientation TurnLeft()
        => new North();

    public string CurrentState()
        => "E";
}