using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

class PotionItem : BaseItem
{
    int healAmount;
    
    public PotionItem() : base("Potion")
    {
        healAmount = 100;
        itemName = "Potion";
    }
    
    public int getHealAmount()
    {
        return healAmount;
    }
}