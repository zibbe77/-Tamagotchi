using System;


public class Display
{
    public static void Line(string text)
    {
        System.Console.WriteLine("-------------------------------------");
        System.Console.WriteLine($"|   {text}    |");
        System.Console.WriteLine("-------------------------------------");

        System.Console.WriteLine(text.Length);
        Console.ReadLine();

    }
    public static void Start()
    {
        string text = "Välkomen till Tamagotchi";
        Line(text);

    }
}
