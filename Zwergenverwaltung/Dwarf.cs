using System.Collections.Generic;

namespace Zwergenverwaltung
{
    public class Dwarf
    {
        public string name { get; set; }
        public int age { get; set; }
        public List<Weapon> weaponList { get; set; }
        public int force { get; set; }

        public Dwarf(string name, int age, List<Weapon> weaponList)
        {
            this.name = name;
            this.age = age;
            this.weaponList = weaponList;
            foreach (var weapon in this.weaponList)
            {
                this.force += weapon.force;
            }
        }          
    }
}
