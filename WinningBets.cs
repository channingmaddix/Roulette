using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class WinningBets
    {
        public void EvensAndOdds(int bin, int[] numBoard)
        {
            if (bin % 2 == 0)
            {
                Console.Write("Evens: ");
                for (int i = 0; i < numBoard.Length; i++)
                {
                    if (numBoard[i] % 2 == 0)
                    {
                        Console.Write(numBoard[i] + " ");
                    }
                }
            }
            else
            {
                Console.Write("Odds: ");
                for (int i = 0; i < numBoard.Length; i++)
                {
                    if (numBoard[i] % 2 != 0)
                    {
                        Console.Write(numBoard[i] + " ");
                    }
                }
            }
        }

        public void RedsandBlacks(string bin, int[] numBoard, string[] colorBoard)
        {
            if (bin == "R")
            {
                Console.Write("\nReds: ");
                for (int i = 0; i < numBoard.Length; i++)
                {
                    if (colorBoard[i] == "R")
                    {
                        Console.Write(numBoard[i] + " ");
                    }
                }
            }
            else if (bin == "B")
            {
                Console.Write("\nBlacks: ");
                for (int i = 0; i < numBoard.Length; i++)
                {
                    if (colorBoard[i] == "B")
                    {
                        Console.Write(numBoard[i] + " ");
                    }
                }
            }
            else
                Console.WriteLine("Greens: 0 00");
        }

        public void LowsAndHighs(int bin, int[] numBoard)
        {
            if (bin < 19)
            {
                Console.Write("\nLows: ");
                for (int i = 0; numBoard[i] < 19; i++)
                {
                    Console.Write(numBoard[i] + " ");
                }
            }
            else
            {
                Console.Write("\nHighs: ");
                for (int i = 18; numBoard[i] <= 35; i++)
                {
                    Console.Write(numBoard[i] + " ");
                }
            }
        }
        public void Dozens(int bin, int[] numBoard)
        {
            if (bin >= 1 && bin <= 12)
            {
                Console.Write("\nFirst dozen: ");
                for (int i = 0; i < 12; i++)
                {
                    Console.Write(numBoard[i] + " ");
                }
            }
            else if (bin >= 13 && bin <= 24)
            {
                Console.Write("\nSecond dozen: ");
                for (int i = 12; i < 24; i++)
                {
                    Console.Write(numBoard[i] + " ");
                }
            }
            else if (bin >= 25)
            {
                Console.Write("\nThird dozen: ");
                for (int i = 24; i < numBoard.Length; i++)
                {
                    Console.Write(numBoard[i] + " ");
                }
            }
        }
        public void Columns(int bin)
        {
            int[] firstColumn = new int[12];
            firstColumn[0] = 1;
            for (int i = 1; i < 12; i++)
            {
                firstColumn[i] = firstColumn[i - 1] + 3;
            }
            int[] secondColumn = new int[12];
            secondColumn[0] = 2;
            for (int i = 1; i < 12; i++)
            {
                secondColumn[i] = secondColumn[i - 1] + 3;
            }
            int[] thirdColumn = new int[12];
            thirdColumn[0] = 3;
            for (int i = 1; i < 12; i++)
            {
                thirdColumn[i] = thirdColumn[i - 1] + 3;
            }
            for (int i = 0; i < 12; i++)
            {
                if (firstColumn[i] == bin)
                {
                    Console.Write("\nFirst column: ");
                    foreach (int n in firstColumn)
                    {
                        Console.Write(n + " ");
                    }
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (secondColumn[i] == bin)
                {
                    Console.Write("\nSecond column: ");
                    foreach (int n in secondColumn)
                    {
                        Console.Write(n + " ");
                    }
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (thirdColumn[i] == bin)
                {
                    Console.Write("\nThird column: ");
                    foreach (int n in thirdColumn)
                    {
                        Console.Write(n + " ");
                    }
                }
            }
        }
        public void Streets(int bin)
        {
            if (bin >= 1 && bin <= 3)
                Console.Write("\nStreet 1: 1, 2, 3");

            else if (bin >= 4 && bin <= 6)
                Console.Write("\nStreet 2: 4, 5, 6");

            else if (bin >= 7 && bin <= 9)
                Console.Write("\nStreet 3: 7, 8, 9");

            else if (bin >= 10 && bin <= 12)
                Console.Write("\nStreet 4: 10, 11, 12");

            else if (bin >= 13 && bin <= 15)
                Console.Write("\nStreet 5: 13, 14, 15");

            else if (bin >= 16 && bin <= 18)
                Console.Write("\nStreet 6: 16, 17, 18");

            else if (bin >= 19 && bin <= 21)
                Console.Write("\nStreet 7: 19, 20, 21");

            else if (bin >= 22 && bin <= 24)
                Console.Write("\nStreet 8: 22, 23, 24");

            else if (bin >= 25 && bin <= 27)
                Console.Write("\nStreet 9: 25, 26, 27");

            else if (bin >= 28 && bin <= 30)
                Console.Write("\nStreet 10: 28, 29, 30");

            else if (bin >= 31 && bin <= 33)
                Console.Write("\nStreet 11: 31, 32, 33");

            else if (bin >= 34 && bin <= 36)
                Console.Write("\nStreet 12: 34, 35, 36");
        }
        public void DoubleRows(int bin, int[,] board)
        {
            Console.Write("\nDouble Rows: ");
            for (int k = 0; k < board.GetLength(0); k++)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    if (board[k, i] == bin)
                    {
                        if (k == 0)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write(board[k, j] + " ");
                                Console.Write(board[k + 1, j] + " ");
                            }
                        }
                        else if (k == 11)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write(board[k - 1, j] + " ");
                                Console.Write(board[k, j] + " ");
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write(board[k - 1, j] + " ");
                                Console.Write(board[k, j] + " ");
                                Console.Write(board[k + 1, j] + " ");
                            }
                        }
                    }
                }
            }
        }
        public void Split(int bin, int[,] board)
        {
            Console.Write("\nSplit: ");
            for (int k = 0; k < board.GetLength(0); k++)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    if (board[k, i] == bin)
                    {
                        Console.Write(board[k, i] + " ");
                        if (k == 0)
                        {
                            Console.Write(board[k + 1, i] + " ");
                        }
                        if (k == 11)
                        {
                            Console.Write(board[k - 1, i] + " ");
                        }
                        if (i == 0)
                        {
                            Console.Write(board[k, i + 1] + " ");
                        }
                        if (i == 2)
                        {
                            Console.Write(board[k, i - 1] + " ");
                        }
                        if (k != 0 && k != 11 && i != 0 && i != 2)
                        {
                            Console.Write(board[k - 1, i] + " " + board[k, i + 1] + " " + 
                                board[k + 1, i] + " " + board[k, i - 1]);
                        }
                    }
                }
            }
        }
        public void Corners(int bin, int[,] board)
        {
            Console.Write("\nCorners: ");
            for (int k = 0; k < board.GetLength(0); k++)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    if (board[k, i] == bin)
                    {
                        Console.Write(board[k, i] + " ");
                        if (k == 0 && i == 0)
                        {
                            Console.Write(board[k + 1, i] + " " + board[k + 1, i + 1] + " " + board[k, i + 1]);
                        }
                        else if (k == 11 && i == 2)
                        {
                            Console.Write(board[k - 1, i] + " " + board[k - 1, i - 1] + " " + board[k, i - 1]);
                        }
                        else if (k == 0 && i == 2)
                        {
                            Console.Write(board[k, i - 1] + " " + board[k + 1, i - 1] + " " + board[k + 1, i]);
                        }
                        else if (k == 11 && i == 0)
                        {
                            Console.Write(board[k - 1, i] + " " + board[k - 1, i + 1] + " " + board[k, i + 1]);
                        }
                        else if (k == 0)
                        {
                            Console.Write(board[k, i - 1] + " " + board[k + 1, i - 1] + " " + board[k + 1, i] +
                                " " + board[k + 1, i + 1] + " " + board[k, i + 1]);
                        }
                        else if (k == 11)
                        {
                            Console.Write(board[k, i - 1] + " " + board[k - 1, i - 1] + " " + board[k - 1, i] +
                                " " + board[k - 1, i + 1] + " " + board[k, i + 1]);
                        }
                        else if (i == 0)
                        {
                            Console.Write(board[k - 1, i] + " " + board[k - 1, i + 1] + " " + board[k, i + 1] +
                                " " + board[k + 1, i + 1] + " " + board[k + 1, i]);
                        }
                        else if (i == 2)
                        {
                            Console.Write(board[k - 1, i] + " " + board[k - 1, i - 1] + " " + board[k, i - 1] +
                                " " + board[k + 1, i - 1] + " " + board[k + 1, i]);
                        }
                        else
                        {
                            Console.Write(board[k - 1, i] + " " + board[k - 1, i + 1] + " " + board[k, i + 1] +
                                " " + board[k + 1, i + 1] + " " + board[k + 1, i] + " " + board[k + 1, i - 1] +
                                " " + board[k, i - 1] + " " + board[k - 1, i - 1]);
                        }
                    }
                }
            }
        }
    }
}
