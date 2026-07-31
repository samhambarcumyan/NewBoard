using ClassLibrary1;
using System.Data.Common;
BoardBuilder boardBuilder = new BoardBuilder();

string[,] Matrix = boardBuilder.Board;
PrintLetters();
PrintBoard(Matrix);
char figureAsChar = GetFigure();
var Checkfigure = new Figure(figureAsChar);
char checkedFigure = Checkfigure.GetFigureName;
Console.WriteLine("figure is created");
var coordinates = GetCoordinates();
int rowCoordinate = coordinates.Item1;
char columnCoordinate = coordinates.Item2;
FigureSetter(Matrix,columnCoordinate,rowCoordinate,checkedFigure);




#region Methods

void FigureSetter(string[,] board, char column, int row, char figure)
{

    string figureAsString = figure.ToString();
    int columnAsInt = 0;
    row--;
    switch (column)
    {
        case 'A':
            columnAsInt = 0;
            break;
        case 'B':
            columnAsInt = 1;
            break;
        case 'C':
            columnAsInt = 2;
            break;
        case 'D':
            columnAsInt = 3;
            break;
        case 'E':
            columnAsInt = 4;
            break;
        case 'F':
            columnAsInt = 5;
            break;
        case 'G':
            columnAsInt = 6;
            break;
        case 'H':
            columnAsInt = 7;
            break;
    }

    PrintLetters();
    board[columnAsInt, row] = figureAsString;
    PrintBoard(board);
}

void PrintBoard(string[,] board)
{
    int boardNumber = 1;

    for (int i = 0; i < board.GetLength(0); i++)
    {
        Console.Write(boardNumber + " ");

        for (int j = 0; j < board.GetLength(1); j++)
        {
            bool isWhite = (i + j) % 2 == 0;

            Console.BackgroundColor = isWhite
                ? ConsoleColor.White
                : ConsoleColor.Black;

            if (board[i, j] == null)
            {
                Console.Write("  ");
            }
            else
            {
                Console.Write(board[i, j] + " ");
            }

            Console.ResetColor();
        }

        Console.WriteLine();
        boardNumber++;
    }
}

//void PrintBoard(string[,] board)
//{
//    int boardNumber = 1;

//    for (int i = 0; i < board.GetLength(0); i++)
//    {
//        Console.Write(boardNumber + " ");
//        for (int j = 0; j < board.GetLength(1); j++)
//        {
//            Console.Write(board[i, j] + " ");
//            //if (board[i, j] == "W")
//            //{
//            //    board[i, j] = "  ";
//            //    Console.BackgroundColor = ConsoleColor.White;
//            //    Console.Write(board[i, j]);
//            //}

//            //else
//            //{
//            //    board[i, j] = "  ";
//            //    Console.BackgroundColor = ConsoleColor.Black;
//            //    Console.Write(board[i, j]);
//            //}
//            //Console.ResetColor();
//        }
//        Console.WriteLine();
//        boardNumber++;
//    }
//}
void PrintLetters()
{
    Console.Write("  ");
    foreach(var letter in Enum.GetValues(typeof(BoardLettersAndFigures.Letters)))
    {
        Console.Write(letter + " ");
    }
    Console.WriteLine();
}


char GetFigure()
{
    Console.WriteLine("enter figure name ex. P, R, B, K, Q, N");
    string input = Console.ReadLine();
    input = input.ToUpper();
    while (input.Length != 1)
    {
        Console.WriteLine("invalid figure try again");
        input = Console.ReadLine();
        input = input.ToUpper();
    }
    char inputAsChar = input[0];
    return inputAsChar;
}


(int,char) GetCoordinates()
{
    Console.WriteLine("enter row coordinate 1 - 8");
    bool isNum = int.TryParse(Console.ReadLine(), out int rowCoordinate);
    while (!isNum)
    {
        Console.WriteLine("invalid coordinate try again");
        isNum = int.TryParse(Console.ReadLine(), out rowCoordinate);
    }

    Console.WriteLine("enter column coordinate A - H");
    string columnCoordinateAsString = Console.ReadLine();
    while(columnCoordinateAsString.Length != 1)
    {
        Console.WriteLine("invalid coordinate try again");
        columnCoordinateAsString = Console.ReadLine();
    }
    char columnCoordinateAsChar = columnCoordinateAsString.ToUpper()[0];
    
    return (rowCoordinate,columnCoordinateAsChar);
}


//foreach(var e in Enum.GetValues(typeof(BoardLettersAndFigures.Figures)))
//{
//    Console.WriteLine($"the number under {e} is {(int)e}");
//}

#endregion