using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

class BaseWorld
{
  private BasePlayer player;

  public void ShowStartMenu ()
  {
    Console.WriteLine ("Greetings adventurer! \nPick an option");
    Console.WriteLine ("1).  Load Game");
    Console.WriteLine ("2).  New Game");

  }
  public void ShowGameMenu ()
  {
    Console.WriteLine ("1).  Heal");
    Console.WriteLine ("2).  Go Forward");
    Console.WriteLine ("3).  Show Inventory");
    Console.WriteLine ("4).  Save Game");
    Console.WriteLine ("5).  Quit Game");
  }
  public void HealPlayer ()
  {
    bool usedPotion = false;
    usedPotion = player.usePotion();
    if (usedPotion == false)
    {
        Console.WriteLine("You do not have any potions.");
    }
  }
  public void GoForward ()
  {
    Random random = new Random ();
    int encounter = random.Next (0, 4);
    BaseMonster baseMonster = null;
    
    if (encounter == 0)
    {
	    Console.WriteLine ("You go forward, onward adventurer!");
    }

    else if (encounter == 1)
    {
	    baseMonster = new ZombieClass ();
    }
    else if (encounter == 2)
    {
	    baseMonster = new SpiderClass ();
    }
    else if (encounter == 3)
    {
        baseMonster = new HumanClass();
    }
    
    if (baseMonster != null)
    {
        Console.WriteLine("You have encountered "+ baseMonster.getMonsterName()+ ", a " + baseMonster.getMonsterType());
        ShowCombatMenu(baseMonster);
        if (player.getHealth()<=0)
        {
            player.returnToInn();
        }
    }
  }
  public void ShowInventory ()
  {
    player.showInventory();
  }

    public void SaveGame()
    {
        Console.WriteLine("Enter a filename to save the character to:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(player.getName());
            foreach (BaseItem item in player.getInventory())
            {
                if (item.getItemType()=="Potion")
                {
                    outputFile.WriteLine("Potion");
                }
                else if (item.getItemType()=="Weapon")
                {
                    outputFile.WriteLine("Weapon");
                    outputFile.WriteLine(item.getItemName());
                    outputFile.WriteLine(((WeaponItem)item).getDamage());
                }
                else if (item.getItemType()=="Armor")
                {
                    outputFile.WriteLine("Armor");
                    outputFile.WriteLine(item.getItemName());
                    outputFile.WriteLine(((ArmorItem)item).getArmor());
                }
            }
        }
    }
    public void LoadGame ()
    {
        Console.WriteLine("Enter a filename to load the character from:");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        player = new BasePlayer(lines[0]);
        for (int iter = 1; iter < lines.Length;)
        {
            if (lines[iter] == "Potion")
            {
                player.collectItem(new PotionItem());
                iter++;
            }
            else if (lines[iter]=="Weapon")
            {
                player.collectItem(new WeaponItem(lines[iter + 1],Int32.Parse(lines[iter + 2])));
                iter = iter + 3;
            }
            else if (lines[iter]=="Armor")
            {
                player.collectItem(new ArmorItem(lines[iter + 1],float.Parse(lines[iter + 2])));
                iter = iter + 3;
            }

        }
    }
    public void NewGame ()
    {
        Console.WriteLine ("What is your name?");
        string playerName = Console.ReadLine ();
        player = new BasePlayer (playerName);
    }

  public void ShowCombatMenu(BaseMonster monster)
  {
    int PlayerOption;
    do {
                Console.WriteLine ("Monster Health = " + monster.getMonsterHealth());
                Console.WriteLine ("Player Health = " + player.getHealth());
                Console.WriteLine ("What is your move?");
                Console.WriteLine ("1).  Fight to the death!");
                Console.WriteLine ("2).  Flee");
                
                PlayerOption = Int32.Parse(Console.ReadLine());
                if (PlayerOption == 1)
                {
                    monster.takeDamage(player.doDamage());
                    
                    Thread.Sleep(1000);

                }
                if (monster.getMonsterHealth() <= 0)
                {

                    Console.WriteLine("you have won!");
                    gainItem();
                }
                else
                {
                player.takeDamage(monster.doDamage());
                }
                
                if (player.getHealth() <= 0)
                {

                    Console.WriteLine("you have died!");
                    
                }
    } 
    while (monster.getMonsterHealth() > 0 && player.getHealth() > 0 && PlayerOption != 2);
  }


  private void gainItem()
  {
      Random random = new Random();
      int equipmentGenerator = random.Next(0,3);
      if (equipmentGenerator == 0)
      {
        player.collectItem(new ArmorItem());
      }
      else if (equipmentGenerator == 1)
      {
        player.collectItem(new WeaponItem());
      }
      else if (equipmentGenerator == 2)
      {
        player.collectItem(new PotionItem());
      }
  }

  public BaseWorld ()
  {
    
  }

}

