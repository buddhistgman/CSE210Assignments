using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;


class ZombieClass : BaseMonster
{
    public ZombieClass() : base("Zombie")
    {
        _monsterHealth = _monsterHealth + 150;
        _monsterDamage = _monsterDamage + 20;
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