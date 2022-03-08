using System;

namespace Rohit
{
    internal class Program
    {
       public static char[,] ticTacToe = new char[3, 3]
               {
                 {'1','2','3'},
                 {'4','5','6'},
                 {'7','8','9'},
               };
        public static void Main(string[] args)     
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int input, player = 2, count = 0;
            setField();
            do
            {
                if (player == 1)
                {
                    player = 2;
                }
                else if (player == 2)
                {
                    player = 1;
                }
                Console.Write("Player {0}!\nyour turn! Enter Input :", player);
                input =Convert.ToInt32(Console.ReadLine());
                 playGame(player, input);
                setField();
                bool check = checkField(player,count);
            
                if (check)
                {
                    if (count == 9)
                        Console.WriteLine("Match Draw!");
                    else
                       Console.WriteLine("player {0} wins the game",player);
                    Console.WriteLine("press any key to restart");
                    Console.ReadKey();
                    int p = 48;
                    for(int i=0 ,j=0;i<ticTacToe.GetLength(0);i++)
                    {
                        ticTacToe[i, j] = (char)++p;
                        ticTacToe[i, j+1] = (char)++p;
                        ticTacToe[i, j+2] = (char)++p;

                    }
                    Console.Clear();
                    setField();
                    player = 2;
                    count = 0;
                }
                count++;
                

            } while (true);


            Console.Read();
        }
        public static void setField()
        {
            Console.Clear();
            for(int i = 0,j=0; i < ticTacToe.GetLength(0); i++)
            {
                Console.WriteLine("   |   |  ");
                Console.WriteLine(" {0} | {1} | {2} ", ticTacToe[i, j], ticTacToe[i, j + 1], ticTacToe[i, j + 2]);
                if(i<2)
                 Console.WriteLine("___|___|___");
                else
                    Console.WriteLine("   |   |  ");
            }
           
        }
        public static void playGame(int player,int input)
        {
            char playerSign = ' ';
            if(player==1)
            {
                playerSign = 'x';
            }
            else if(player==2)
            {
                playerSign = 'o';
            }
            switch(input)
            {
                case 1:
                    {
                        if (ticTacToe[0, 0] != '1')
                        {
                            Console.WriteLine("Invalid Input!");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            ticTacToe[0, 0] = playerSign;
                            break;
                        }
                    }
                case 2:
                    {
                        if(ticTacToe[0, 1] != '2')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                           
                        }
                        ticTacToe[0, 1] = playerSign;
                        break;
                    }
                case 3:
                    {
                        if(ticTacToe[0, 2] != '3')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                           
                        }
                        ticTacToe[0, 2] = playerSign;
                        break;
                    }
                case 4:
                    {
                        if(ticTacToe[1, 0] != '4')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        ticTacToe[1, 0] = playerSign;
                        break;
                    }
                case 5:
                    {
                        if(ticTacToe[1, 1] != '5')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();                        
                            Console.Clear();
                            break;
                        }
                        ticTacToe[1, 1] = playerSign;
                        break;
                    }
                case 6:
                    {
                        if(ticTacToe[1, 2] != '6')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        ticTacToe[1, 2] = playerSign;
                        break;
                    }
                case 7:
                    {
                        if(ticTacToe[2, 0] != '7')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        ticTacToe[2, 0] = playerSign;
                        break;
                    }
                case 8:
                    {
                        if(ticTacToe[2, 1] != '8')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        ticTacToe[2, 1] = playerSign;
                        break;
                    }
                case 9:
                    {
                        if(ticTacToe[2,2] != '9')
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Enter any key to try again");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        ticTacToe[2, 2] = playerSign;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }
           
        }
        public static bool checkField(int player,int count)
        {
            bool check = false;
            for(int i=0,j=0;i<ticTacToe.GetLength(0);i++)
            {
                if(ticTacToe[i,j]=='x'&&ticTacToe[i,j+1]=='x'&&ticTacToe[i,j+2]=='x')
                {
                    check = true;
                }
                else if (ticTacToe[i, j] == 'o' && ticTacToe[i, j + 1] == 'o' && ticTacToe[i, j + 2] == 'o')
                {
                    check = true;

                }

            }
            for(int j=0,i=0;j<ticTacToe.GetLength(1);j++)
            {
                if (ticTacToe[i, j] == 'x' && ticTacToe[i+1, j] == 'x' && ticTacToe[i+2, j] == 'x')
                {
                    check = true;
                }
                else if (ticTacToe[i, j] == 'o' && ticTacToe[i+1, j] == 'o' && ticTacToe[i+2, j] == 'o')
                {
                    check = true;
                }
            }


            if (ticTacToe[0, 0] == 'x' && ticTacToe[1, 1] == 'x' && ticTacToe[2, 2] == 'x')
            {
                check = true;
            }
            else if (ticTacToe[0, 2] == 'x' && ticTacToe[1, 1] == 'x' && ticTacToe[2, 0] == 'x')
            {
                check = true;

            }
            else if (ticTacToe[0, 0] == 'o' && ticTacToe[1, 1] == 'o' && ticTacToe[2, 2] == 'o')
            {
                check = true;
            }
            else if (ticTacToe[0, 2] == 'o' && ticTacToe[1, 1] == 'o' && ticTacToe[2, 0] == 'o')
            {
                check = true;

            }
            else if (count == 9)
                check = true;


            return check;
        }
        
    }
    }
