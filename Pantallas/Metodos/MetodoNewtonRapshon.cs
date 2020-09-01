using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class MetodoNewtonRapshon
    {
        private double funcion(double x) // FUNCION PARA RAICES
        {
            return 0.5 * x - 1;

            //y=1/2 x -1 -- valores para usar lizq = 1/2/3, lder = 5/2/5 respectivamente --tole 0.0001, inter 100

            //-(3 * x) + (2 * (Math.Pow(x, 3))) funcion probada antes
        }
        public List<string> NewtonRaphson(double LIzq, double errprp, int iterprp)
        {
            List<string> ListaResultado = new List<string>();
            double raiz;
            double errcalc;
            double itercalc;
            double deriv;
            if (funcion(LIzq) != 0)
            {
                errcalc = 100;
                itercalc = 0;
                deriv = (funcion(LIzq + 0.0001) - funcion(LIzq)) / 0.0001;
                raiz = LIzq - (funcion(LIzq) / deriv);
                while (((funcion(raiz) != 0) & (iterprp >= itercalc) & (errprp < errcalc)))
                {
                    itercalc = itercalc + 1;
                    LIzq = raiz;
                    deriv = (funcion(LIzq + 0.0001) - funcion(LIzq)) / 0.0001;
                    raiz = LIzq - (funcion(LIzq) / deriv);
                    errcalc = Math.Abs((raiz - LIzq) / raiz);
                }
                if (iterprp >= itercalc)
                {
                    if ((errprp < errcalc) | (funcion(raiz) != 0))
                    {
                        var errorDecimal = Convert.ToDecimal(errcalc);
                        ListaResultado.Add(raiz.ToString());
                        ListaResultado.Add(errorDecimal.ToString());
                        ListaResultado.Add(itercalc.ToString());
                        return ListaResultado;
                        // aca manda cuando encontro raiz
                    }
                    else
                    {
                        string Fallo = "A";
                        ListaResultado.Add(Fallo);
                        return ListaResultado; // La raíz no fue hallada
                    }
                       
                }
                else
                {
                    var errorDecimal = Convert.ToDecimal(errcalc);
                    ListaResultado.Add(raiz.ToString());
                    ListaResultado.Add(errorDecimal.ToString());
                    ListaResultado.Add(itercalc.ToString());
                    return ListaResultado;
                    // aca manda cuando encontro raiz
                }
            }
            else
            {
                string Fallo = "B";
                ListaResultado.Add(Fallo);
                ListaResultado.Add(LIzq.ToString());
                return ListaResultado; //Raiz en punto ingresado
                
            }


        }

    }
}
