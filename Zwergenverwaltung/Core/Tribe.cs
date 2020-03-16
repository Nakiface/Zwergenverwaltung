using System.Collections.Generic;
using System.Linq;

namespace Zwergenverwaltung
{
    public class Tribe
    {
        public string name { get; set; }
        public int founding { get; set; }
        public int force =>
            dwarfList.Aggregate(0, (a, dwarf) => a + dwarf.force);
        public int leadsince { get; set; }
        public Dwarf leader { get; set; }
        public List<Dwarf> dwarfList { get; set; }
        public Tribe(string name, int founding, List<Dwarf> dwarfList = null, Dwarf leader = null, int leadsince = 0)
        {
            this.name = name;
            this.founding = founding;
            this.dwarfList = dwarfList;
            this.leader = leader;
            this.leadsince = leadsince;
        }

        public void addDwarf(Dwarf dwarf)
        {
            dwarfList.Add(dwarf);
        }

        public void removeDwarf(Dwarf dwarf)
        {
            dwarfList.Remove(dwarf);
        }

        public bool setLeader(Dwarf dwarf, int leadsince)
        {
            if (!(this.leadsince != 0 && this.leadsince > leadsince))
                this.leadsince = leadsince;
            else
                return false;

            if (dwarfList.Contains(dwarf))            
                this.leader = dwarf;            
            else
                return false;

            return true;
        }
    }
}
