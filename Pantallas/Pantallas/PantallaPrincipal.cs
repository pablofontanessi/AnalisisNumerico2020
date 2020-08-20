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
            lblError.Text = "";
            MetodoBisseccion IniciarMetodoBi = new MetodoBisseccion();
            List<string> Resultado = new List<string>();
            Resultado = IniciarMetodoBi.biseccion(Double.Parse(txtLder.Text), Double.Parse(txtLizq.Text), Double.Parse(txtTolerancia.Text),int.Parse( txtIteraciones.Text));
            if (Resultado.ElementAt(0) == "A")
            {
                lblError.Text = "Es posible que no haya una raiz en el intervalo seleccionado.";
            }
            else
            {
                if (Resultado.ElementAt(0)== "B")
                {
                    lblError.Text = "La raiz se encuentra en el lado izquierdo " + Resultado.ElementAt(1) ;
                }
                else
                {
                    if (Resultado.ElementAt(0)== "C")
                    {
                        lblError.Text = "La raiz se encuentra en el lado derecho" + Resultado.ElementAt(1);
                    }
                    else
                    {
                        lblSol.Text = Resultado.ElementAt(0);
                        lblErRel.Text = Resultado.ElementAt(1);
                        lblCantIter.Text = Resultado.ElementAt(2);
                    }
                }
               
            }
           
        }
    }
}
