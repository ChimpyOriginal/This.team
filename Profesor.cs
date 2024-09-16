using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.team
{
    internal class Profesor
    {
        //Nombre del profesor.
        private string nombre;
        //Especialidad del profesor.
        private string especialidad;
        //Lista de cursos impartidos por el profesor.
        private List<Curso> cursosImpartidos;

        //Propiedad para acceder al nombre.
        public string Nombre { get { return nombre; } }
        //Propiedad para acceder a la especialidad.
        public string Especialidad { get { return especialidad; } }
        //Propiedad para acceder a la lista de cursos impartidos.
        public List<Curso> CursosImpartidos { get { return cursosImpartidos; } }

        //Constructor que inicializa el nombre, la especialidad y la lista de cursos impartidos.
        public Profesor(string nombre, string especialidad)
        {
            this.nombre = nombre;
            this.especialidad = especialidad;
            cursosImpartidos = new List<Curso>();
        }

        //Método que asigna un curso al profesor.
        public void AsignarCurso(Curso curso)
        {
            //Agrega el curso a la lista de cursos impartidos.
            cursosImpartidos.Add(curso);
            //Establece al profesor como el profesor encargado del curso.
            curso.ProfesorEncargado = this;
        }
    }
}
