﻿using System;
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
                lblSol.Text = "";
                lblErRel.Text = "";
                lblCantIter.Text = "";
            }
            else
            {
                if (Resultado.ElementAt(0)== "B")
                {
                    lblError.Text = "La raiz se encuentra en el lado izquierdo = " + Resultado.ElementAt(1) ;
                    lblSol.Text = "";
                    lblErRel.Text = "";
                    lblCantIter.Text = "";
                }
                else
                {
                    if (Resultado.ElementAt(0)== "C")
                    {
                        lblError.Text = "La raiz se encuentra en el lado derecho = " + Resultado.ElementAt(1);
                        lblSol.Text = "";
                        lblErRel.Text = "";
                        lblCantIter.Text = "";
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

        private void ObtenerReglaFalsa_Click(object sender, EventArgs e)
        {
            lblErorRe.Text = "";
            MetodoReglaFalsa IniciarMetodoReg = new MetodoReglaFalsa();
            List<string> Resultado = new List<string>();
            Resultado = IniciarMetodoReg.ReglaFalsa(double.Parse(txtLder.Text), double.Parse(txtLizq.Text), double.Parse(txtTolerancia.Text),int.Parse(txtIteraciones.Text));
            if (Resultado.ElementAt(0) == "A")
            {
                lblErorRe.Text = "Es posible que no haya una raiz en el intervalo seleccionado.";
                lblSolR.Text = "";
                lblErR.Text = "";
                lblIterR.Text = "";
            }
            else
            {
                if (Resultado.ElementAt(0) == "B")
                {
                    lblErorRe.Text = "La raiz se encuentra en el lado izquierdo = " + Resultado.ElementAt(1);
                    lblSolR.Text = "";
                    lblErR.Text = "";
                    lblIterR.Text = "";
                }
                else
                {
                    if (Resultado.ElementAt(0) == "C")
                    {
                        lblErorRe.Text = "La raiz se encuentra en el lado derecho = " + Resultado.ElementAt(1);
                        lblSolR.Text = "";
                        lblErR.Text = "";
                        lblIterR.Text = "";
                    }
                    else
                    {
                        lblSolR.Text = Resultado.ElementAt(0);
                        lblErR.Text = Resultado.ElementAt(1);
                        lblIterR.Text = Resultado.ElementAt(2);
                    }
                }

            }
        }

        private void ObtenerNewtonRapshon_Click(object sender, EventArgs e)
        {
            lblErorNR.Text = "";
            MetodoNewtonRapshon IniciarMetodoNR = new MetodoNewtonRapshon();
            List<string> Resultado = new List<string>();
            Resultado = IniciarMetodoNR.NewtonRaphson( double.Parse(txtLizq.Text), double.Parse(txtTolerancia.Text), int.Parse(txtIteraciones.Text));
            if (Resultado.ElementAt(0) == "A")
            {
                lblErorNR.Text = "No se ha hayado la raiz";
                lblSolNR.Text = "";
                lblErNR.Text = "";
                lblIterNR.Text = "";
            }
            else
            {
                if (Resultado.ElementAt(0) == "B")
                {
                    lblErorNR.Text = "La raiz se encuentra en el punto ingresado = " + Resultado.ElementAt(1);
                    lblSolNR.Text = "";
                    lblErNR.Text = "";
                    lblIterNR.Text = "";
                }
                else
                {
                  
                        lblSolNR.Text = Resultado.ElementAt(0);
                        lblErNR.Text = Resultado.ElementAt(1);
                        lblIterNR.Text = Resultado.ElementAt(2);
                    
                }

            }
        }

        private void ObtenerSecante_Click(object sender, EventArgs e)
        {
            lblErorS.Text = "";
            MetodoSecante IniciarMetodoS = new MetodoSecante();
            List<string> Resultado = new List<string>();
            Resultado = IniciarMetodoS.Secante(double.Parse(txtLder.Text), double.Parse(txtLizq.Text), double.Parse(txtTolerancia.Text), int.Parse(txtIteraciones.Text));
            if (Resultado.ElementAt(0) == "A")
            {
                lblErorS.Text = "Es posible que no haya una raiz en el intervalo seleccionado.";
                lblSolS.Text = "";
                lblErS.Text = "";
                lblIterS.Text = "";
            }
            else
            {
                if (Resultado.ElementAt(0) == "B")
                {
                    lblErorS.Text = "La raiz se encuentra en el lado izquierdo = " + Resultado.ElementAt(1);
                    lblSolS.Text = "";
                    lblErS.Text = "";
                    lblIterS.Text = "";
                }
                else
                {
                    if (Resultado.ElementAt(0) == "C")
                    {
                        lblErorS.Text = "La raiz se encuentra en el lado derecho = " + Resultado.ElementAt(1);
                        lblSolS.Text = "";
                        lblErS.Text = "";
                        lblIterS.Text = "";
                    }
                    else
                    {
                        lblSolS.Text = Resultado.ElementAt(0);
                        lblErS.Text = Resultado.ElementAt(1);
                        lblIterS.Text = Resultado.ElementAt(2);
                    }
                }

            }
        }
    }
}
