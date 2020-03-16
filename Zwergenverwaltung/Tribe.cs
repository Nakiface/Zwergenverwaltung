using System.Collections.Generic;

namespace Zwergenverwaltung
{
    public class Tribe
    {
        public string name { get; set; }
        public int founding { get; set; }
        public int force { get; set; }
        public int leadsince { get; set; }
        public Dwarf leader { get; set; }
        public List<Dwarf> dwarfList { get; set; }
        public Tribe(string name, int founding, List<Dwarf> dwarfList, Dwarf leader = null, int leadsince = 0)
        {
            this.name = name;
            this.founding = founding;
            this.dwarfList = dwarfList;
            this.leader = leader;
            this.leadsince = leadsince;
            foreach (var dwarf in dwarfList)
            {
                this.force += dwarf.force;
            }
        } 
    }
}
