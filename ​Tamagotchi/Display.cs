using System;


public class Display
{
    public static void Line(string text)
    {
        string space = "";
        for (int i = 0; i < (38 - text.Length) / 2; i++)
        {
            space += " ";
        }

        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine($"|{space}{text}{space}|");
        System.Console.WriteLine("----------------------------------------");
    }
    public static void Do()
    {
        string text = " Mata | Nytt ord | Lek | Ignorera ";
        Line(text);
        string input = Console.ReadLine();
        Console.Clear();
        logic.CheckInput(input);
    }

    public static void Start()
    {
        string text = "Välkomen till Tamagotchi";
        Line(text);
        Console.ReadLine();
        Console.Clear();
    }
}
