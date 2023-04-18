namespace MarsRover;

public class MarsRover
{
    private IOrientation _orientation;
    private readonly Coordinates _coordinates;

    public MarsRover()
    {
        _orientation = new North();
        _coordinates = new Coordinates(0, 0);
    }

    public string Execute(string commandString)
    {
        var charArray = commandString.ToCharArray();

        charArray.ToList().ForEach(command =>
        {
            switch (command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Move();
                    break;
                default:
                    throw new InvalidCommandException();
            }
        });

        return CurrentStatus();
    }

    private string CurrentStatus()
    {
        return $"{_coordinates.DisplayCoordinates()}:{_orientation.CurrentState()}";
    }

    private void Move()
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

    private void TurnRight()
    {
        _orientation = _orientation.TurnRight();
    }

    private void TurnLeft()
    {
        _orientation = _orientation.TurnLeft();
    }
}