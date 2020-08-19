using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metodos;

namespace Pantalla
{
   
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ObtenerBisseccion_Click(object sender, EventArgs e)
        {

            MetodoBisseccion IniciarMetodoBi = new MetodoBisseccion();
            List<double> Resultado = new List<double>();
            Resultado = IniciarMetodoBi.biseccion(Double.Parse(txtLder.Text), Double.Parse(txtLizq.Text), Double.Parse(txtTolerancia.Text),int.Parse( txtIteraciones.Text));
            lblSol.Text = Resultado.ElementAt(0).ToString();
            lblErRel.Text = Resultado.ElementAt(1).ToString();
            lblCantIter.Text = Resultado.ElementAt(2).ToString();
        }
    }
}
