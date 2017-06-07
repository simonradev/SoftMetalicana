namespace SoftMetalicana.Constants
{
    using SoftMetalicana.Positioning;
    using System.Collections.Generic;
    
    /// <summary>
    /// Provides all variables for the Position.cs
    /// </summary>
    public static class PositionConsants
    {
        /// <summary>
        /// Keys to get the wanted upgrade position.
        /// </summary>
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        /// <summary>
        /// THIS VARIABLE IS USED ONLY FROM POSITION.CS!!!
        /// Provides the wanted upgrade position.
        /// </summary>
        public static readonly Dictionary<Direction, Position> DirectionPositions = new Dictionary<Direction, Position>
        {
            [Direction.Up] = new Position(-1, 0),
            [Direction.Down] = new Position(+1, 0),
            [Direction.Left] = new Position(0, -1),
            [Direction.Right] = new Position(0, +1),
        };
    }
}
