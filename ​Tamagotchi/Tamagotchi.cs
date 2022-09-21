using System;

public class Tamagotchi
{
    public int hunger { get; private set; }
    public int boredom { get; private set; }
    private Random generator = new Random();
    private List<string> words = new List<string>();
    private bool isalive = true;
    private string name = "";
    public string Name
    {
        get { return name; }
        set
        {
            //kollar så att namnet är bara bokstäver

            if (value != "" && value.All(char.IsLetter))
            {
                name = value;
            }
            else
            {
                string text = "icke godkänt namn -- Bara bokstäver";
                Display.Line(text);
                string next = "klicka enter för att försöka igen";
                Display.Line(next);
                Console.ReadLine();
                Console.Clear();
            }

        }
    }

    public Tamagotchi()
    {
        //sätter basic stats
        hunger = -4;
        boredom = -4;

        // sätter namn
        while (name == "")
        {
            string text = "Skriv namnet på din Tamagotchi";
            Display.Line(text);
            Name = Console.ReadLine();
            Console.Clear();
        }

        //Skapar 5 ord 
        for (int i = 0; i < 5; i++)
        {
            string utput = Logic.LearnWord();
            words.Add(utput);
        }
    }

    public void Feed()
    {
        hunger -= 2;
    }

    public void Hi()
    {
        //skriver utt ett ord från words 
        int r = generator.Next(words.Count);
        string text = $"din {name} sägger {words[r]}";
        Display.Line(text);

        ReduceBoredom();
    }

    public void Teach()
    {
        //generarar ett ord från listan sedan 
        string utput = Logic.LearnWord();
        words.Add(utput);

        string text = $"din {name} lärde sig {utput}";
        Display.Line(text);

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