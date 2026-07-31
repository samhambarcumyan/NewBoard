public class Coordinates
{
    private char _column;
    private int _row;
    public char GetColumnCoordinate
    {
        get {return _column;}
        set
        {
            if(value < 1 || value > 8)
                throw new ArgumentOutOfRangeException("The valid column coordinate is between 1 and 8");
            _column = value;
        }
    }
    public int GetRowCoordinate
    {
        get {return _row;}
        set
        {
            if (value < 'A' || value > 'H')
                throw new ArgumentOutOfRangeException("The valid row coordinate is between A and H");
            _row = value;
        } 
        
    }
    public Coordinates(char columnCoordinate, int rowCoordinate)
    {
        GetColumnCoordinate = columnCoordinate;
        GetRowCoordinate = rowCoordinate;
    }
}
