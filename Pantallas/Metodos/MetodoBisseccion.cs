using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class MetodoBisseccion
    {
        private double funcion(double x) // FUNCION PARA RAICES
        {
            return -(3 * x) + (2 * (Math.Pow(x, 3)));
        }
        public void biseccion(double ptoSup, double ptoInf, double errprp, int iterprp)
        {
            double raiz;
            decimal errcalc;
            double itercalc;
            double raizant;
            if (funcion(ptoSup) != 0)
            {
                if (funcion(ptoInf) != 0)
                {
                    if ((funcion(ptoSup) * funcion(ptoInf)) < 0)
                    {
                        raiz = (ptoSup + ptoInf) / 2;
                        errcalc = 100;
                        itercalc = 0;
                        while (((funcion(raiz) != 0) & (iterprp >= itercalc) & (errprp < errcalc)))
                        {
                            itercalc = itercalc + 1;
                            raizant = raiz;
                            if ((funcion(ptoInf) * funcion(raiz)) > 0)
                                ptoInf = raiz;
                            else
                                ptoSup = raiz;
                            raiz = (ptoSup + ptoInf) / 2;
                            errcalc = Math.Abs((raiz - raizant) / raiz);
                        }
                        frmRaices.txtRaizResultado.Text = raiz;
                        frmRaices.txtIteracionesResultado.Text = itercalc;
                        frmRaices.txtErrorResultado.Text = errcalc;
                    }
                    else
                        Interaction.MsgBox("Es posible que no haya una raiz en el intervalo seleccionado.");
                }
                else
                    Interaction.MsgBox("Raiz en punto inferior: " + ptoInf);
            }
            else
                Interaction.MsgBox("Raiz en punto superior: " + ptoSup);
        }


    }
}
