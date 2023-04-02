using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Linq;

class SpiderClass : BaseMonster
{
    public SpiderClass() : base("Spider")
    {
        _monsterHealth = _monsterHealth + 100;
        _monsterDamage = _monsterDamage + 15;
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