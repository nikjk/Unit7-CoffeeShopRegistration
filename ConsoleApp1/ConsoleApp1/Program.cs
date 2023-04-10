using System;

// Define Roshambo enumeration
public enum Roshambo
{
    Rock,
    Paper,
    Scissors
}

// Define abstract Player class
public abstract class Player
{
    public string Name { get; }
    public Roshambo Choice { get; protected set; }

    public Player(string name)
    {
        Name = name;
    }

    public abstract Roshambo GenerateRoshambo();
}

// Define RockPlayer class
public class RockPlayer : Player
{
    public RockPlayer() : base("RockPlayer")
    {
    }

    public override Roshambo GenerateRoshambo()
    {
        Choice = Roshambo.Rock;
        return Choice;
    }
}

// Define RandomPlayer class
public class RandomPlayer : Player
{
    private readonly Random random = new Random();

    public RandomPlayer() : base("RandomPlayer")
    {
    }

    public override Roshambo GenerateRoshambo()
    {
        Choice = (Roshambo)random.Next(3);
        return Choice;
    }
}

// Define HumanPlayer class
public class HumanPlayer : Player
{
    public HumanPlayer(string name) : base(name)
    {
    }

    public override Roshambo GenerateRoshambo()
    {
        while (true)
        {
            Console.Write("Enter 1 for Rock, 2 for Paper, or 3 for Scissors: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(Roshambo), choice - 1))
            {
                Choice = (Roshambo)(choice - 1);
                return Choice;
            }

            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }
    }
}

// Define main function
public class Program
{
    public static void Main(string[] args)
    {
        // Create human player
        Console.Write("Enter your name: ");
        string humanName = Console.ReadLine();
        HumanPlayer humanPlayer = new HumanPlayer(humanName);

        // Choose opponent
        while (true)
        {
            Console.Write("Enter 1 to play against RockPlayer or 2 to play against RandomPlayer: ");
            if (int.TryParse(Console.ReadLine(), out int opponentChoice) &&
                (opponentChoice == 1 || opponentChoice == 2))
            {
                Player opponent = opponentChoice == 1 ? new RockPlayer() : new RandomPlayer();

                // Play the game
                Roshambo humanChoice = humanPlayer.GenerateRoshambo();
                Roshambo opponentChoice = opponent.GenerateRoshambo();

                Console.WriteLine($"{humanPlayer.Name} chose {humanChoice}");
                Console.WriteLine($"{opponent.Name} chose {opponentChoice}");

                if (humanChoice == opponentChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((humanChoice == Roshambo.Rock && opponentChoice == Roshambo.Scissors) ||
                         (humanChoice == Roshambo.Paper && opponentChoice == Roshambo.Rock) ||
                         (humanChoice == Roshambo.Scissors && opponentChoice == Roshambo.Paper))
                {
                    Console.WriteLine($"{humanPlayer.Name} wins!");
                }
                else
                {
                    Console.WriteLine($"{opponent.Name} wins!");
                }

                break;
            }

            Console.WriteLine("Invalid input. Please enter 1 or 2.");
        }
    }
}