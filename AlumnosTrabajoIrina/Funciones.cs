using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosTrabajoIrina
{

    public class Funciones
    {
        Database db = new Database();

        public void AgregarAlumno(Alumno alumno)
        {
            db.AgregarAlumno(alumno);
        }

        public List<Alumno> TodosLosAlumnos()
        {
            return db.TodosLosAlumnos();
        }

        public Alumno obtenerAlumno(int dni)
        {
            return db.obtenerAlumno(dni);
        }

        public void EditarAlumno(Alumno alumno)
        {
            db.EditarAlumno(alumno);
        }

        public void borrarAlumno(int dni_alumno)
        {
            db.borrarAlumno(dni_alumno);
        }

        public bool validarAlumno(int dni_alumno)
        {
            return db.obtenerAlumno(dni_alumno) != null;
        }

        //materias

        public void AgregarMateria(Materia materia)
        {
            db.AgregarMateria(materia);
        }

        public List<Materia> TodosLosMaterias()
        {
            return db.TodosLosMaterias();
        }

        public Materia obtenerMateria(int id)
        {
            return db.obtenerMateria(id);
        }

        public void EditarMateria(Materia materia)
        {
            db.EditarMateria(materia);
        }

        public void borrarMateria(int id_materia)
        {
            db.borrarMateria(id_materia);
        }

        public int idMateriaPorNombre(string nombre)
        {
            List<Materia> materias = db.TodosLosMaterias();
            int id = 0;

            for (int i = 0; i < materias.Count(); i++)
            {
                if (materias[i].nombre == nombre) id = materias[i].id;
            }

            return id;
        }

        public bool validarMateria(int id)
        {
            return db.obtenerMateria(id) != null;
        }

        //profesores

        public void AgregarProfesor(Profesor profesor)
        {
            db.AgregarProfesor(profesor);
        }

        public List<Profesor> TodosLosProfesores()
        {
            return db.TodosLosProfesores();
        }

        public Profesor obtenerProfesor(int dni)
        {
            return db.obtenerProfesor(dni);
        }

        public void EditarProfesor(Profesor profesor)
        {
            db.EditarProfesor(profesor);
        }

        public void borrarProfesor(int dni_prof)
        {
            db.borrarProfesor(dni_prof);
        }

        public bool validarProfesor(int dni_profesor)
        {
            return db.obtenerProfesor(dni_profesor) != null;
        }

    }
}
