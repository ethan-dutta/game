using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void boardy(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|_" + board[i, j] + "_|");
                }
                Console.WriteLine();
            }

        }


        static void spr(string spr)
        {
            while (true)
            {
                Console.WriteLine("Lets play Rock, Paper, Scissors! Choose one: ");
                string input = Console.ReadLine();
                Random rps = new Random();
                double rps2 = rps.Next(1, 4);
                Console.WriteLine("You: " + input);
                switch (rps2)
                {
                    case 1:
                        Console.WriteLine("NPC: Rock");
                        break;
                    case 2:
                        Console.WriteLine("NPC: Paper");
                        break;
                    case 3:
                        Console.WriteLine("NPC: Scissors");
                        break;
                }
                if (rps2 == 1 && input == "Paper" || rps2 == 2 && input == "Scissors" || rps2 == 3 && input == "Rock")
                {
                    Console.WriteLine("You win!");
                    break;
                }
                if (rps2 == 1 && input == "Scissors" || rps2 == 2 && input == "Rock" || rps2 == 3 && input == "Paper")
                {
                    Console.WriteLine("Aww, you lose!");
                    break;

                }
                if (rps2 == 1 && input == "Rock" || rps2 == 2 && input == "Paper" || rps2 == 3 && input == "Scissors")
                {
                    Console.WriteLine("You tied!");
                    continue;
                }
            }
        }




        static string winCheck(string[,] board, string turn)
        {
            for (int k = 0; k < 3; k++)
            {
                if (board[k, 0] == board[k, 1] && board[k, 0] == board[k, 2])
                {
                    Console.WriteLine("Player " + turn + " wins!");
                    bool game = true;
                    while (game)
                    {
                        Console.WriteLine("Would you like to play again?");
                        string playagain = Console.ReadLine();
                        if (playagain == "Yes")
                        {
                            Console.WriteLine("Would you like to play Scissors Paper Rock (spr) or Tic Tac Toe (ttt)?");
                            string playagainn = Console.ReadLine();
                            if (playagainn == "spr")
                            {
                                string srr = "0";
                                spr(srr);
                            }
                            else if (playagainn == "ttt")
                            {
                                board[0, 0] = "1";
                                board[0, 1] = "2";
                                board[0, 2] = "3";
                                board[1, 0] = "4";
                                board[1, 1] = "5";
                                board[1, 2] = "6";
                                board[2, 0] = "7";
                                board[2, 1] = "8";
                                board[2, 2] = "9";
                                ttt(board);
                            }
                            else if (playagainn != "ttt" && playagainn != "spr")
                            {
                                Console.WriteLine("Error! Not a game!");
                            }
                        }
                        else
                        {
                            game = false;
                            Environment.Exit(1);
                        }


                    }

                }
                else if (board[0, k] == board[1, k] && board[0, k] == board[2, k])
                {
                    Console.WriteLine("Player " + turn + " wins!");
                    bool game = true;
                    while (game)
                    {
                        Console.WriteLine("Would you like to play again?");
                        string playagain = Console.ReadLine();
                        if (playagain == "Yes")
                        {
                            Console.WriteLine("Would you like to play Scissors Paper Rock (spr) or Tic Tac Toe (ttt)?");
                            string playagainn = Console.ReadLine();
                            if (playagainn == "spr")
                            {
                                string srr = "0";
                                spr(srr);
                            }
                            else if (playagainn == "ttt")
                            {
                                board[0, 0] = "1";
                                board[0, 1] = "2";
                                board[0, 2] = "3";
                                board[1, 0] = "4";
                                board[1, 1] = "5";
                                board[1, 2] = "6";
                                board[2, 0] = "7";
                                board[2, 1] = "8";
                                board[2, 2] = "9";
                                ttt(board);
                            }
                            else if (playagainn != "ttt" && playagainn != "spr")
                            {
                                Console.WriteLine("Error! Not a game!");
                            }
                        }
                        else
                        {
                            game = false;
                            Environment.Exit(1);
                        }
                    }

                }
            }

            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                Console.WriteLine("Player " + turn + " wins!");
                bool game = true;
                while (game)
                {
                    Console.WriteLine("Would you like to play again?");
                    string playagain = Console.ReadLine();
                    if (playagain == "Yes")
                    {
                        Console.WriteLine("Would you like to play Scissors Paper Rock (spr) or Tic Tac Toe (ttt)?");
                        string playagainn = Console.ReadLine();
                        if (playagainn == "spr")
                        {
                            string srr = "0";
                            spr(srr);
                        }
                        else if (playagainn == "ttt")
                        {
                            board[0, 0] = "1";
                            board[0, 1] = "2";
                            board[0, 2] = "3";
                            board[1, 0] = "4";
                            board[1, 1] = "5";
                            board[1, 2] = "6";
                            board[2, 0] = "7";
                            board[2, 1] = "8";
                            board[2, 2] = "9";
                            ttt(board);
                        }
                        else if (playagainn != "ttt" && playagainn != "spr")
                        {
                            Console.WriteLine("Error! Not a game!");
                        }
                    }
                    else
                    {
                        game = false;
                        Environment.Exit(1);
                    }
                }

            }
            else if (board[2, 0] == board[1, 1] && board[0, 0] == board[0, 2])
            {
                Console.WriteLine("Player " + turn + " wins!");
                bool game = true;
                while (game)
                    {
                        Console.WriteLine("Would you like to play again?");
                        string playagain = Console.ReadLine();
                        if (playagain == "Yes")
                        {
                            Console.WriteLine("Would you like to play Scissors Paper Rock (spr) or Tic Tac Toe (ttt)?");
                            string playagainn = Console.ReadLine();
                            if (playagainn == "spr")
                            {
                                string srr = "0";
                                spr(srr);
                            }
                            else if (playagainn == "ttt")
                            {
                                board[0, 0] = "1";
                                board[0, 1] = "2";
                                board[0, 2] = "3";
                                board[1, 0] = "4";
                                board[1, 1] = "5";
                                board[1, 2] = "6";
                                board[2, 0] = "7";
                                board[2, 1] = "8";
                                board[2, 2] = "9";
                                ttt(board);
                            }
                            else if (playagainn != "ttt" && playagainn != "spr")
                            {
                                Console.WriteLine("Error! Not a game!");
                            }
                        }
                        else
                        {
                            game = false;
                            Environment.Exit(1);
                        }

                }
            }

            return turn;
        }

        static string[,] input(string[,] board, string turn)
        {
            bool notValid = true;

            do
            {
                string inp = Console.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (inp == board[i, j] && inp != "X" && inp != "O")
                        {
                            board[i, j] = turn;
                            notValid = false;
                        }
                    }
                }
                if (notValid == true)
                {
                    Console.WriteLine("Error! Invalid move.");
                }
            } while (notValid);
            boardy(board);
            return board;
        }

        static void ttt(string[,] board)
        {
            string start = "Let's play Tic Tac Toe! to start, player 1 select one of the nine slots in the board (a, b, c, etc). That slot will then be crossed out. Player 2 do the same! The first player to get 3 in a row.. WINS!!";
            Console.WriteLine(start);

            string[,] boardd = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            boardy(board);
            Console.WriteLine("Player X turn:");

            string turn = "X";
            while (true)
            {
                board = input(board, "X");
                turn = "X";
                string newturn = turn;
                turn = newturn;
                winCheck(board, turn);
                Console.WriteLine("Player O turn:");
                board = input(board, "O");
                turn = "O";
                winCheck(board, turn);
                Console.WriteLine("Player X turn:");

            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("Welcome to this arcade suite! would you like to play Scissors Paper Rock (spr) or Tic Tac Toe (ttt)?");
            string gamechoice = Console.ReadLine();
                if (gamechoice == "ttt")
                {
                    string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
                    ttt(board);


                }

                else if (gamechoice == "spr")
                {
                    string srr = "0";
                    spr(srr);
                }
                else
                {
                    Console.WriteLine("Error! Not a game.");
                    continue;
                }
            Console.WriteLine("Would you like to play again? Yes/No ");
            string finish = Console.ReadLine();
            if (finish == "Yes")
            {
                Console.WriteLine("Would you like to play Scissors Paper Rock (spr) or Tic Tac Toe (ttt)?");
                string finishh = Console.ReadLine();
                if (finishh == "spr")
                {
                    continue;
                }
                else if (finishh == "ttt")
                {
                    string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
                    ttt(board);
                }
            }
            else
            {
                break;
            }

            }






        }
    }
}



