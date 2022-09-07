using System;


public class Display
{
    #region ManyTimes

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
        string intro = "Skriv ordet för att göra det";
        Line(intro);
        string text = " Mata | Nytt ord | Lek | Ignorera ";
        Line(text);
        string input = Console.ReadLine();
        Console.Clear();
        Logic.CheckInput(input);
    }
    #endregion

    #region OdeOnes

    public static void Start()
    {
        string text = "Välkomen till Tamagotchi";
        Line(text);
        string intro = "Klicka enter för att forsäta";
        Line(intro);
        Console.ReadLine();
        Console.Clear();
    }
    #endregion

}
