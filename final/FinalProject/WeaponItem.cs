using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

class WeaponItem : BaseItem
{
    private List<string>_WeaponType;
    int damage;
    
    public WeaponItem(string _itemName, int _damage) : base("Weapon")
    {
        itemName = _itemName;
        damage = _damage;
    }
    public WeaponItem() : base("Weapon")
    {
        Random random = new Random();
        damage = 80;
        _WeaponType = new List<string>{"Sword","Great Sword", "Axe", "Great Axe", "Mace", "Great Mace"};
        _Modifier = new List <string>{"The Great","The Powerful","The Super Powerful","The Uber"};
        string WeaponType = _WeaponType [random.Next(_WeaponType.Count)];
        string Modifier = _Modifier [random.Next(_Modifier.Count)];
        
        if (Modifier == "The Great")
        {
            damage = damage + 15;
        }
        else if (Modifier == "The Powerful")
        {
            damage = damage + 30;
        }
        else if (Modifier == "The Super Powerful")
        {
            damage = damage + 45;
        }
        else if (Modifier == "The Uber")
        {
            damage = damage + 60;
        }
    itemName = WeaponType + " " + Modifier;
    }
    public int getDamage()
    {
        return damage;
    }
    

}