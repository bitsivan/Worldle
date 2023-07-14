// See https://aka.ms/new-console-template for more information
//Sergio Ivan Motejo Olan           sergio.montejo@improving.com          07/14/2023
Console.WriteLine("Hello, World!");

var game = new Game();
game.WordleGame();

class Game
{
    public void WordleGame()
    {
        string wordToGuess = "build";
        string input = null;
        input = Console.ReadLine();
        if (input.Length == 5)
        {
            if (input == wordToGuess)
            {
                Console.WriteLine("Awesome, you guessed the word --> " + wordToGuess);
            }
            else
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == input[i])
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(input[i]);
                    }
                    else if (wordToGuess.Contains(input[i]))
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(input[i]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(input[i]);
                    }
                }
            }
            Console.ResetColor();
            WordleGame();
        }
        else
        {
            Console.BackgroundColor= ConsoleColor.Red;
            Console.WriteLine("The game require a word with 5 letters");
            Console.ResetColor();
            WordleGame();
        }
    }
}