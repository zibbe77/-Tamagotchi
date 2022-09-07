using System;

Tamagotchi t = new Tamagotchi();

Logic.tamagotchiList.Add(t);
Display.Start();

while (true)
{
    Logic.turnControler();
}

