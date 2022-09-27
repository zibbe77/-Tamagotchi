using System;

Display.Start();
Logic.CreatTamagotchi();

while (Logic.tamagotchiList.Count > 0)
{
    Logic.TurnControler();
}

Display.End();