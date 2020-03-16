namespace Zwergenverwaltung
{
    public class Weapon
    {
        public string type { get; set; }
        public int force { get; set; }

        public Weapon (string type, int force)
        {
            this.type = type;
            this.force = force;
        }
    }
}
