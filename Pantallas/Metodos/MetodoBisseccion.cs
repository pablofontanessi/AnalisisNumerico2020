﻿using System;
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
            return 0.5*x - 1 ; 
            
            //y=1/2 x -1 -- valores para usar lizq = 1/2/3, lder = 5/2/5 respectivamente --tole 0.0001, inter 100

            //-(3 * x) + (2 * (Math.Pow(x, 3))) funcion probada antes
        }
        public List<string> biseccion(double Lder, double LIzq, double errprp, int iterprp)
        {
            List<string> ListaResultado = new List<string>();
            
            double raiz;
            double errcalc;
            double itercalc;
            double raizant;
            if (funcion(Lder) != 0)
            {
                if (funcion(LIzq) != 0)
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
                        
                        ListaResultado.Add(raiz.ToString());
                        ListaResultado.Add(errcalc.ToString());
                        ListaResultado.Add(itercalc.ToString());
                        return ListaResultado;

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
                ListaResultado.Add(Lder.ToString());
                return ListaResultado; //Raiz en lado der
            }       
            
        }


    }
}
