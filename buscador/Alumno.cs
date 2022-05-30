using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscador
{
    class Alumno
    {
        
        private string nombre;
        private int numeroDeIdentificacion;
        private bool activo;
        private List<double> notas = new List<double>();
        

        public Alumno(string nombre, int numeroDeIdentificacion, bool activo)
        {
            this.nombre = nombre;
            this.numeroDeIdentificacion = numeroDeIdentificacion;
            this.activo = activo;
            
            
        }

        ///<summary>
        ///Mostrar promedio
        ///</summary>
        ///
        public double obtenerPromedio()
        {
            double sumatoriaDeNotas = 0;
            int cantidadDeNotas = 0;
            
            foreach(double nota in notas)
            {
                sumatoriaDeNotas += nota;
                cantidadDeNotas++;
               
            }

           return (sumatoriaDeNotas / cantidadDeNotas);
        }


        ///<summary>
        ///Añadir nota a la lista de notas
        ///</summary>
        ///
        public void agregarNota(double nota)
        {
            notas.Add(nota);
        }


        ///<summary>
        ///Mostrar las notas
        ///</summary>
        ///
        public List<double> mostrarNotas()
        {
            return notas;
        }


        ///<summary>
        ///Mostrar numero de identificacion
        ///</summary>
        ///
        public int mostrarNumeroDeIdentificacion()
        {
            return numeroDeIdentificacion;
        }


        ///<summary>
        ///Mostrar nombre
        ///</summary>
        ///
        public string mostrarNombre()
        {
            return nombre;
        }


        ///<summary>
        ///Mostrar si esta activo
        ///</summary>
        ///
        public bool mostrarSiEstaActivo()
        {
            return activo;
        }

    }
}
