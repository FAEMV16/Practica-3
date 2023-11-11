using System;
using System.Collections;

namespace Practica_3
{
    internal class Program 
    {
     
        static void Main(string[] args)
        {
            Queue colaAlumnos = new Queue();
            Stack pilaAlumnos = new Stack();

            colaAlumnos.Enqueue(new Registro("Monse", 18));
            colaAlumnos.Enqueue(new Registro("Cesar", 23));
            colaAlumnos.Enqueue(new Registro("Fabian", 20));
            colaAlumnos.Enqueue(new Registro("Mauricio", 38));
            colaAlumnos.Enqueue(new Registro("Armando", 19));
            colaAlumnos.Enqueue(new Registro("Raymundo", 22));

            pilaAlumnos.Push(new Registro("Carlos", 28));
            pilaAlumnos.Push(new Registro("Laura", 22));
            pilaAlumnos.Push(new Registro("Angel", 31));
            pilaAlumnos.Push(new Registro("Sheila", 19));
            pilaAlumnos.Push(new Registro("Emanuel", 21));
            pilaAlumnos.Push(new Registro("Sofia", 26));

            ArrayList colaR = new ArrayList(colaAlumnos);
            ArrayList pilaR = new ArrayList(pilaAlumnos);

            Console.WriteLine("Bienvenidos al servicio de atención a estudiantes de la FI:\n\n");

            Console.WriteLine("Esta es la cola en espera en ventanilla:");
            while (colaAlumnos.Count > 0)
            {
                Registro registro = (Registro)colaAlumnos.Dequeue();
                Console.WriteLine(registro);
            }        
            
            Console.WriteLine("\nIngrese un nombre para ubicarlo en la cola de espera:");
            string nombreBuscadoCola = Console.ReadLine();
            int posLineal = Busqueda.BuscarLinealPorNombre(colaR, nombreBuscadoCola);
            if (posLineal !=-1)
            {
                Console.WriteLine("La posición del registro '{0}' por busqueda lineal es: {1}",nombreBuscadoCola,posLineal); 
            }
            else
            {
                Console.WriteLine("Registro no encontrado");
            }

            

            Console.WriteLine("\nEstos son los alumnos que hicieron examen:");
            while (pilaAlumnos.Count > 0)
            {
                Registro registro = (Registro)pilaAlumnos.Pop();
                Console.WriteLine(registro);
            }
            
            Console.WriteLine("\nIngrese un nombre para saber si hizo el examen:");
            string nombreBuscadoPila = Console.ReadLine();
            int posBinaria = Busqueda.BuscarBinariaPorNombre(pilaR, nombreBuscadoPila);
            
            if (posBinaria != -1)
            {
                Console.WriteLine("La posición del registro '{0}' por busqueda binaria es: {1}",nombreBuscadoPila,posBinaria);
            }
            else
            {
                Console.WriteLine("Registro no encontrado");
            }

            

            Console.ReadLine();
        }
    }
}
    
