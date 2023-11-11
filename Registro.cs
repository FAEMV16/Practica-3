using System;

namespace Practica_3
{
    internal class Registro
    {
        #region Atributos
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        #endregion

        #region Constructor
        public Registro(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        #endregion 


        public override string ToString()
        {
            return $"{Nombre}, {Edad} años";
        }
    }
}
