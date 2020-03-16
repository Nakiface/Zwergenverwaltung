using System.Collections.Generic;

namespace Zwergenverwaltung
{
    public class Data
    {
        public List<Tribe> tribeList { get; set; }

        public Data ()
        {
            var gimli = createGimli();
            var gumli = createGumli();
            var zwingli = createZwingli();
            List<Dwarf> dwarfsAltobarden = new List<Dwarf>() { gimli, zwingli,};
            List<Dwarf> dwarfsElbknechte = new List<Dwarf>() { gumli };
            this.tribeList = new List<Tribe>() {
                new Tribe("Altobarden", 1247, dwarfsAltobarden, gimli, 25),
                new Tribe("Elbknechte", 1023, dwarfsElbknechte)};
        }

        private Dwarf createGimli()
        {
            List<Weapon> weaponList = new List<Weapon>() { new Weapon("Axt", 12), new Weapon("Schwert", 15) };
            return new Dwarf("Gimli", 140, weaponList);
        }

        private Dwarf createGumli()
        {
            List<Weapon> weaponList = new List<Weapon>() { new Weapon("Axt", 17) };
            return new Dwarf("Gumli", 163, weaponList);
        }

        private Dwarf createZwingli()
        {
            List<Weapon> weaponList = new List<Weapon>() { new Weapon("Zauberstab", 45), new Weapon("Streithammer", 15) };
            return new Dwarf("Zwingli", 70, weaponList);
        }


    }
}
