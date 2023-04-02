using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

abstract class BaseItem
{
    protected string itemType;
    protected string itemName;
    protected List<string>_Modifier;
    public BaseItem(string _itemType)
    {
        itemType = _itemType;
    }
    
    public string getItemName()
    {
        return itemName;
    }
    
    public string getItemType()
    {
        return itemType;
    }
    
    
}