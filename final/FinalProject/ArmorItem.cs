using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

class ArmorItem : BaseItem
{
    private List<string> _ArmorType;
    float armor;
    
    public ArmorItem(string _itemName, float _armor) : base("Armor")
    {
        itemName = _itemName;
        armor = _armor;
    }
    public ArmorItem() : base("Armor")
    {
        Random random = new Random();
        armor = 0.9f;
        _ArmorType = new List<string>{"Leather Carapace","Leather shirt", "Iron Armor", "Iron Suit", "Steel Armor", "Steel Suit"};
        _Modifier = new List <string>{"The Great","The Powerful","The Super Powerful","The Uber"};
        string ArmorType = _ArmorType [random.Next(_ArmorType.Count)];
        string Modifier = _Modifier [random.Next(_Modifier.Count)];
        
        if (Modifier == "The Great")
        {
            armor = armor - 0.15f;
        }
        else if (Modifier == "The Powerful")
        {
            armor = armor - 0.3f;
        }
        else if (Modifier == "The Super Powerful")
        {
            armor = armor - 0.45f;
        }
        else if (Modifier == "The Uber")
        {
            armor = armor - 0.60f;
        }
    itemName = ArmorType + " " + Modifier;
    }
    public float getArmor()
    {
        return armor;
    }
}