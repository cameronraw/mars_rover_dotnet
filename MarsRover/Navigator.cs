namespace MarsRover;

public class Navigator
{
    private IOrientation _orientation;
    private readonly Coordinates _coordinates;

    public Navigator()
    {
        _orientation = new North();
        _coordinates = new Coordinates(0, 0);
    }
    
    public Navigator(IOrientation orientation, Coordinates coordinates)
    {
        _orientation = orientation;
        _coordinates = coordinates;
    }
    
    public  string CurrentStatus() 
        => $"{_coordinates.DisplayCoordinates()}:{_orientation.CurrentState()}";
    
    public void Move()
    {
        switch (_orientation)
        {
            case North:
                _coordinates.MoveNorth();
                break;
            case East:
                _coordinates.MoveEast();
                break;
            case South:
                _coordinates.MoveSouth();
                break;
            case West:
                _coordinates.MoveWest();
                break;
            default:
                throw new InvalidOrientationException();
        }
    }
    
    public void TurnRight()
    {
        _orientation = _orientation.TurnRight();
    }

    public void TurnLeft()
    {
        _orientation = _orientation.TurnLeft();
    }
}