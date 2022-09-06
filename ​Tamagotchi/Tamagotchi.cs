using System;

class Tamagotchi
{

    private int hunger;
    private int boredom;
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

    public void Feed()
    {
        hunger++;
    }
    public void Hi()
    {

    }
    public void Teach()
    {

    }
    public void GetAlive()
    {

    }
    void ReduceBoredom()
    {

    }
    void Tick()
    {

    }
    void IncresFood()
    {

    }
}