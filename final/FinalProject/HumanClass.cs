using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

class HumanClass : BaseMonster
{
    public HumanClass() : base("Human")
    {
        _monsterHealth = _monsterHealth + 200;
        _monsterDamage = _monsterDamage + 25;
    }
    
    public override int doDamage()
    {
        return _monsterDamage;
    }
    public override void takeDamage(int _damage)
    {
        _monsterHealth = _monsterHealth - _damage;
    }
}