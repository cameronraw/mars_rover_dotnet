namespace MarsRover
{
    internal enum Orientation
    {
		North,
		East,
		South,
		West
    }
    
    internal static class OrientationExtensions {
	    internal static string ToCardinal(this Orientation orientation)
	    {
		    return orientation switch
		    {
			    Orientation.North => "N",
			    Orientation.East => "E",
			    Orientation.South => "S",
			    Orientation.West => "W",
			    _ => throw new InvalidOrientationException()
		    };
	    }
    }

    internal class InvalidOrientationException : Exception
    {
    }
}
