using console_war.enums;
namespace console_war.tools
{
    public class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Kind kind)
        {
            switch (kind)
            {
                case Kind.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Kind.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
            }
        }
    }
}