using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REC_TANASESCU_ALEXANDRU_GABRIEL_M730
{
    public partial class FormAuxiliar : Form
    { 
        public Articol articol { get; set; }
        public FormAuxiliar()
        {
            InitializeComponent();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string nume = textBoxNume.Text;
            string material = textBoxMaterial.Text;
            double pretLei = double.Parse(textBoxPretLei.Text);
            articol = new Articol(nume, material, pretLei);
            DialogResult = DialogResult.OK;
        }
    }
}
