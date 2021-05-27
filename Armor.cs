using console_war.enums;
namespace console_war.tools
{
    public class Armor
    {
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;
        private int armorPoint;
         public int ArmorPoint
        {
             get
             {
                return armorPoint;
            }
        }

        public Armor(Kind kind)
        {
            switch (kind)
            {
                case Kind.GoodGuy:
                    armorPoint = GOOD_GUY_ARMOR;
                    break;
                case Kind.BadGuy:
                    armorPoint = BAD_GUY_ARMOR;
                    break;
            }
        }
    }
}