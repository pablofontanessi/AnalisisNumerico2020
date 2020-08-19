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
        public List<double> biseccion(double Lder, double LIzq, double errprp, int iterprp)
        {
            List<double> ListaResultado = new List<double>();
            ListaResultado = null;
            double raiz =0;
            double errcalc=0;
            double itercalc=0;
            double raizant=0;
            if (funcion(Lder) != 0)
            {
                if (funcion(Lder) != 0)
                {
                    if ((funcion(Lder) * funcion(LIzq)) < 0)
                    {
                        raiz = (Lder + LIzq) / 2;
                        errcalc = 100;
                        itercalc = 0;
                        while (((funcion(raiz) != 0) & (iterprp >= itercalc) & (errprp < errcalc)))
                        {
                            itercalc = itercalc + 1;
                            raizant = raiz;
                            if ((funcion(LIzq) * funcion(raiz)) > 0)
                                LIzq = raiz;
                            else
                                Lder = raiz;
                            raiz = (Lder + LIzq) / 2;
                            errcalc = Math.Abs((raiz - raizant) / raiz);
                        }
                        ListaResultado.Add(raiz);
                        ListaResultado.Add(errcalc);
                        ListaResultado.Add(itercalc);
                        return ListaResultado;
                        
                    }
                   // else
                     //   Interaction.MsgBox("Es posible que no haya una raiz en el intervalo seleccionado.");
                }
                //else
                  //  Interaction.MsgBox("Raiz en punto inferior: " + LIzq);
            }
            //else
            //  Interaction.MsgBox("Raiz en punto superior: " + Lder);
            return ListaResultado;
        }


    }
}
