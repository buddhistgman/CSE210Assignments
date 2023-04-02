using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

abstract class BaseMonster
{
    protected string monsterName;
    protected int _monsterHealth;
    protected string monsterType;
    protected int _monsterArmor;
    protected int _monsterDamage;
    List<string>_FirstName;
    List<string>_LastName;
    List<string>_Modifier;
    public BaseMonster(string _monsterType)
    {
        monsterType = _monsterType;
        _monsterHealth = 0;
        _monsterArmor = 0;
        _monsterDamage = 0;
        Random random = new Random();
        _FirstName = new List<string>{"James","John", "Robert", "Micheal", "William"};
        _LastName = new List<string>{"Lopez","Rodriguez","Hernandez","Martinez","Sanchez"};
        _Modifier = new List <string>{"The Great","The Powerful","The Smart","The Wise"};
        string FirstName = _FirstName [random.Next(_FirstName.Count)];
        string LastName = _LastName [random.Next(_LastName.Count)];
        string Modifier = _Modifier [random.Next(_Modifier.Count)];
        
        if (Modifier == "The Great")
        {
            _monsterDamage = _monsterDamage + 15;
        }
        else if (Modifier == "The Powerful")
        {
            _monsterDamage = _monsterDamage + 30;
        }
        else if (Modifier == "The Smart")
        {
            _monsterHealth = _monsterHealth + 15;
        }
        else if (Modifier == "The Wise")
        {
            _monsterHealth = _monsterHealth + 30;
        }
        monsterName = FirstName + " " + LastName + " " + Modifier;
    }
    
    public abstract int doDamage();
    public abstract void takeDamage(int _damage);
    public string getMonsterType()
    {
        return monsterType;
    }
    public string getMonsterName()
    {
        return monsterName;
    }
    public int getMonsterHealth()
    {
        return _monsterHealth;
    }
    
}