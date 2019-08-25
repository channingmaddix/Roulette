using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            WinningBets game = new WinningBets();
            int[] numBoard = new int[]    {1, 2, 3,
                                           4, 5, 6,
                                           7, 8, 9,
                                           10, 11, 12,
                                           13, 14, 15,
                                           16, 17, 18,
                                           19, 20, 21,
                                           22, 23, 24,
                                           25, 26, 27,
                                           28, 29, 30,
                                           31, 32, 33,
                                           34, 35, 36};

            string[] colorBoard = new string[]  {   "R", "B", "R",
                                                    "B", "R", "B",
                                                    "R", "B", "R",
                                                    "B", "B", "R",
                                                    "B", "R", "B",
                                                    "R", "B", "R",
                                                    "R", "B", "R",
                                                    "B", "R", "B",
                                                    "R", "B", "R",
                                                    "B", "B", "R",
                                                    "B", "R", "B",
                                                    "R", "B", "R"     };
            int[,] twoDNumBoard = new int[,]  {    {1, 2, 3},
                                                   {4, 5, 6},
                                                   {7, 8, 9},
                                                   {10, 11, 12},
                                                   {13, 14, 15},
                                                   {16, 17, 18},
                                                   {19, 20, 21},
                                                   {22, 23, 24},
                                                   {25, 26, 27},
                                                   {28, 29, 30},
                                                   {31, 32, 33},
                                                   {34, 35, 36}     };

            string[,] twoDColorBoard = new string[,]  {     {"R", "B", "R"},
                                                            {"B", "R", "B"},
                                                            {"R", "B", "R"},
                                                            {"B", "B", "R"},
                                                            {"B", "R", "B"},
                                                            {"R", "B", "R"},
                                                            {"R", "B", "R"},
                                                            {"B", "R", "B"},
                                                            {"R", "B", "R"},
                                                            {"B", "B", "R"},
                                                            {"B", "R", "B"},
                                                            {"R", "B", "R"}     };
            int bin = 24;
            string color = "";
            for (int i = 0; i < numBoard.Length; i++)
            {
                if (numBoard[i] == bin)
                {
                    color = colorBoard[i];
                }
            }
            Console.WriteLine("Numbers: " + bin);
            game.EvensAndOdds(bin, numBoard);
            game.RedsandBlacks(color, numBoard, colorBoard);
            game.LowsAndHighs(bin, numBoard);
            game.Dozens(bin, numBoard);
            game.Columns(bin);
            game.Streets(bin);
            game.DoubleRows(bin, twoDNumBoard);
            game.Split(bin, twoDNumBoard);
            game.Corners(bin, twoDNumBoard);
        }
    }
}
