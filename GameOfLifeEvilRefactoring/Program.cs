using System;
using System.Text;

namespace GameOfLifeEvilRefactoring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bld=run(args);
            Console.Write(bld.ToString());
            Console.ReadLine();
        }

        public static StringBuilder run(string[] args)
        {
            var bld = new StringBuilder();

            var board = InitializeBoardInts();

            InitializeLifeCells(board);

            displayBoard(bld, board);

            int[,] NewBoard = InitializeBoardInts();

            for (int i = 0; i < 10 - 1; i++)
                for (int j = 0; j < 10 - 1; j++)
                {
                    var n = 0;
                    if (i != 0)
                    {
                        if (board[i - 1, j] == 1) n++;
                        if (j != 0 && board[i - 1, j - 1] == 1) n++;
                        if (j != 10 && board[i - 1, j + 1] == 1) n++;
                    }

                    if (j != 0)
                    {
                        if (board[i, j - 1] == 1) n++;
                        if (i != 10 && board[i + 1, j - 1] == 1) n++;
                    }

                    if (i != 10)
                    {
                        if (j != 10 && board[i + 1, j + 1] == 1) n++;
                        if (board[i + 1, j] == 1) n++;
                    }

                    if (j != 10 && board[i, j + 1] == 1) n++;

                    if (n >= 2 && n <= 3)
                    {
                        if (board[i, j] == 1) NewBoard[i, j] = 1;
                        else
                        {
                            if (n == 3) NewBoard[i, j] = 1;
                            else NewBoard[i, j] = 0;
                        }
                    }
                    else NewBoard[i, j] = 0;
                }
                
            board = NewBoard;
            bld.AppendLine();
            //bld.AppendLine();
            //Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bld.Append(board[i, j]);
                }
                bld.AppendLine();
            }

            NewBoard = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    NewBoard[i, j] = 0;
                }
            }

            for (int i = 0; i < 10 - 1; i++)
                for (int j = 0; j < 10 - 1; j++)
                {
                    var n = 0;
                    if (i != 0)
                    {
                        if (board[i - 1, j] == 1) n++;
                        if (j != 0 && board[i - 1, j - 1] == 1) n++;
                        if (j != 10 && board[i - 1, j + 1] == 1) n++;
                    }

                    if (j != 0)
                    {
                        if (board[i, j - 1] == 1) n++;
                        if (i != 10 && board[i + 1, j - 1] == 1) n++;
                    }

                    if (i != 10)
                    {
                        if (j != 10 && board[i + 1, j + 1] == 1) n++;
                        if (board[i + 1, j] == 1) n++;
                    }

                    if (j != 10 && board[i, j + 1] == 1) n++;

                    if (n >= 2 && n <= 3)
                    {
                        if (board[i, j] == 1) NewBoard[i, j] = 1;
                        else
                        {
                            if (n == 3) NewBoard[i, j] = 1;
                            else NewBoard[i, j] = 0;
                        }
                    }
                    else NewBoard[i, j] = 0;
                }

            board = NewBoard;
            bld.AppendLine();
           // Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bld.Append(board[i, j]);
                }
                bld.AppendLine();
            }

            NewBoard = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    NewBoard[i, j] = 0;
                }
            }

            for (int i = 0; i < 10 - 1; i++)
                for (int j = 0; j < 10 - 1; j++)
                {
                    var n = 0;
                    if (i != 0)
                    {
                        if (board[i - 1, j] == 1) n++;
                        if (j != 0 && board[i - 1, j - 1] == 1) n++;
                        if (j != 10 && board[i - 1, j + 1] == 1) n++;
                    }

                    if (j != 0)
                    {
                        if (board[i, j - 1] == 1) n++;
                        if (i != 10 && board[i + 1, j - 1] == 1) n++;
                    }

                    if (i != 10)
                    {
                        if (j != 10 && board[i + 1, j + 1] == 1) n++;
                        if (board[i + 1, j] == 1) n++;
                    }

                    if (j != 10 && board[i, j + 1] == 1) n++;

                    if (n >= 2 && n <= 3)
                    {
                        if (board[i, j] == 1) NewBoard[i, j] = 1;
                        else
                        {
                            if (n == 3) NewBoard[i, j] = 1;
                            else NewBoard[i, j] = 0;
                        }
                    }
                    else NewBoard[i, j] = 0;
                }

            board = NewBoard;
            bld.AppendLine();
           // Console.ReadLine();
           return bld;
        }

        private static void displayBoard(StringBuilder bld, int[,] board)
        {
            for (int i1 = 0; i1 < 10; i1++)
            {
                for (int j1 = 0; j1 < 10; j1++)
                {
                    bld.Append(board[i1, j1]);
                }

                bld.AppendLine();
            }
        }

        private static void InitializeLifeCells(int[,] board)
        {
            board[3, 3] = 1;
            board[3, 4] = 1;
            board[3, 5] = 1;
        }

        private static int[,] InitializeBoardInts()
        {
            int[,] b = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    b[i, j] = 0;
                }
            }

            return b;
        }
    }
}