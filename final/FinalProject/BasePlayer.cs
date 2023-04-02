using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

class BasePlayer 
{
    List <BaseItem> Inventory;
    string playerName;
    int playerMaxHealth;
    int playerCurrentHealth;
    float playerArmor;
    int maxPlayerDamage;
    
    public void collectItem(BaseItem _item)
    {
        
        Console.WriteLine("You have found a " + _item.getItemName());
        Inventory.Add(_item);
        if (_item.getItemType()=="Weapon")
        {
            WeaponItem tempWeapon = (WeaponItem)_item;
            if (tempWeapon.getDamage()>maxPlayerDamage)
            {
                maxPlayerDamage = tempWeapon.getDamage();
                Console.WriteLine("Your weapon has been upgraded!");
                Console.WriteLine("You are now using the " + _item.getItemName());
            }
            
        }
        
        else if (_item.getItemType()=="Armor")
        {
            ArmorItem tempArmor = (ArmorItem)_item;
            if (tempArmor.getArmor()<playerArmor)
            {
                playerArmor = tempArmor.getArmor();
                Console.WriteLine("Your armor has been upgraded!");
                Console.WriteLine("You now have " + _item.getItemName());
            }
            
        }
        
    }
    public List<BaseItem>getInventory()
    {
        return Inventory;
    }
    public void showInventory()
    {
        Console.WriteLine("Your current Inventory is: ");
        foreach (BaseItem item in Inventory)
        {
            Console.WriteLine(item.getItemName());
        }
    }
    
    public BasePlayer(string _name)
    {
        Inventory = new List<BaseItem>();
        playerMaxHealth = 250;
        playerCurrentHealth = playerMaxHealth;
        maxPlayerDamage = 50;
        playerName = _name;
        playerArmor = 1;
    }
    
    public void takeDamage(int _damage)
    {
        playerCurrentHealth = playerCurrentHealth - Convert.ToInt32((_damage * playerArmor));
        Console.WriteLine("You took " + Convert.ToInt32((_damage * playerArmor)) + " damage.");
    }
        
    public int getHealth()
    {
        return playerCurrentHealth;
    }
    
    private void healDamage(int healAmount)
    {
        playerCurrentHealth = playerCurrentHealth + healAmount;
        if (playerCurrentHealth >= playerMaxHealth)
        {
            playerCurrentHealth = playerMaxHealth;
        }
        Console.WriteLine("You have healed " + healAmount + " damage.");
    }
    public bool usePotion()
    {
        bool havePotion = false;
        for (int i = 0; i<Inventory.Count && havePotion == false; i++)
        {
            if (Inventory [i].getItemType()=="Potion")
            {
                havePotion = true;
                healDamage(((PotionItem)Inventory[i]).getHealAmount());
                Inventory.RemoveAt(i);
                
            }
        }
        return havePotion; 
    }
    
    public void returnToInn()
    {
        Console.WriteLine("You have returned to the Inn, and restored to health.");
        healDamage(playerMaxHealth);
    }
    
    public int doDamage()
        {
            Random rnd = new Random();
            int PlayerDamage = rnd.Next(1, maxPlayerDamage);
            Console.WriteLine("You dealt " + PlayerDamage + " damage!");
            return PlayerDamage;
        }
    public string getName()
    {
        return playerName;
    }
}