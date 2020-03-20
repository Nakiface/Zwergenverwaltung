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
        }
    }
}
