using System;


public class Display
{
    #region ManyTimes

    public static void Line(string text)
    {

        //ökar boxen om text är längre än 38 tecken
        int extraDash = 38 - text.Length;
        string dash = "";
        if (extraDash < 0)
        {
            for (int i = 0; i < MathF.Abs(extraDash); i++)
            {
                dash += "-";
            }
        }

        //centerar texten 
        string space = "";
        for (int i = 0; i < (38 - text.Length) / 2; i++)
        {
            space += " ";
        }

        //skriver utt medlandet 
        System.Console.WriteLine($"----------------------------------------{dash}");
        System.Console.WriteLine($"|{space}{text}{space}|");
        System.Console.WriteLine($"----------------------------------------{dash}");
    }
    public static void Do()
    {
        string name = $"{Logic.tamagotchiList[Logic.curentTamPerTurn].Name}s tur att göra saker";
        Line(name);
        string intro = "Skriv ordet för att göra det";
        Line(intro);
        string text = " Mata | Nytt ord | Lek | Ignorera ";
        Line(text);
        string input = Console.ReadLine();
        Console.Clear();
        Logic.CheckInput(input);
    }

    public static void ShowStats()
    {
        string hunger = " ";
        string boredom = " ";
        int boredomCount = Logic.tamagotchiList[Logic.curentTamPerTurn].boredom;
        int hungerCount = Logic.tamagotchiList[Logic.curentTamPerTurn].hunger;

        string text = "Hunger  |  uttråkad";
        Line(text);

        System.Console.WriteLine("----------------------------------------");
        for (int i = 0; i < 5; i++)
        {
            if (hungerCount >= 0)
            {
                hunger = "¤";
            }
            if (boredomCount >= 0)
            {
                boredom = "¤";
            }

            System.Console.WriteLine($"|         {hunger}        |         {boredom}         |");
            hungerCount++;
            boredomCount++;
        }
        System.Console.WriteLine("----------------------------------------");
        Console.ReadLine();
        Console.Clear();
    }
    #endregion

    #region OdeOnes

    public static void Start()
    {
        string text = "Välkomen till Tamagotchi";
        Line(text);
        string tur = "hunger och uttråkad får inte gå till max";
        Line(tur);
        string intro = "Klicka enter för att forsäta";
        Line(intro);
        Console.ReadLine();
        Console.Clear();
    }

    public static void End()
    {
        string text = "hej då, du förlorade =)";
        Display.Line(text);
        Console.ReadLine();

        string text2 = "klicka enter för att avsluta";
    }
    #endregion

}
