using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
        {
            Player playerOne;
            Player playerTwo;
            string choiceOne = "rock";
            string choiceTwo = "paper";
            string choiceThree = "scissors";
            int rounds;
            int numberOfRounds;

            public Game()
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors!\n\nPlayer ONE, what is your name?");
                this.playerOne = new Player(Console.ReadLine());
                Console.WriteLine("\nHi player TWO, what is your name? OR enter 'computer'.");
                this.playerTwo = new Player(Console.ReadLine());
                Console.WriteLine("\nHow many rounds do you want to play?");
                numberOfRounds = Convert.ToInt32(Console.ReadLine());
                this.rounds = 1;
            }
            public string answerRandom()
            {
                Random number = new Random();
                int answer = number.Next(1, 4);
                switch (answer)
                {
                    case 1:
                        return choiceOne;
                    case 2:
                        return choiceTwo;
                    default:
                        return choiceThree;
                }
            }
            public void RunGame()
            {
                while (rounds <= numberOfRounds)
                {
                    Console.WriteLine("\n{0}, choose your move.", playerOne.getName());
                    playerOne.setOption(Console.ReadLine());
                    if (playerTwo.getName() == "computer")
                    {
                        playerTwo.setOption(answerRandom());
                    }
                    else {
                        Console.WriteLine("\nMake smart choices, {0}.", playerTwo.getName());
                        playerTwo.setOption(Console.ReadLine());
                    }
                    if (playerOne.getOption() == choiceOne && playerTwo.getOption() == choiceTwo)
                    {
                        Console.WriteLine("\nROUND {0} SUMMARY: \n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!\n\n", playerOne.getName(), choiceOne, playerTwo.getName(), choiceTwo);
                        rounds++;
                        playerTwo.AddOneToScore();
                    }
                    else if (playerOne.getOption() == choiceTwo && playerTwo.getOption() == choiceOne)
                    {
                        Console.WriteLine("\nROUND {0} SUMMARY: \n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {0} WINS!\n\n", playerOne.getName(), choiceTwo, playerTwo.getName(), choiceOne);
                        rounds++;
                        playerOne.AddOneToScore();
                    }
                    else if (playerOne.getOption() == choiceOne && playerTwo.getOption() == choiceThree)
                    {
                        Console.WriteLine("\nROUND {0} SUMMARY: \n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {0} WINS!\n\n", playerOne.getName(), choiceOne, playerTwo.getName(), choiceThree);
                        rounds++;
                        playerOne.AddOneToScore();
                    }
                    else if (playerOne.getOption() == choiceThree && playerTwo.getOption() == choiceOne)
                    {
                        Console.WriteLine("\nROUND {0} SUMMARY: \n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!\n\n", playerOne.getName(), choiceThree, playerTwo.getName(), choiceOne);
                        rounds++;
                        playerTwo.AddOneToScore();
                    }
                    else if (playerOne.getOption() == choiceThree && playerTwo.getOption() == choiceTwo)
                    {
                        Console.WriteLine("\nROUND {0} SUMMARY: \n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {0} WINS!\n\n", playerOne.getName(), choiceThree, playerTwo.getName(), choiceTwo);
                        rounds++;
                        playerOne.AddOneToScore();
                    }
                    else if (playerOne.getOption() == choiceTwo && playerTwo.getOption() == choiceThree)
                    {
                        Console.WriteLine("\n ROUND {0} SUMMARY: \n", rounds);
                        Console.WriteLine("{0} chose {1} and {2} chose {3},\n {2} WINS!\n\n", playerOne.getName(), choiceTwo, playerTwo.getName(), choiceThree);
                        rounds++;
                        playerTwo.AddOneToScore();
                    }
                    else
                        Console.WriteLine("\n\nIt's a tie!\n Try again\n\n");
                }

                Console.WriteLine("Final score:\n {0} has {1}\n {2} has {3}", playerOne.getName(), playerOne.getScore(), playerTwo.getName(), playerTwo.getScore());
            }
        }
}
 