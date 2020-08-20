using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class MetodoSecante
    {
        private double funcion(double x) // FUNCION PARA RAICES
        {
            return 0.5 * x - 1;

            //y=1/2 x -1 -- valores para usar lizq = 1/2/3, lder = 5/2/5 respectivamente --tole 0.0001, inter 100

            //-(3 * x) + (2 * (Math.Pow(x, 3))) funcion probada antes
        }
        public List<string> Secante(double LDer, double LIzq, double errprp, int iterprp)
        {
            List<string> ListaResultado = new List<string>();
            double raiz;
            double errcalc;
            double itercalc;
            if (funcion(LDer) != 0)
            {
                if (funcion(LIzq) != 0)
                {
                    raiz = ((funcion(LIzq) * LDer) - (funcion(LDer) * LIzq)) / (double)((funcion(LIzq)) - (funcion(LDer)));
                    errcalc = 100;
                    itercalc = 0;
                    while (((funcion(raiz) != 0) & (iterprp >= itercalc) & (errprp < errcalc)))
                    {
                        itercalc = itercalc + 1;
                        LDer = LIzq;
                        LIzq = raiz;
                        raiz = ((funcion(LIzq) * LDer) - (funcion(LDer) * LIzq)) / (double)((funcion(LIzq)) - (funcion(LDer)));
                        errcalc = Math.Abs((raiz - LIzq) / raiz);
                    }
                    if (iterprp >= itercalc)
                    {
                        if ((errprp < errcalc) | (funcion(raiz) != 0))
                        {
                            ListaResultado.Add(raiz.ToString());
                            ListaResultado.Add(errcalc.ToString());
                            ListaResultado.Add(itercalc.ToString());
                            return ListaResultado;
                            //aca encontro raiz
                        }
                        else
                        {
                            string Fallo = "A";
                            ListaResultado.Add(Fallo);
                            return ListaResultado; //Es posible que no haya una raiz en el intervalo seleccionado.
                        }

                    }
                    else
                    {
                        ListaResultado.Add(raiz.ToString());
                        ListaResultado.Add(errcalc.ToString());
                        ListaResultado.Add(itercalc.ToString());
                        return ListaResultado;
                        //encontro raiz
                    }
                }
                else
                {
                    string Fallo = "B";
                    ListaResultado.Add(Fallo);
                    ListaResultado.Add(LIzq.ToString());
                    return ListaResultado; //Raiz en lado izq
                }

            }
            else
            {
                string Fallo = "C";
                ListaResultado.Add(Fallo);
                ListaResultado.Add(LDer.ToString());
                return ListaResultado; //Raiz en lado der
            }
              
        }

    }
}
