using System;
using System.Collections;

namespace Practica_3
{
    internal class Ordenamiento
    {
        public static void BurbujaNombre(ArrayList nombres)
        {
            int n = nombres.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (String.Compare(((Registro)nombres[j]).Nombre, ((Registro)nombres[j + 1]).Nombre) > 0)
                    {
                        // Intercambiar registros
                        Registro temp = (Registro)nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = temp;
                    }
                }
            }
        }
        public static void BurbujaEdad(ArrayList edades)
        {
            int n = edades.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (((Registro)edades[j]).Edad > ((Registro)edades[j + 1]).Edad)
                    {
                        // Intercambiar registros
                        Registro temp = (Registro)edades[j];
                        edades[j] = edades[j + 1];
                        edades[j + 1] = temp;
                    }
                }
            }
        }
    }
}





