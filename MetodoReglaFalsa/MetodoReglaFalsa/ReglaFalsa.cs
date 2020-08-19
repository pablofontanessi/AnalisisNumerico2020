using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoReglaFalsa
{
    public class ReglaFalsa
    {
        public double funcion(double x) // FUNCION PARA RAICES
        {
            return -(3 * x) + (2 * (Math.Pow(x, 3)));
         /*'(2.7182818284590451) ^ x * ((-0.25 * (x ^ 2)) + (1.25 * x) - 1.14)

        ' ((1 / 16) * x ^ 4) - ((1 / 4) * x ^ 3) + ((3 / 4) * x ^ 2) + x - 4
        '(x ^ 3) * (2.7182818284590451 ^ x)) + 0.6
        'ej4 f(x) = (x+1)*sen(x+2) y y = -1     ((x + 1) * Math.Sin(x + 2)) + 1
        'ej3 ((x ^ 4) * ((2.7182818284590451) ^ x)) - 2 
        'ej2 4 - (1 / (x ^ 2)) - 2 * (Math.Log(x))
        'ej1 (((x ^ 5) - 0.5) * ((2.7182818284590451) ^ (3 * x))) - 1*/
        }
        public void reglaFalsa(double puntoSup, double puntoInf, double errprp, int iterprp)
        {
            double raiz, errcalc, itercalc, raizant;
            
            if (funcion(puntoSup) != 0)
            {
                if (funcion(puntoInf) != 0)
                {
                    if ((funcion(puntoSup) * funcion(puntoInf)) < 0)
                    {
                        raiz = (funcion(puntoSup) * puntoInf - funcion(puntoInf) * puntoSup) / (double)(funcion(puntoSup) - funcion(puntoInf));
                        errcalc = 100;
                        itercalc = 0;
                        while (((funcion(raiz) != 0) & (iterprp >= itercalc) & (errprp < errcalc)))
                        {
                            itercalc = itercalc + 1;
                            raizant = raiz;
                            if ((funcion(puntoInf) * funcion(raiz)) > 0)
                                puntoInf = raiz;
                            else
                                puntoSup = raiz;
                            raiz = (funcion(puntoSup) * puntoInf - funcion(puntoInf) * puntoSup) / (double)(funcion(puntoSup) - funcion(puntoInf));
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
                    Interaction.MsgBox("Raiz en punto inferior: " + puntoInf);
            }
            else
                Interaction.MsgBox("Raiz en punto superior: " + puntoSup);
        }

    }
}
