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
        tamagotchiList.RemoveAll(t => t.GetAlive() == false);
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
                tamagotchiList[curentTamPerTurn].Tick();
                tamagotchiList[curentTamPerTurn].Feed();
                break;
            case "nytt ord":
                tamagotchiList[curentTamPerTurn].Tick();
                tamagotchiList[curentTamPerTurn].Teach();
                break;
            case "lek":
                tamagotchiList[curentTamPerTurn].Tick();
                tamagotchiList[curentTamPerTurn].Hi();
                break;
            case "ignorera":
                tamagotchiList[curentTamPerTurn].Tick();
                string text1 = "Din tamagotchi blev ignorera =(";
                Display.Line(text1);
                break;
            default:
                string text2 = "Fel skriv någon av valen";
                Display.Line(text2);
                Display.Do();
                break;

        }
    }

}
