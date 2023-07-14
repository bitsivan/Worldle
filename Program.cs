using System.Net.Mime;
using System.Linq;
// See https://aka.ms/new-console-template for more information
//Sergio Ivan Motejo Olan           sergio.montejo@improving.com          07/14/2023
Console.WriteLine("Hello, World!");

var game = new Game();
game.WordleGame();

class Game
{
    string wordToGuess = "build";

    public void WordleGame()
    {
        string option = null;

        Console.WriteLine("Single word (type 1) o queue 5 words to try (type 2)");
        option = Console.ReadLine();

        if (option == "1")
        {
            string input = null;
            Console.WriteLine("Write the word");
            Console.WriteLine();
            input = Console.ReadLine();
            this.executeGuessWord(input);
        }
        else if (option == "2")
        {
            IList<string> listWords = new List<string>();
            string wordQ = "";
            Console.WriteLine("Write the 5 words:");
            for (int i = 0; i < 6; i++)
            {
                wordQ = Console.ReadLine();
                listWords.Add(wordQ);
            }
            Console.WriteLine("...checking list of words");

            foreach (var item in listWords)
            {
                executeGuessWord(item);
            }

            Environment.Exit(0);
        }





    }

    public void executeGuessWord(string input)
    {

        if (input.Length == 5)
        {
            if (input == wordToGuess)
            {
                Console.WriteLine("Awesome, you guessed the word --> " + wordToGuess);
                Environment.Exit(0);
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
            Console.WriteLine();
            input = Console.ReadLine();
            executeGuessWord(input);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("The game require a word with 5 letters");
            Console.ResetColor();
            Console.WriteLine(); 
            input = Console.ReadLine();
            executeGuessWord(input);
        }
    }
}