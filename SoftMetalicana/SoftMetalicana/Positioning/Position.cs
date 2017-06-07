namespace SoftMetalicana.Positioning
{
    using System.Collections.Generic;
    using SoftMetalicana.Constants;
    
    /// <summary>
    /// This class represents a single cell on the console. Row and Column.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Provides the wanted upgrade position.
        /// </summary>
        public static readonly Dictionary<PositionConsants.Direction, Position> DirectionPositions = 
                                                            PositionConsants.DirectionPositions;

        /// <summary>
        /// Private fields for the row and column.
        /// Can't be accessed directly.
        /// </summary>
        private int row;
        private int col;

        /// <summary>
        /// Sets the initial values of the row and column.
        /// </summary>
        /// <param name="row">The row in the console that you want.</param>
        /// <param name="col">The column in the console that you want.</param>
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        /// <summary>
        /// Property that gives you the permission to get and set the row.
        /// </summary>
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }

        /// <summary>
        /// Property that gives you the permission to get and set the column.
        /// </summary>
        public int Col
        {
            get { return this.col; }
            set { this.col = value; }
        }
    }
}
