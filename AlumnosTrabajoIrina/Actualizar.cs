using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlumnosTrabajoIrina
{
    public partial class Actualizar : Form
    {
        Funciones fun = new Funciones();
        int globalAction = 0;

        public Actualizar(int action)
        {
            InitializeComponent();

            if (action == 1)
            {
                globalAction = 1;
                return;
            }
            else if (action == 2)
            {
                globalAction = 2;
                l4.Text = "Telefono";
                l5.Text = "Materia";
                globalAction = 2;
                textInfo.Text = "Agrege el dni del Profesor que pretende eliminar";
                return;
            }

            textData.Text = "Nombre";
            textInfo.Text = "Agrege el nombre de la materia que pretende eliminar";
            l1.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            txtBox1.Visible = false;
            txtBox4.Visible = false;
            txtBox5.Visible = false;
            l3.Text = "Carrera";
            globalAction = 3;
        }

        private void actualizarAlumno()
        {
            Alumno alumno = new Alumno();

            int dni = Convert.ToInt32(txtBox1.Text);
            int semestre = Convert.ToInt32(txtBox5.Text);

            if (dni == null || semestre == null)
            {
                MessageBox.Show("los compos dni y semestre tiene que ser numeros");
                return;
            }

            alumno.dni = dni;
            alumno.nombre = txtBox2.Text;
            alumno.carrera = txtBox4.Text;
            alumno.direccion = txtBox3.Text;
            alumno.semestre = semestre;

            fun.AgregarAlumno(alumno);
            MessageBox.Show("Actualizado con exito");
        }

        private void actualizarProfesor()
        {
            Profesor profesor = new Profesor();

            int dni = Convert.ToInt32(txtBox1.Text);
            int materia = Convert.ToInt32(txtBox5.Text);

            if (dni == null || materia == null)
            {
                MessageBox.Show("los campos dni y materia tiene que ser numeros");
                return;
            }

            profesor.dni = dni;
            profesor.nombre = txtBox2.Text;
            profesor.telefono = txtBox4.Text;
            profesor.direccion = txtBox3.Text;
            profesor.materia = materia;

            fun.AgregarProfesor(profesor);
            MessageBox.Show("Actualizado con exito");
        }

        private void actualizarMateria()
        {
            Materia materia = new Materia();

            materia.nombre = txtBox2.Text;
            materia.carrera = txtBox3.Text;

            fun.AgregarMateria(materia);
            MessageBox.Show("Actualizado con exito");
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {
            if (globalAction == 1) actualizarAlumno();
            else if (globalAction == 2) actualizarProfesor();
            else actualizarMateria();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            string data = txtBoxData.Text;

            if (globalAction == 1)
            {
                int newdata = Convert.ToInt32(data);

                if (newdata == null)
                {
                    MessageBox.Show("Tiene que ingresar un valor numerico");
                    return;
                }

                resultado = fun.validarAlumno(newdata);

                if (!resultado)
                {
                    MessageBox.Show("El dni ingresado no corresponde a ningun alumno");
                    return;
                }

                Alumno alumno = fun.obtenerAlumno(newdata);
                
                txtBox1.Text = alumno.dni.ToString();
                txtBox2.Text = alumno.nombre.ToString();
                txtBox3.Text = alumno.direccion.ToString();
                txtBox4.Text = alumno.carrera.ToString();
                txtBox5.Text = alumno.semestre.ToString();
            }
            else if (globalAction == 2)
            {
                int newdata = Convert.ToInt32(data);

                if (newdata == null)
                {
                    MessageBox.Show("Tiene que ingresar un valor numerico");
                    return;
                }

                resultado = fun.validarProfesor(newdata);

                if (!resultado)
                {
                    MessageBox.Show("El dni ingresado no corresponde a ningun profesor");
                    return;
                }

                Profesor profesor = fun.obtenerProfesor(newdata);

                txtBox1.Text = profesor.dni.ToString();
                txtBox2.Text = profesor.nombre.ToString();
                txtBox3.Text = profesor.direccion.ToString();
                txtBox4.Text = profesor.telefono.ToString();
                txtBox5.Text = profesor.materia.ToString();
            }
            else
            {
                int id = fun.idMateriaPorNombre(data);
                resultado = fun.validarMateria(id);

                if (!resultado)
                {
                    MessageBox.Show("El dni ingresado no corresponde a ningun alumno");
                    return;
                }

                Materia materia = fun.obtenerMateria(id);

                txtBox2.Text = materia.nombre.ToString();
                txtBox3.Text = materia.carrera.ToString();
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
