using System.Collections.Generic;
using System.Linq;

namespace Zwergenverwaltung
{
    public class Dwarf
    {
        public string name { get; set; }
        public int age { get; set; }
        public List<Weapon> weaponList { get; set; }
        public int force =>
            weaponList.Aggregate(0, (a, item) => a + item.force);

        public Dwarf(string name, int age, List<Weapon> weaponList = null)
        {
            this.name = name;
            this.age = age;
            this.weaponList = weaponList;
        } 
        
        public void addWeapon(Weapon weapon)
        {
            weaponList.Add(weapon);
        }

        public void removeWeapon(Weapon weapon)
        {
            weaponList.Remove(weapon);
        }
    }
}
