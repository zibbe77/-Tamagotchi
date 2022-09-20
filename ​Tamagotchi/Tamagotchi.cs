using System;

public class Tamagotchi
{
    public int hunger { get; private set; }
    public int boredom { get; private set; }
    private List<string> words = new List<string>();
    private bool isalive;
    private Random generator = new Random();
    private string name = "";
    public string Name
    {
        get { return name; }
        set
        {
            if (value != "" && value.All(char.IsLetter))
            {
                name = value;
            }
        }
    }

    public Tamagotchi()
    {
        hunger = -4;
        boredom = -4;
    }

    public void Feed()
    {
        hunger -= 2;
    }
    public void Hi()
    {
        int r = generator.Next();
        System.Console.WriteLine(words[r]);
    }
    public void Teach()
    {
        //lär nytt ord
        ReduceBoredom();
    }
    public bool GetAlive()
    {
        return isalive;
    }
    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 0)
        {
            isalive = false;
        }
        if (boredom > 0)
        {
            isalive = false;
        }
    }
    void ReduceBoredom()
    {
        boredom -= 3;
    }

}