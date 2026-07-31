namespace ClassLibrary1;

    public class BoardBuilder
    {
        private string[,] _board = new string[8, 8];
        public string[,] Board => _board;

        //public string[,] BuildBoard()
        //{
        //    for (int i = 0; i < _board.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < _board.GetLength(1); j++)
        //        {
        //        //if ((i + j) % 2 == 0)
        //        //    _board[i, j] = "#";

        //        //else
        //        //    _board[i, j] = "*";

        //        if ((i + j) % 2 == 0)
        //            Console.BackgroundColor = ConsoleColor.White;
        //        else Console.BackgroundColor = ConsoleColor.Black;

        //        }
        //        Console.WriteLine();
        //    }

        //    return _board;
        //}
    }
