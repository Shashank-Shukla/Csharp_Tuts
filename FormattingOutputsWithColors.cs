using System;

class Program
{
    static void Main()
    {
        // Write one green line.
        WriteFullLine("This line is green.");
        Console.WriteLine();
        // ... Write another green line.
        WriteFullLine("This line is also green.");
        Console.WriteLine();
    }

    static void WriteFullLine(string value)
    {
        // Write an entire line to the console with the string.
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
        // Reset the color.
        Console.ResetColor();
    }
}
