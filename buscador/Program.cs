using System;
using System.Collections.Generic;

namespace buscador
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Alumno alumno1 = new Alumno("Julian",1,true);
            alumno1.agregarNota(10);
            alumno1.agregarNota(8);
            alumno1.agregarNota(7);

            Alumno alumno2 = new Alumno("Maria",2,true);
            alumno2.agregarNota(6);
            alumno2.agregarNota(7);
            alumno2.agregarNota(9);

            Alumno alumno3 = new Alumno("Patricio",3,false);
            alumno3.agregarNota(4);
            alumno3.agregarNota(9);
            alumno3.agregarNota(2);

            Alumno alumno4 = new Alumno("Ester",4, true);
            alumno4.agregarNota(1);
            alumno4.agregarNota(10);
            alumno4.agregarNota(7);

            List<Alumno> listaDeAlumnos = new List<Alumno>();
            listaDeAlumnos.Add(alumno1);
            listaDeAlumnos.Add(alumno2);
            listaDeAlumnos.Add(alumno3);
            listaDeAlumnos.Add(alumno4);

            if (BuscarEnListaPorCriterio(listaDeAlumnos,alumno1,buscarPorNombre))
            {
                Console.WriteLine("El alumno " + alumno1.mostrarNombre() + " se encuentra en la lista.");
            }
            else
            {
                Console.WriteLine("El alumno no se encuentra en la lista.");
            }


            if (BuscarEnListaPorCriterio(listaDeAlumnos, alumno2, buscarPorNumeroDeIdentificacion))
            {
                Console.WriteLine("El alumno " + alumno2.mostrarNombre() + " se encuentra en la lista.");
            }
            else
            {
                Console.WriteLine("El alumno no se encuentra en la lista.");
            }


            if (BuscarEnListaPorCriterio(listaDeAlumnos,alumno3,verSiNoEstaActivo))
            {
                Console.WriteLine("El alumno " + alumno3.mostrarNombre() + " se encuentra activo.");
            }
            else
            {
                Console.WriteLine("El alumno no se encuentra activo.");
            }


            if (BuscarEnListaPorCriterio(listaDeAlumnos, alumno4, saberSiElPromedioEsMayorASiete))
            {
                Console.WriteLine("El promedio del alumno " + alumno4.mostrarNombre() + " es mayor a 7.");
            }
            else
            {
                Console.WriteLine("El promedio del alumno no es mayor a 7.");
            }


        }

        ///<summary>
        ///Metodo de busqueda generico por criterio en lista de alumnos
        ///</summary>
        ///
        static bool BuscarEnListaPorCriterio<T>(List<T> lista,T alumno,Func<T,T,bool> cumpleCriterio)
        {
            bool encontrado = false;
            int posicion = 0;
            while ((posicion<lista.Count) && !encontrado)
            {
                if (cumpleCriterio(lista[posicion],alumno))
                {
                    encontrado = true;
                }
                posicion++;
            }


            return encontrado;
        }


        ///<summary>
        ///Buscar un alumno en lista por nombre
        ///</summary>
        ///
        static bool buscarPorNombre(Alumno alumnoEnLista,Alumno alumnoABuscar)
        {
            bool seEncontro = false;

            if(alumnoEnLista.mostrarNombre() == alumnoABuscar.mostrarNombre())
            {
                seEncontro = true;
            }

            return seEncontro;
        }


        ///<summary>
        ///Buscar un alumno en lista por numero de identificacion
        ///</summary>
        ///
        static bool buscarPorNumeroDeIdentificacion(Alumno alumnoEnLista, Alumno alumnoABuscar)
        {
            bool seEncontro = false;

            if (alumnoEnLista.mostrarNumeroDeIdentificacion() == alumnoABuscar.mostrarNumeroDeIdentificacion())
            {
                seEncontro = true;
            }

            return seEncontro;
        }


        ///<summary>
        ///Buscar un alumno para saber si esta activo
        ///</summary>
        ///
        static bool verSiNoEstaActivo(Alumno alumnoEnLista, Alumno alumnoABuscar)
        {
            bool estaActivo = false;

           
                if (alumnoEnLista.mostrarNumeroDeIdentificacion() == alumnoABuscar.mostrarNumeroDeIdentificacion() && alumnoEnLista.mostrarSiEstaActivo())
                {
                estaActivo = true;
                    
                }
           
            return estaActivo;
        }


        ///<summary>
        ///Buscar un alumno para saber si su promedio es mayor a siete
        ///</summary>
        ///
        static bool saberSiElPromedioEsMayorASiete(Alumno alumnoEnLista, Alumno alumnoABuscar)
        {
            bool esMayorASiete = false;


            if (alumnoEnLista.mostrarNumeroDeIdentificacion() == alumnoABuscar.mostrarNumeroDeIdentificacion() && alumnoEnLista.obtenerPromedio() > 7.0)
            {
                    esMayorASiete = true;
            }


            return esMayorASiete;
        }

    }
}
