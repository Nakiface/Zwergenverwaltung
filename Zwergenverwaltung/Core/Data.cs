using System.Collections.Generic;

namespace Zwergenverwaltung
{
    public class Data
    {
        public List<Tribe> tribeList { get; set; } = new List<Tribe>();

        public Data ()
        {
                      
        }

        public void setBaseDataset()
        {
            var gimliDwarf = new Dwarf(
                "Gimli",
                140,
                new List<Weapon>()
                {
                    new Weapon("Axt", 12),
                    new Weapon("Schwert", 15)
                });

            var gumliDwarf = new Dwarf(
                "Gumli",
                163,
                new List<Weapon>()
                {
                    new Weapon("Axt", 17)
                });

            var zwingliDwarf = new Dwarf(
                "Zwingli",
                70,
                new List<Weapon>()
                {
                    new Weapon("Zauberstab", 45),
                    new Weapon("Streithammer", 15)
                });

            var altobardenTribe = new Tribe(
                "Altobarden",
                1247,
                new List<Dwarf>()
                {
                    gimliDwarf,
                    zwingliDwarf
                },
                gimliDwarf,
                25);

            var elbknechteTribe = new Tribe(
                "Elbknechte",
                1023,
                new List<Dwarf>()
                {
                    gumliDwarf
                });

            tribeList.Add(elbknechteTribe);
            tribeList.Add(altobardenTribe);
        }

        public void addTribe(Tribe tribe)
        {
            tribeList.Add(tribe);
        }

        public void removeTribe(Tribe tribe)
        {
            tribeList.Remove(tribe);
        }
    }
}
