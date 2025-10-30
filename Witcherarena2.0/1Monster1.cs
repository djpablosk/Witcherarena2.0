
namespace Witcherarena2._0
{
    internal class _1Monster1
    {
       private int monsterHp = 50;
       private int monsterDamage = 8;
        private int damageHit = 10;

        public void TakeDamage(int damageHit = 10)
        {
            monsterHp -= damageHit; 
            int currentMonsterHp = monsterHp -= damageHit;
        }
        public bool GiveDamage(player Player)
        {
            Player.TakeDamage(monsterDamage);
            return true;
        }

        
        internal string currentMonsterStats(_1Monster1 monster)
        {
            int currentMonsterHp = monsterHp -= damageHit;
            return $"Zostatok zivotov nepriatela: {currentMonsterHp} ";
        }
        

    }
}
