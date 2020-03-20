using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zwergenverwaltung
{
    public class CurrentInformation
    {
        public Tribe tribe { get; set; }
        public List<Dwarf> dwarfList { get; set; }
        public decimal taxes { get; set; }
        public Type type { get; set; }
        public DataGridView dataGrid { get; set; }
    }
}
