

namespace Witcherarena2._0
{
    public class player
    {
        private string PlayerName;
        private const int maxHp = 100;
        private const int minHp = 0;
        private int currentHp = maxHp;
        private int damage = 10;
       

        internal void setName(string name)
        {
            PlayerName = name;
        }
       
        public void TakeDamage(int damage = 8)
        {
            currentHp -= damage;
            if (currentHp < minHp)
            {
                currentHp = minHp;
            }
        }
        public string startStats()
        {
            return $"Meno hraca: {PlayerName}, Zivoty: {currentHp}/{maxHp}, Utok: {damage}";
        }
        public string Stats()
        {
            int actualHp = currentHp -= damage;
            return $"Tvoj zostatok zivotov: {currentHp}/{maxHp}";
        }

    }
}
