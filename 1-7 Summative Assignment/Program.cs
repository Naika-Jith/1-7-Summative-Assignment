using System.Text;


namespace _1_7_Summative_Assignment
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            //INTRO

            Console.Title = "Casino, Rock, Paper & Scissors";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.WriteLine("The Casino welcomes you!");
            Console.WriteLine();
            Console.Write("Hey player, please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hey " + name + ", you have recived a letter from the Casino! Beware of opening the letter...");
            Thread.Sleep(2000);
            Console.Beep(200, 500);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠛⠻⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⣠⣶⣶⣄⠙⢿⣿⣿⣿⣿⣿⠋⣡⣤⣄⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⠛⣛⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⣼⣿⣿⣿⣿⣷⠈⣿⣿⣿⡿⢁⣼⣿⣿⣿⣧⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⡏⢸⣿⣆⡙⢛⡛⠻⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⡆⢻⣿⣿⠁⣾⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⡟⢋⣡⣴⣿⣿⣿⣿⣿⡿⢁⣿⣿⣿⣿⣿⠀⣿⣿⣿⣿⣿⣿⣿⣷⠘⣿⡇⢸⣿⣿⣿⣿⣿⣿⣧⢘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣧⡘⠻⢿⣿⣿⣿⣿⣿⡄⢿⣿⣿⣿⣿⣿⠀⣿⣿⣿⣿⣿⣿⣿⣿⠀⣿⡇⣸⣿⣿⣿⣿⣿⣿⡏⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣷⠀⣿⣿⡿⠿⠿⠿⠎⣿⣿⣿⣿⣿⠀⣿⣿⣿⣿⣿⣿⣿⣿⠀⣿⡇⣿⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⡀⠛⣉⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢹⣿⣿⣿⣿⣿⣿⣿⠀⣿⡇⢾⣿⣿⣿⣿⣿⣿⠇⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠘⣿⣿⣿⣿⣿⣿⣿⣤⣌⣤⣼⣿⣿⣿⣿⣿⡟⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⣉⣤⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢁⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⢿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠆⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡗⢠⣴⣦⠘⣿⣿⠏⠙⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⣿⣿⣿⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⡟⢡⣤⣄⢘⣿⣿⡄⠻⢿⣧⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣀⣀⣿⣿⣿⣿⡏⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣷⠈⣿⣿⣾⣿⣿⣧⣤⣌⡙⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡈⠻⢿⡿⠛⠛⠛⢻⣿⡆⢹⣿⣿⣿⠀⢈⠀⢸⣿⣿⣿⣿⣿⣿⣿⡟⢁⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⢾⡇⠸⢿⠿⢘⣿⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⢃⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡈⠻⣤⣤⣴⣾⠟⣡⣤⡌⢉⡛⠛⠛⠋⢉⣩⣉⣥⣤⡖⢀⣙⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣤⣤⡄⢾⣿⣿⣿⣦⣌⣉⣩⣤⣿⣿⣿⣿⠋⠴⡟⢁⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠙⠻⢿⣿⣿⣿⣿⣿⣿⣿⠏⠁⣾⣷⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⠳⣦⣌⡉⢍⣉⣉⣡⠔⣀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣭⣤⣤⣋⣉⣥⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");

            Console.SetCursorPosition(53, 5);
            Console.WriteLine(" -------------------------------------------------------------");
            Console.SetCursorPosition(53, 6);
            Console.WriteLine("|                                                           |");
            Console.SetCursorPosition(53, 7);
            Console.WriteLine("|                 ⚠ OFFICIAL CASINO LETTER ⚠                |");
            Console.SetCursorPosition(53, 8);
            Console.WriteLine("|                                                           |");
            Console.SetCursorPosition(53, 9);
            Console.WriteLine("|  Dear " + name + ",                                              |");
            Console.SetCursorPosition(53, 10);
            Console.WriteLine("|                                                           |");
            Console.SetCursorPosition(53, 11);
            Console.WriteLine("|  You have been invited to play Rock, Paper, Scissors.     |");
            Console.SetCursorPosition(53, 12);
            Console.WriteLine("|  Win money... or lose it all.                             |");
            Console.SetCursorPosition(53, 13);
            Console.WriteLine("|                                                           |");
            Console.SetCursorPosition(53, 14);
            Console.WriteLine("|  Do you have what it takes to survive the Casino?         |");
            Console.SetCursorPosition(53, 15);
            Console.WriteLine("|                                                           |");
            Console.SetCursorPosition(53, 16);
            Console.WriteLine(" -------------------------------------------------------------");

            Console.SetCursorPosition(53, 37);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press ENTER to brave the Casino...");
            Console.ReadLine();
            Console.Clear();

            // GAME SECTION

            int bank = 100;
            int bet;
            string userChoice;
            int computerChoice;

            Random rnd = new Random();

            bool playing = true;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Casino Rock, Paper, Scissors!");
            Console.WriteLine("You start with $100.");
            Console.WriteLine("Type rock, paper, scissors or quit.");
            Console.WriteLine();

            while (playing == true)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Money: $" + bank);

                if (bank > 0)
                {
                    Console.Write("Enter bet OR type quit: ");
                    string betInput = Console.ReadLine().ToLower();

                    if (betInput == "quit")
                    {
                        playing = false;
                    }
                    else
                    {
                        bet = Convert.ToInt32(betInput);

                        if (bet > 0 && bet <= bank)
                        {
                            Console.Write("Choose rock, paper, scissors OR quit: ");
                            userChoice = Console.ReadLine().ToLower();

                            if (userChoice == "quit")
                            {
                                playing = false;
                            }
                            else
                            {
                                computerChoice = rnd.Next(1, 4);

                                string computerMove = "";

                                if (computerChoice == 1)
                                {
                                    computerMove = "rock";
                                }
                                if (computerChoice == 2)
                                {
                                    computerMove = "paper";
                                }
                                if (computerChoice == 3)
                                {
                                    computerMove = "scissors";
                                }

                                Console.WriteLine("Computer chose: " + computerMove);

                                if (userChoice == computerMove)
                                {
                                    Console.WriteLine("Tie! No money lost.");
                                }
                                else if ((userChoice == "rock" && computerMove == "scissors") ||
                                         (userChoice == "paper" && computerMove == "rock") ||
                                         (userChoice == "scissors" && computerMove == "paper"))
                                {
                                    Console.WriteLine("You win!");
                                    bank = bank + bet;
                                }
                                else if (userChoice == "rock" || userChoice == "paper" || userChoice == "scissors")
                                {
                                    Console.WriteLine("You lose!");
                                    bank = bank - bet;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid bet.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You ran out of money!");
                    playing = false;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Game Over.");
            Console.WriteLine("You leave the Casino with $" + bank);
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();

        }
    }
}
