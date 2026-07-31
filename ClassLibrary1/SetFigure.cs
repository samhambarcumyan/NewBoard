namespace ClassLibrary1;
public class SetFigure
{



    public SetFigure(string[,] matrix, char column,int row, char figure )
    {
        row--;
        int _column = 0;
        string figureAsString = figure.ToString();
        switch (column)
        {
            case 'A':
                _column = 0;
                break;
            case 'B':
                _column = 1;
                break;
            case 'C':
                _column = 2;
                break;
            case 'D':
                _column = 3;
                break;
            case 'E':
                _column = 4;
                break;
            case 'F':
                _column = 5;
                break;
            case 'G':
                _column = 6;
                break;
            case 'H':
                _column = 7;
                break;
        }
        matrix[_column, row] = figureAsString;


        
    }



}
