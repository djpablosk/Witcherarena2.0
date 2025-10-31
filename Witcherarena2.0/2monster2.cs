using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witcherarena2._0
{
    internal class _2monster2
    {
        private int monsterHp = 100;
        private int MonsterDamage = 20;


        public void  TakeDamage(int damageHit = 20)
        {
            monsterHp -= damageHit;
            int currentMonsterHp = monsterHp -= damageHit;
        }
        public string currentMonster2Stats(_2monster2 monster)
        {
            int currentMonsterHp2 = monsterHp -= MonsterDamage;
            return $"Zostatok zivotov nepriatela: {currentMonsterHp2} ";
        }
        public void TakeDamage2(int damageHit =20)
        {
            int 
        }

    }
}
