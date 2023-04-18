namespace MarsRover;

public interface IOrientation
{
    public IOrientation TurnRight();
    public IOrientation TurnLeft();
    public string CurrentState();
}