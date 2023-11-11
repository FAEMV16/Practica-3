using Microsoft.Win32;
using System;
using System.Collections;


namespace Practica_3
{
    internal class Busqueda
    {
        public static int BuscarLinealPorNombre(ArrayList nombres, string nombreBuscado)
        {
            
            for (int i = 0; i < nombres.Count; i++)
            {
                
                if (((Registro)nombres[i]).Nombre == nombreBuscado)
                {
                    return i+1; 
                }
            }
            return -1;
        }

        public static int BuscarBinariaPorNombre(ArrayList nombres, string nombreBuscado)
        {
            int izquierda = 0;
            int derecha = nombres.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                int comparacion = String.Compare(((Registro)nombres[medio]).Nombre, nombreBuscado);

                if (comparacion == 0)
                {
                    return medio+1; // Devuelve la posición del registro encontrado
                }
                else if (comparacion < 0)
                {
                    derecha = medio - 1; 
                }
                else
                {
                    izquierda = medio + 1;
                }
            }

            return -1; 
        }
    }
}

