using console_war.tools;
using console_war.enums;
using console_war.formats;
namespace console_war
{
    public class Warriors
    {
        private const int GOOD_GUY_STARTING_HEALTH = 10;
        private const int BAD_GUY_STARTING_HEALTH = 10;

        private Kind kind;

        private int health;
        private string name;
        public bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public void Attack(Warriors enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoint;

            enemy.health -= damage;

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                System.Console.WriteLine();
                System.Console.WriteLine("--------------------------------------");
                Utils.ColorMaker($"{enemy.name} is dead !!", System.ConsoleColor.Red);
                Utils.ColorMaker($"{name} won the fight!!! ", System.ConsoleColor.DarkGreen);
                System.Console.WriteLine("--------------------------------------");
            }
            else
            {
                System.Console.WriteLine();
                Utils.ColorMaker($"**Attack Happened!!", System.ConsoleColor.DarkRed);
                System.Console.WriteLine($"**{name} attacked {enemy.name}");
                Utils.ColorMaker($"**Only {enemy.health} health is remaining for {enemy.name}!!", System.ConsoleColor.DarkCyan);
                System.Console.WriteLine();
            }
        }


        public Warriors(string name, Kind kind)
        {
            this.name = name;
            this.kind = kind;
            isAlive = true;

            switch (kind)
            {
                case Kind.GoodGuy:
                    weapon = new Weapon(kind);
                    armor = new Armor(kind);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Kind.BadGuy:
                    weapon = new Weapon(kind);
                    armor = new Armor(kind);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
            }
        }
    }
}