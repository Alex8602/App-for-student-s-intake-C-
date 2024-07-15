using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REC_TANASESCU_ALEXANDRU_GABRIEL_M730
{
    [Serializable]
    public class Articol
    {
        public string Nume { get; set; }
        public string Material { get; set; }
        public double PretLei { get; set; }
        public double PretEuro { get; set;}

        public Articol(string nume, string material, double pretLei)
        {
            Nume = nume;
            Material = material;
            PretLei = pretLei;
            PretEuro = pretLei * 4.97;
        }
    }
}
