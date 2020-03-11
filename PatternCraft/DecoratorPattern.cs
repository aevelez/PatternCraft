namespace PatternCraft
{
    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marine : IMarine
    {
        public Marine(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
    }

    public class MarineWeaponUpgrade : IMarine
    {
        private IMarine marines;

        public MarineWeaponUpgrade(IMarine marine)
        {
            marines = marine;
            marines.Damage ++;
        }

        public int Damage { get { return marines.Damage; } set { marines.Damage = value; } }

        public int Armor { get { return marines.Armor; } set { marines.Armor = value; } }
    }

    public class MarineArmorUpgrade : IMarine
    {
        private IMarine marines;

        public MarineArmorUpgrade(IMarine marine)
        {
            marines = marine;
            marines.Armor++;
        }

        public int Damage { get { return marines.Damage; } set { marines.Damage = value; } }

        public int Armor { get { return marines.Armor; } set { marines.Armor = value; } }
    }
}
