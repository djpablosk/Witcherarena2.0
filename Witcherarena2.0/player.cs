

namespace Witcherarena2._0
{
    public  class player
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
    }
}
