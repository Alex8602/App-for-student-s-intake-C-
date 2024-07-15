using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace REC_TANASESCU_ALEXANDRU_GABRIEL_M730
{
    public partial class Form1 : Form
    {
        List<Articol> articole = new List<Articol>();
        public Form1()
        {
            InitializeComponent();
            articole.Add(new Articol("Tricou", "bumbac", 120.5));
            articole.Add(new Articol("Blugi", "denim", 219.99));
            articole.Add(new Articol("Camasa", "in", 480));
            articole.Add(new Articol("Caciula", "lana", 400));
            articoleGridView.AutoGenerateColumns = true;
            articoleGridView.DataSource=articole;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            using(var formAuxiliar = new FormAuxiliar())
            {
                if(formAuxiliar.ShowDialog() == DialogResult.OK)
                {
                    var articol = formAuxiliar.articol;
                    articole.Add(articol);
                    articoleGridView.DataSource = null;
                    articoleGridView.DataSource= articole;
                }
            }
        }


        private void buttonInfo_Click(object sender, EventArgs e)
        {
            
            var articoleDiferenta = articole.Where(a => a.Nume.ToLower().StartsWith("c", StringComparison.OrdinalIgnoreCase)).ToList();

            if (articoleDiferenta.Count >= 2)
            {
                var pretMax = articoleDiferenta.Max(a => a.PretLei);
                var pretMin = articoleDiferenta.Min(a => a.PretLei);
                var diff = pretMax - pretMin;
                MessageBox.Show($"Diferenta maxima este: {diff}", "Diferenta articole", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Nu exista suficiente articole", "Diferenta articole", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonSerializare_Click(object sender, EventArgs e)
        {


            var articoleDupaPret = articole.Where(a => a.PretLei < 50 || a.PretLei > 100.0).ToList();

            if (articoleDupaPret.Any())
            {
                using (var file = File.OpenWrite("articole.bin"))
                {
                    var format = new BinaryFormatter();
                    format.Serialize(file, articoleDupaPret);
                }
                MessageBox.Show("Articole salvate cu success", "Serializare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Nu exista suficiente articole", "Serializare", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
