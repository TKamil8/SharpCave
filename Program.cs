﻿Console.WriteLine("Let's play Rock-Paper-Scissors!");

while (true)
{
    Console.WriteLine("Provide sign, first player (or write 'quit' to end game):");
    string? firstPlayerSign = Console.ReadLine();

    if (firstPlayerSign == "quit")
    {
        break;
    }

    Console.WriteLine("Provide sign, second player (or write 'quit' to end game):");
    string? secondPlayerSign = Console.ReadLine();

    if (secondPlayerSign =="quit")
    {
        break;
    }

    if (firstPlayerSign == secondPlayerSign)
    {
        Console.WriteLine("It's a draw!");
    }
    else if (firstPlayerSign == "rock" && secondPlayerSign == "scissors")
    {
        Console.WriteLine("First player won!");
    }
    else if (firstPlayerSign == "paper" && secondPlayerSign == "rock")
    {
        Console.WriteLine("First player won!");
    }
    else if (firstPlayerSign == "scissors" && secondPlayerSign == "paper")
    {
        Console.WriteLine("First player won!");
    }
    else
    {
        Console.WriteLine("Second player won!");
    }
}
Console.WriteLine("Press Enter to close the game...");
Console.ReadLine();