using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class MetodoGaussJordan
    {
        private double funcion(double x) // FUNCION PARA RAICES
        {
            return (Math.Pow(x, 2) - 3) * (Math.Pow(Math.E, x - 2));
        }
        public void pivoteoParcial(int cant, int i, double[,] matriz, double[] vector)
        {
            double max;
            int posmax;
            max = Math.Abs(matriz[i, i]);
            posmax = i;
            for (var z = (i + 1); z <= cant; z++)
            {
                if ((Math.Abs(matriz[z, i]) > max))
                {
                    max = Math.Abs(matriz[z, i]);
                    posmax = z;
                }
            }
            if ((max == 0))
            {
                Console.WriteLine("No es posible continuar con la ejecución.");
                System.Environment.Exit(0);
            }
            if ((posmax != i))
            {
                double auxi;
                for (var l = 1; l <= cant; l++)
                {
                    auxi = matriz[i, l];
                    matriz[i, l] = matriz[posmax, l];
                    matriz[posmax, l] = auxi;
                }
                auxi = vector[i];
                vector[i] = vector[posmax];
                vector[posmax] = auxi;
            }
        }
       
        public void gaussJordan(double[,] matriz, double[] vector, int cant)
        {
            double pivote;
            double nuevoPivote;
            for (var i = 1; i <= cant; i++)
            {
                pivoteoParcial(cant, i, matriz, vector);
                pivote = matriz[i, i];
                for (var j = 1; j <= cant; j++)
                    matriz[i, j] = matriz[i, j] / pivote;
                vector[i] = vector[i] / pivote;
                for (var j = 1; j <= cant; j++)
                {
                    if ((i != j))
                    {
                        nuevoPivote = matriz[j, i];
                        for (var k = 1; k <= cant; k++)
                            matriz[j, k] = matriz[j, k] - (matriz[i, k] * nuevoPivote);
                        vector[j] = vector[j] - (vector[i] * nuevoPivote);
                    }
                }
            }
            for (var i = 1; i <= cant; i++) 
            { 
                frmEcuaciones.txtRespuesta.Text = frmEcuaciones.txtRespuesta.Text + "X" + i.ToString() + " = " + vector[i].ToString() + Constants.vbCrLf;
            }
        }
    }
}
