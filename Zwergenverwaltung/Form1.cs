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
            dataGridViewTribe.ShowEditingIcon = true;

            numericUpDownTaxValue.Value = data.tribeList.Aggregate(0, (a, tribe) => a + tribe.force) * numericUpDownTaxRate.Value;

            numericUpDownTaxRate.ValueChanged += NumericUpDownTaxRate_ValueChanged;
            numericUpDownTaxValue.ValueChanged += NumericUpDownTaxValue_ValueChanged;
            dataGridViewTribe.SelectionChanged += DataGridViewTribe_SelectionChanged;
            dataGridViewDwarf.SelectionChanged += DataGridViewDwarf_SelectionChanged;
            dataGridViewWeapon.SelectionChanged += DataGridViewWeapon_SelectionChanged;
            dataGridViewWeapon.CellValueChanged += DataGridViewWeapon_CellValueChanged;
        }

        private void DataGridViewWeapon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDownTaxValue.Value = numericUpDownTaxRate.Value * data.tribeList.Aggregate(0, (a, tribe) => a + tribe.force);
            var row = dataGridViewTribe.SelectedRows;
            if (row.Count > 0)
            {
                var tribeName = row[0].Cells[0].Value;

                currentInformation.tribe = data.tribeList.Where(x => x.name == tribeName.ToString()).FirstOrDefault();
                currentInformation.dwarfList = currentInformation.tribe.dwarfList;
            }
            dataGridViewDwarf.DataSource = null;
            dataGridViewDwarf.DataSource = currentInformation.dwarfList;
            dataGridViewTribe.DataSource = null;
            dataGridViewTribe.DataSource = data.tribeList;
        }

        private void NumericUpDownTaxValue_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownTaxRate.Value = numericUpDownTaxValue.Value / data.tribeList.Aggregate(0, (a, tribe) => a + tribe.force);
        }

        private void NumericUpDownTaxRate_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownTaxValue.Value = numericUpDownTaxRate.Value * data.tribeList.Aggregate(0, (a, tribe) => a + tribe.force);
        }

        private void DataGridViewWeapon_SelectionChanged(object sender, EventArgs e)
        {
            currentInformation.type = typeof(Weapon);
            currentInformation.dataGrid = dataGridViewWeapon;
        }

        private void DataGridViewDwarf_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridViewDwarf.SelectedRows;
            if (row.Count > 0)
            {
                var dwarfName = row[0].Cells[0].Value;

                var dwarf = currentInformation.dwarfList.Where(x => x.name == dwarfName.ToString()).FirstOrDefault();
                dataGridViewWeapon.DataSource = dwarf.weaponList;

                currentInformation.type = typeof(Dwarf);
                currentInformation.dataGrid = dataGridViewDwarf;
            }
        }

        private void DataGridViewTribe_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridViewTribe.SelectedRows;
            if (row.Count > 0)
            {
                var tribeName = row[0].Cells[0].Value;

                currentInformation.tribe = data.tribeList.Where(x => x.name == tribeName.ToString()).FirstOrDefault();
                currentInformation.dwarfList = currentInformation.tribe.dwarfList;
                dataGridViewDwarf.DataSource = currentInformation.dwarfList;
                dataGridViewWeapon.DataSource = null;

                currentInformation.type = typeof(Tribe);
                currentInformation.dataGrid = dataGridViewTribe;
            }           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var test = currentInformation.type.Name;

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var className = currentInformation.type.Name;


                switch (className)
                {
                    case "Tribe":
                        data.removeTribe(currentInformation.tribe);
                        dataGridViewWeapon.DataSource = null;
                        dataGridViewDwarf.DataSource = null;
                        dataGridViewTribe.DataSource = null;
                        dataGridViewTribe.DataSource = data.tribeList;
                        break;

                    case "Dwarf":
                        try
                        {
                            var rowsDwarf = dataGridViewDwarf.SelectedRows;
                            var dwarfName = rowsDwarf[0].Cells[0].Value.ToString();
                            foreach (var tribe in data.tribeList)
                            {
                                var dwarf = tribe.dwarfList.Where(x => x.name == dwarfName).FirstOrDefault();
                                if (dwarf != null)
                                {
                                    tribe.dwarfList.Remove(dwarf);
                                    currentInformation.dwarfList = tribe.dwarfList;
                                    dataGridViewDwarf.DataSource = null;
                                    dataGridViewDwarf.DataSource = currentInformation.dwarfList;
                                    dataGridViewWeapon.DataSource = null;
                                }                                
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Bitte Makieren Sie einen Zwerg");
                        }
                        break;

                    case "Weapon":
                        try
                        {
                            var rowsDwarf = dataGridViewDwarf.SelectedRows;
                            var dwarfName = rowsDwarf[0].Cells[0].Value.ToString();
                            var rowsWeapon = dataGridViewWeapon.SelectedRows;
                            var weaponType = rowsWeapon[0].Cells[0].Value.ToString();
                            var weaponForce = Convert.ToInt32(rowsWeapon[0].Cells[1].Value.ToString());
                            foreach (var tribe in data.tribeList)
                            {
                                var dwarf = tribe.dwarfList.Where(x => x.name == dwarfName).FirstOrDefault();
                                if (dwarf != null)
                                {
                                    dwarf.removeWeapon(dwarf.weaponList.Where(x => x.type == weaponType && x.force == weaponForce).FirstOrDefault());
                                    dataGridViewWeapon.DataSource = null;
                                    dataGridViewWeapon.DataSource = dwarf.weaponList;
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Bitte Makieren Sie eine Waffe");
                        }
                        break;
                    default:
                        break;
                }
                try
                {
                    var overallForce = data.tribeList.Aggregate(0, (a, tribe) => a + tribe.force);
                    if (overallForce > 0)
                        numericUpDownTaxValue.Value = overallForce * numericUpDownTaxRate.Value;
                    else
                        numericUpDownTaxValue.Value = 0;
                }
                catch
                {
                    numericUpDownTaxValue.Value = 0;
                }               
            }            
            catch
            {
                MessageBox.Show("Bitte Makieren Sie eine Stamm");
            }          
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {

        }
    }

    public static class LittleHelper
    {
        public static Control FindFocusedControl(Control control)
        {
            var container = control as IContainerControl;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as IContainerControl;
            }
            return control;
        }
    }
}
