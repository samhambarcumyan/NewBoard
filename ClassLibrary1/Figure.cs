public class Figure
{
    private char _figureName;
    public char GetFigureName
    {
        get { return _figureName; }

        set
        {
            foreach(var figure in Enum.GetValues(typeof(BoardLettersAndFigures.Figures)))
            {
                if (value == figure.ToString()[0])
                {
                    _figureName  = value;
                    return;
                }
            }
            throw new ArgumentException("Invalid figure: Valid figures are P, R, B, K, Q, N");
        }
    }
    public Figure(char FigureName)
    {
        GetFigureName = FigureName;
    }
}
