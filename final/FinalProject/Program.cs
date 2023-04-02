using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

class Program {
    public static void Main() {
        int playerChoice = 1;
        BaseWorld world = new BaseWorld();
        
        world.ShowStartMenu();
        playerChoice = Int32.Parse(Console.ReadLine());
        if (playerChoice == 1)
        {
            world.LoadGame();
        }
        else if (playerChoice == 2)
        {
            world.NewGame();
        }
        
        
        
        while (playerChoice != 5)
        {
            world.ShowGameMenu();
            playerChoice = Int32.Parse(Console.ReadLine());
            
            if (playerChoice == 1)
            {
                world.HealPlayer();
            }
            if (playerChoice == 2)
            {
                world.GoForward();
            }
            if (playerChoice == 3)
            {
                world.ShowInventory();
            }
            if (playerChoice == 4)
            {
                world.SaveGame();
            }
        }
    }
}