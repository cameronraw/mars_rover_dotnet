namespace MarsRover
{
    internal class Coordinates
    {
		private int X;
		private int Y;

        public Coordinates(int x, int y)
        {
			X = x;
			Y = y;
        }

        public string DisplayCoordinates()
        {
	        return $"{X}:{Y}";
        }

        public void MoveNorth()
        {
	        Y++;
        }
        
        public void MoveEast()
        {
	        X++;
        }
        public void MoveSouth()
        {
	        Y--;
        }
        public void MoveWest()
        {
	        X--;
        }
    }
}
