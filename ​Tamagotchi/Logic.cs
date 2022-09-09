using System;


public class Logic
{
    public static List<Tamagotchi> tamagotchiList = new List<Tamagotchi>();
    public static int curentTamPerTurn = 0;

    public static void TurnControler()
    {
        curentTamPerTurn = 0;
        foreach (Tamagotchi t in tamagotchiList)
        {
            Display.Do();
            Display.ShowStats();

            curentTamPerTurn++;
        }
    }

    public static void CreatTamagotchi()
    {
        Tamagotchi t = new Tamagotchi();
        Logic.tamagotchiList.Add(t);

    }

    public static void CheckInput(string input)
    {
        switch (input.ToLower())
        {
            case "mata":
                tamagotchiList[curentTamPerTurn].Feed();
                break;
            case "nytt ord":
                tamagotchiList[curentTamPerTurn].Teach();
                break;
            case "lek":
                tamagotchiList[curentTamPerTurn].Hi();
                break;
            case "ignorera":
                System.Console.WriteLine("=(");
                break;
            default:
                Display.Do();
                break;

        }
    }

}
