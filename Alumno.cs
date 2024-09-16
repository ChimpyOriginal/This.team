using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.team
{
    internal class Alumno
    {
        //ID del alumno.
        private int id;
        //Nombre del alumno.
        private string nombre;
        //Edad del alumno.
        private int edad;
        //Lista de cursos en los que el alumno está inscrito.
        private List<Curso> cursosInscritos;

        //Propiedad para acceder al ID.
        public int ID { get { return id; } }
        //Propiedad para acceder al nombre.
        public string Nombre { get { return nombre; } }
        //Propiedad para acceder a la edad.
        public int Edad { get { return edad; } }
        //Propiedad para acceder a la lista de cursos inscritos.
        public List<Curso> CursosInscritos { get { return cursosInscritos; } }

        //Constructor que inicializa el ID, el nombre, la edad y la lista de cursos inscritos.
        public Alumno(int id, string nombre, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            cursosInscritos = new List<Curso>();
        }

        //Método que inscribe al alumno en un curso.
        public void InscribirCurso(Curso curso, Alumno alumno)
        {
            //Agrega el curso a la lista de cursos inscritos del alumno.
            cursosInscritos.Add(curso);
            //Inscribe al alumno en el curso.
            curso.InscribirAlumno(alumno);
        }
    }
}
