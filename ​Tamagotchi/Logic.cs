using System;


public class logic
{
    public static void CheckInput(string input)
    {
        input.ToLower();
        System.Console.WriteLine(input);
        switch (input)
        {
            case "mata":
                System.Console.WriteLine("fungerar");
                break;
            case "nytt ord":

                break;
            case "lek":

                break;
            case "ignorera":

                break;
            default:
                Display.Do();
                break;

        }
    }
}
