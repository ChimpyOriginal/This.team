using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.team
{
    internal class Escuela
    {
        //Lista que almacena los cursos existentes en la escuela.
        private List<Curso> cursosExistentes;
        //Lista que almacena los profesores existentes en la escuela.
        private List<Profesor> profesoresExistentes;
        //Lista que almacena los alumnos inscritos en la escuela.
        private List<Alumno> alumnosInscritos;

        //Constructor que inicializa las listas.
        public Escuela()
        {
            cursosExistentes = new List<Curso>();
            profesoresExistentes = new List<Profesor>();
            alumnosInscritos = new List<Alumno>();
        }

        //Método que crea un nuevo curso.
        public bool CrearCurso(string nombreCurso)
        {
            Curso curso = new Curso(nombreCurso);
            Profesor profesor = null;
            curso.ProfesorEncargado = profesor;

            cursosExistentes.Add(curso);
            return true;
        }

        //Método que registra a un profesor en la escuela.
        public bool RegistrarProfesor(string nombre, string especialidad)
        {
            //Crear una instancia de la clase Profesor.
            Profesor profesor = new Profesor(nombre, especialidad);

            //Agregar el profesor a la lista de profesores existentes.
            profesoresExistentes.Add(profesor);
            return true;
        }

        //Método para inscribir a un alumno en la escuela.
        public bool InscribirAlumno(int id, string nombre, int edad)
        {
            //Crear una instancia de la clase Alumno.
            Alumno alumno = new Alumno(id, nombre, edad);

            //Agregar el alumno a la lista de alumnos inscritos.    
            alumnosInscritos.Add(alumno);
            return true;
        }

        //Método que asigna un alumno a un curso.
        public string AsignarAlumnoACurso(int idAlumno, string nombreCurso)
        {
            //Verifica si el alumno y el curso se encuentran registrados
            Alumno alumno = AlumnoExiste(idAlumno);
            Curso curso = CursoExiste(nombreCurso);

            //Si el profesor está registrado, entonces se asigna al curso
            if (alumno != null && curso != null)
            {
                alumno.InscribirCurso(curso, alumno);
                //Mostrar un mensaje confirmando que el profesor fue asignado al curso exitosamente.
                return "Alumno asignado al curso exitosamente.\n";

            }
            //De lo contrario, se manda un aviso
            else if (alumno == null)
            {
                return "El alumno no se encuentra registrado en el sistema.\n";
            }

            //De lo contrario, se manda un aviso
            else if (curso == null)
            {
                return "El curso no se encuentra registrado en el sistema.\n";

            }
            return null;
        }

        public string AsignarProfesorACurso(string nombreProfesor, string nombreCurso)
        {
            //Verifica si el profesor y el curso se encuentran registrados
            Profesor profesor = ProfesorExiste(nombreProfesor);
            Curso curso = CursoExiste(nombreCurso);

            //Si el profesor está registrado, entonces se asigna al curso
            if (profesor != null && curso != null)
            {
                profesor.AsignarCurso(curso);
                //Mostrar un mensaje confirmando que el profesor fue asignado al curso exitosamente.
                return "Profesor asignado al curso exitosamente.\n";

            }
            //De lo contrario, se manda un aviso
            else if (profesor == null)
            {
                return "El profesor no se encuentra registrado en el sistema.\n";

            }

            //De lo contrario, se manda un aviso
            else if (curso == null)
            {
                return "El curso no se encuentra registrado en el sistema.\n";
            }
            return null;
        }

        //Método que muestra los cursos existentes en la escuela.
        public string VerCursos()
        {
            //Si no hay cursos, devolver un mensaje.
            if (cursosExistentes.Count == 0)
            {
                return $"Aún no se ha registrado ningún curso.\n";
            }

            //Recorrer la lista de cursos existentes y mostrar los datos de cada uno.
            string resultado = "";
            foreach (Curso curso in cursosExistentes)
            {
                if (curso.ProfesorEncargado != null)
                {
                    resultado += $"Curso: {curso.Nombre}\nProfesor: {curso.ProfesorEncargado.Nombre}\nEspecialidad del profesor: {curso.ProfesorEncargado.Especialidad}\n\n";
                }
                else
                {
                    resultado += $"Curso: {curso.Nombre}\nProfesor: Sin asignar\n\n";
                }
            }
            return resultado;
        }

        //Método que muestra los alumnos inscritos en un curso.
        public string VerAlumnos(string nombreCurso)
        {
            //Buscar el curso en la lista de cursos existentes.
            Curso curso = CursoExiste(nombreCurso);
            //Devolver un mensaje si no se encuentra el curso.
            if (curso == null)
            {
                return $"No se encontró el curso {nombreCurso}";
            }
            else
            {
                if (alumnosInscritos.Count == 0)
                {
                    return $"No hay ningún alumno inscrito en el curso.";
                }
                //Recorrer e imprimir la lista de alumnos inscritos en el curso.
                string resultado = "";
                foreach (Alumno alumno in curso.AlumnosInscritos)
                {
                    resultado += $"ID: {alumno.ID} \nNombre: {alumno.Nombre} \nEdad: {alumno.Edad}\n\n";
                }
                return resultado;

            }
        }
        //Obtiene el objeto Curso correspondiente al nombre dado
        public Curso CursoExiste(string nombreCurso)
        {
            //Hace una búsqueda entre la lista de cursos hasta encontrar una que coincida con el nombre
            foreach (var curso in cursosExistentes)
            {
                if (curso.Nombre == nombreCurso)
                {
                    return curso;
                }
            }
            return null;
        }

        public Alumno AlumnoExiste(int idAlumno)
        {
            //Hace una búsqueda entre la lista de alumnos hasta encontrar una que coincida con el ID
            foreach (var alumno in alumnosInscritos)
            {
                if (alumno.ID == idAlumno)
                {
                    return alumno;
                }
            }
            return null;
        }

        public Profesor ProfesorExiste(string nombreProfesor)
        {
            //Hace una búsqueda entre la lista de profesores hasta encontrar una que coincida con el nombre
            foreach (var profesor in profesoresExistentes)
            {
                if (profesor.Nombre == nombreProfesor)
                {
                    return profesor;
                }
            }
            return null;
        }
    }
}
