using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosTrabajoIrina
{
    public partial class Crear : Form
    {
        Funciones fun = new Funciones();
        int globalAction = 0;
        
        public Crear(int action)
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
                return;
            }

            l1.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            txtBox1.Visible = false;
            txtBox4.Visible = false;
            txtBox5.Visible = false;
            l3.Text = "Carrera";
            globalAction = 3;
        }

        private void crearAlumno()
        {
            if (
                txtBox1.Text == "" ||
                txtBox2.Text == "" ||
                txtBox3.Text == "" ||
                txtBox4.Text == "" ||
                txtBox5.Text == ""
            )
            {
                MessageBox.Show("debe completar todos los campos");
                return;
            }

            Alumno alumno = new Alumno();

            int dni = Convert.ToInt32(txtBox1.Text);
            int semestre = Convert.ToInt32(txtBox5.Text);

            if(dni == null || semestre == null)
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
            MessageBox.Show("Creado con exito");
        }

        private void crearProfesor()
        {
            if (
                txtBox1.Text == "" ||
                txtBox2.Text == "" ||
                txtBox3.Text == "" ||
                txtBox4.Text == "" ||
                txtBox5.Text == ""
            )
            {
                MessageBox.Show("debe completar todos los campos");
                return;
            }

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
            MessageBox.Show("Creado con exito");
        }

        private void crearMateria()
        {
            if (
                txtBox2.Text == "" ||
                txtBox3.Text == ""
            )
            {
                MessageBox.Show("debe completar todos los campos");
                return;
            }

            Materia materia = new Materia();

            materia.nombre = txtBox2.Text;
            materia.carrera = txtBox3.Text;

            fun.AgregarMateria(materia);
            MessageBox.Show("Creado con exito");
        }

        private void clean()
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
            txtBox4.Text = "";
            txtBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(globalAction == 1) crearAlumno();
            else if (globalAction == 2) crearProfesor();
            else crearMateria();
            clean();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
