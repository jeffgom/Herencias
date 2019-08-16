using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Heroe1 = new Heroe();
            Heroe1.Id = 1;
            Heroe1.Nombre = "Linterna Verde";
            Heroe1.TipoDePoder = "Imaginacion";
            Heroe1.Descripcion = "Utiliza un anillo que obtiene los poderes a fuerza de Voluntad";
            Heroe1.Debilidad = "El Miedo";
            Heroe1.Interprete = "Ryan Rednos";

            var Heroe2 = new Heroe();
            Heroe2.Id = 2;
            Heroe2.Nombre = "SpiderMan";
            Heroe2.TipoDePoder = "Super fueza y sentidos aracnidos";
            Heroe2.Descripcion = "Utiliza super fuerza y sus sentidos aracnidos para luchar contra el crimen";
            Heroe2.Debilidad = "La Tia May";
            Heroe2.Interprete = "Tom Hollands";

            var Heroe3 = new Heroe();
            Heroe3.Id = 3;
            Heroe3.Nombre = "Siuperman";
            Heroe3.TipoDePoder = "Varios";
            Heroe3.Descripcion = "Puede volar, tiene vision laser, fuerza bruta, alientp de hielo";
            Heroe3.Debilidad = "Criptonita";
            Heroe3.Interprete = "Henry Cavill";

            var ListadeHeroes = new List<Heroe>();
            ListadeHeroes.Add(Heroe1);
            ListadeHeroes.Add(Heroe2);
            ListadeHeroes.Add(Heroe3);

            foreach (var H in ListadeHeroes)
            {
                MessageBox.Show(H.Id + " " + H.Nombre + " " + H.TipoDePoder + " " + H.Descripcion + " " + H.Debilidad + " " + H.Interprete);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var Villano1 = new Villano();
            Villano1.Id = 1;
            Villano1.Nombre = "El Wason";
            Villano1.Interprete = "Heath Ledger";
            Villano1.Descripcion = "Gran Astusia, Gran valor";

            var Villano2 = new Villano();
            Villano2.Id = 2;
            Villano2.Nombre = "El Pinguino";
            Villano2.Interprete = "Danny DeVito";
            Villano2.Descripcion = "Comunicacion con los animales, control de un club y armas";

            var Villano3 = new Villano();
            Villano3.Id = 3;
            Villano3.Nombre = "Ra's al Ghul";
            Villano3.Interprete = "Liam Nesson";
            Villano3.Descripcion = "agilidad con espadas, inteligencia y valor";

            var ListadeVillanos = new List<Villano>();
            ListadeVillanos.Add(Villano1);
            ListadeVillanos.Add(Villano2);
            ListadeVillanos.Add(Villano3);

            foreach (var V in ListadeVillanos)
            {
                MessageBox.Show(V.Id + " " + V.Nombre + " " + V.Interprete + " " + V.Descripcion);
            }
        }
    }
}
