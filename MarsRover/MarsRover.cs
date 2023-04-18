namespace MarsRover;

public class MarsRover
{
    private Orientation _orientation;
    private readonly Coordinates _coordinates;

    public MarsRover()
    {
        _orientation = Orientation.North;
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
        return $"{_coordinates.DisplayCoordinates()}:{_orientation.ToCardinal()}";
    }

    private void Move()
    {
        switch (_orientation)
        {
            case Orientation.North:
                _coordinates.MoveNorth();
                break;
            case Orientation.East:
                _coordinates.MoveEast();
                break;
            case Orientation.South:
                _coordinates.MoveSouth();
                break;
            case Orientation.West:
                _coordinates.MoveWest();
                break;
            default:
                throw new InvalidOrientationException();
        }
    }

    private void TurnRight()
    {
        _orientation = _orientation switch
        {
            Orientation.North => Orientation.East,
            Orientation.East => Orientation.South,
            Orientation.South => Orientation.West,
            Orientation.West => Orientation.North,
            _ => throw new InvalidOrientationException()
        };
    }

    private void TurnLeft()
    {
        _orientation = _orientation switch
        {
            Orientation.North => Orientation.West,
            Orientation.East => Orientation.North,
            Orientation.South => Orientation.East,
            Orientation.West => Orientation.South,
            _ => throw new InvalidOrientationException()
        };
    }
}