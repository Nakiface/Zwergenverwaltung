using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zwergenverwaltung
{
    public partial class Form1 : Form
    {
        private Data data { get; set; } = new Data();
        private CurrentInformation currentInformation { get; set; } = new CurrentInformation();

        public Form1()
        {
            this.data.setBaseDataset();
            InitializeComponent();
            BindingSource bindingSource1 = new BindingSource();
            dataGridViewTribe.DataSource = data.tribeList;

            dataGridViewDwarf.DataSource =
            data.tribeList[0].dwarfList;

            dataGridViewTribe.SelectionChanged += DataGridViewTribe_SelectionChanged;
            dataGridViewDwarf.SelectionChanged += DataGridViewDwarf_SelectionChanged;
        }

        private void DataGridViewDwarf_SelectionChanged(object sender, EventArgs e)
        {
            var Row = dataGridViewDwarf.SelectedRows;
            if (Row.Count > 0)
            {
                var dwarfName = Row[0].Cells[0].Value;

                var dwarf = currentInformation.dwarfList.Where(x => x.name == dwarfName.ToString()).FirstOrDefault();
                dataGridViewWeapon.DataSource = dwarf.weaponList;
            }
        }

        private void DataGridViewTribe_SelectionChanged(object sender, EventArgs e)
        {
            var Row = dataGridViewTribe.SelectedRows;
            if (Row.Count > 0)
            {
                var tribeName = Row[0].Cells[0].Value;

                var tribe = data.tribeList.Where(x => x.name == tribeName.ToString()).FirstOrDefault();
                //dataGridViewDwarf.DataSource = tribe.dwarfList;

                currentInformation.tribe = data.tribeList.Where(x => x.name == tribeName.ToString()).FirstOrDefault();
                currentInformation.dwarfList = currentInformation.tribe.dwarfList;
                dataGridViewDwarf.DataSource = currentInformation.dwarfList;
            }                      
        }
    }
    public class CurrentInformation
    {
        public List<Tribe> tribeList { get; set; }
        public Tribe tribe { get; set; }
        public List<Dwarf> dwarfList { get; set; }
        public Dwarf dwarf { get; set; }
        public List<Weapon> weaponList { get; set; }
        public Weapon weapon { get; set; }
    }
}
