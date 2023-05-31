using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosTrabajoIrina
{
    public class Database
    {
        private SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Alumnos;Data Source=DESKTOP-7VB377L\\SQLEXPRESS");

        //alumnos
        
        public void AgregarAlumno(Alumno alumno)
        {
            try
            {
                connection.Open();
                string query = @"

                    INSERT INTO Alumnos (dni, nombre, direccion, carrera, semestre)
                    VALUES (@dni, @nombre, @direccion, @carrera, @semestre)

                ";

                SqlParameter dni = new SqlParameter("@dni", alumno.dni);
                SqlParameter nombre = new SqlParameter("@nombre", alumno.nombre);
                SqlParameter carrera = new SqlParameter("@carrera", alumno.carrera);
                SqlParameter direccion = new SqlParameter("@direccion", alumno.direccion);
                SqlParameter semestre = new SqlParameter("@semestre", alumno.semestre);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(dni);
                command.Parameters.Add(nombre);
                command.Parameters.Add(direccion);
                command.Parameters.Add(carrera);
                command.Parameters.Add(semestre);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Alumno> TodosLosAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                connection.Open();
                string query = @"SELECT dni, nombre, direccion, carrera, semestre FROM Alumnos";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    alumnos.Add(new Alumno
                    {
                        dni = int.Parse(reader["dni"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        direccion = reader["direccion"].ToString(),
                        carrera = reader["carrera"].ToString(),
                        semestre = (int)reader["semestre"],
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
            return alumnos;
        }

        public Alumno obtenerAlumno(int dni)
        {
            Alumno alumno = new Alumno();
            List<Alumno> users = TodosLosAlumnos();

            if (users == null) return null;

            users.ForEach(n =>
            {
                if (n.dni == dni)
                {
                    alumno = n;
                }
            });

            return alumno;
        }

        public void EditarAlumno(Alumno alumno)
        {
            try
            {

                connection.Open();
                string query = @" UPDATE Alumnos
                                  SET nombre = @nombre, 
                                      carrera = @carrera,
                                      dni = @dni,
                                      semestre = @semestre, 
                                      direccion = @direccion
                                  WHERE dni = @dni ";

                SqlParameter dni = new SqlParameter("@dni", alumno.dni);
                SqlParameter nombre = new SqlParameter("@nombre", alumno.nombre);
                SqlParameter carrera = new SqlParameter("@carrera", alumno.carrera);
                SqlParameter semestre= new SqlParameter("@semestre", alumno.semestre);
                SqlParameter direccion = new SqlParameter("@direccion", alumno.direccion);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(dni);
                command.Parameters.Add(nombre);
                command.Parameters.Add(carrera);
                command.Parameters.Add(semestre);
                command.Parameters.Add(direccion);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return;
        }

        public void borrarAlumno(int dni_alumno)
        {
            try
            {
                connection.Open();
                string query = @" DELETE FROM Alumnos WHERE dni = @dni ";

                SqlParameter dni= new SqlParameter("@dni", dni_alumno);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(dni);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return;
        }

        //materias

        public void AgregarMateria(Materia materia)
        {
            try
            {
                connection.Open();
                string query = @"

                    INSERT INTO Materias (nombre, carrera)
                    VALUES (@nombre, @carrera)

                ";

                SqlParameter nombre = new SqlParameter("@nombre", materia.nombre);
                SqlParameter carrera = new SqlParameter("@carrera", materia.carrera);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(nombre);
                command.Parameters.Add(carrera);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Materia> TodosLosMaterias()
        {
            List<Materia> materias= new List<Materia>();
            try
            {
                connection.Open();
                string query = @"SELECT id, nombre, carrera FROM Materias";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    materias.Add(new Materia
                    {
                        id = int.Parse(reader["id"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        carrera = reader["carrera"].ToString(),
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
            return materias;
        }

        public Materia obtenerMateria(int id)
        {
            Materia materia = new Materia();
            List<Materia> users = TodosLosMaterias();

            if (users == null) return null;

            users.ForEach(n =>
            {
                if (n.id == id)
                {
                    materia = n;
                }
            });

            return materia;
        }

        public void EditarMateria(Materia materia)
        {
            try
            {
                connection.Open();
                string query = @" UPDATE Materias
                                  SET nombre = @nombre, 
                                      carrera = @carrera
                                  WHERE id = @id ";

                SqlParameter id = new SqlParameter("@id", materia.id);
                SqlParameter nombre = new SqlParameter("@nombre", materia.nombre);
                SqlParameter carrera = new SqlParameter("@carrera", materia.carrera);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(id);
                command.Parameters.Add(nombre);
                command.Parameters.Add(carrera);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return;
        }

        public void borrarMateria(int id_materia)
        {
            try
            {
                connection.Open();
                string query = @" DELETE FROM Alumnos WHERE id = @id ";

                SqlParameter id = new SqlParameter("@id", id_materia);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return;
        }

        //profesores

        public void AgregarProfesor(Profesor profesor)
        {
            try
            {
                connection.Open();
                string query = @"

                    INSERT INTO Profesores (dni, materia, nombre, direccion, telefono)
                    VALUES (@dni, @materia, @nombre, @direccion, @telefono)

                ";

                SqlParameter dni= new SqlParameter("@dni", profesor.dni);
                SqlParameter materia = new SqlParameter("@materia", profesor.materia);
                SqlParameter nombre = new SqlParameter("@nombre", profesor.nombre);
                SqlParameter direccion = new SqlParameter("@direccion", profesor.direccion);
                SqlParameter telefono = new SqlParameter("@telefono", profesor.telefono);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(dni);
                command.Parameters.Add(materia);
                command.Parameters.Add(nombre);
                command.Parameters.Add(direccion);
                command.Parameters.Add(telefono);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Profesor> TodosLosProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();
            try
            {
                connection.Open();
                string query = @"SELECT * FROM Profesores";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    profesores.Add(new Profesor
                    {
                        dni = int.Parse(reader["dni"].ToString()),
                        materia = int.Parse(reader["materia"].ToString()),
                        nombre = reader["nombre"].ToString(),
                        direccion = reader["direccion"].ToString(),
                        telefono = reader["telefono"].ToString(),
                    });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                connection.Close();
            }
            return profesores;
        }

        public Profesor obtenerProfesor(int dni)
        {
            Profesor profesor = new Profesor();
            List<Profesor> users = TodosLosProfesores();

            if (users == null) return null;

            users.ForEach(n =>
            {
                if (n.dni == dni)
                {
                    profesor = n;
                }
            });

            return profesor;
        }

        public void EditarProfesor(Profesor profesor)
        {
            try
            {

                connection.Open();
                string query = @" UPDATE Profesores
                                  SET nombre = @nombre, 
                                      materia = @materia,
                                      telefono = @telefono,
                                      direccion = @direccion,
                                      dni = @dni
                                  WHERE dni = @dni ";

                SqlParameter dni = new SqlParameter("@dni", profesor.dni);
                SqlParameter nombre = new SqlParameter("@nombre", profesor.nombre);
                SqlParameter materia = new SqlParameter("@materia", profesor.materia);
                SqlParameter telefono = new SqlParameter("@telefono", profesor.telefono);
                SqlParameter direccion = new SqlParameter("@direccion", profesor.direccion);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(dni);
                command.Parameters.Add(nombre);
                command.Parameters.Add(materia);
                command.Parameters.Add(telefono);
                command.Parameters.Add(direccion);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return;
        }

        public void borrarProfesor(int dni_prof)
        {
            try
            {
                connection.Open();
                string query = @" DELETE FROM Profesores WHERE dni = @dni ";

                SqlParameter dni = new SqlParameter("@dni", dni_prof);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(dni);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return;
        }
    }
}
