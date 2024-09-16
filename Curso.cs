using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.team
{
    internal class Curso
    {
        //Nombre del curso.
        private string nombre;
        //Profesor encargado del curso.
        private Profesor profesorEncargado;
        //Lista de alumnos inscritos en el curso.
        private List<Alumno> alumnosInscritos;

        //Propiedad para acceder al nombre.
        public string Nombre { get { return nombre; } }
        //Propiedad para acceder al profesor encargado.
        public Profesor ProfesorEncargado { get { return profesorEncargado; } set { profesorEncargado = value; } }
        //Propiedad para acceder a la lista de alumnos inscritos.
        public List<Alumno> AlumnosInscritos { get { return alumnosInscritos; } }

        //Constructor que inicializa el nombre y la lista de alumnos inscritos.
        public Curso(string nombre)
        {
            this.nombre = nombre;
            alumnosInscritos = new List<Alumno>();
        }

        //Método que inscribe a un alumno en el curso.
        public void InscribirAlumno(Alumno alumno)
        {
            //Agrega al alumno a la lista de alumnos inscritos.
            alumnosInscritos.Add(alumno);
        }


    }
}
