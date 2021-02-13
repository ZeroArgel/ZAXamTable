namespace ZAXamTable
{
    /// <summary>
    /// This class is used for save the positions the each element.
    /// </summary>
    public class ZAPosition
    {
        /// <summary>
        /// Constructor empty, for classic instance.
        /// </summary>
        public ZAPosition() { }
        /// <summary>
        /// Constructor with properties, for more easier.
        /// </summary>
        /// <param name="_row">{Type=int}</param>
        /// <param name="_column">{Type=int}</param>
        public ZAPosition(int _row, int _column)
        {
            Row = _row;
            Column = _column;
        }
        /// <summary>
        /// This property save the position in x or row. 
        /// Row {Type=int}, Default=0
        /// </summary>
        public int Row { get; set; } = 0;
        /// <summary>
        /// This property save the position in y or column.
        /// Column {Type=int}, Default=0
        /// </summary>
        public int Column { get; set; } = 0;
    }
}