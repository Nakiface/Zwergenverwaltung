using System;
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
        Data data = new Data();
        public Form1()
        {
            InitializeComponent();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.Add(data.tribeList[0]);
            bindingSource1.Add(data.tribeList[1]);

            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSize = true;
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewColumn tribeName = new DataGridViewColumn();
            tribeName.DataPropertyName = "founding";
            tribeName.Name = "Stamm";
            dataGridView1.Columns.Add(tribeName);


           
        }
    }

}
