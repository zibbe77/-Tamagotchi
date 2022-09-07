using System;


public class Logic
{
    public static List<Tamagotchi> tamagotchiList = new List<Tamagotchi>();
    public static int curentTamPerTurn = 0;

    public static void turnControler()
    {
        foreach (Tamagotchi t in tamagotchiList)
        {
            Display.Do();
            Console.ReadLine();
            curentTamPerTurn++;
        }
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
