using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosTrabajoIrina
{
    public partial class Eliminar : Form
    {
        Funciones fun = new Funciones();
        int globalAction = 0;

        public Eliminar(int action)
        {
            //action 
            //1 alumno
            //2 profesor
            //3 materia
            InitializeComponent();


            if(action == 1)
            {
                globalAction = 1;
                return;
            }
            else if(action == 2)
            {
                globalAction = 2;
                textInfo.Text = "Agrege el dni del Profesor que pretende eliminar";
                return;
            }

            textData.Text = "Nombre";
            textInfo.Text = "Agrege el nombre de la materia que pretende eliminar";
            globalAction = 3;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
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

                fun.borrarAlumno(newdata);
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

                fun.borrarProfesor(newdata);
            }
            else
            {
                int id = fun.idMateriaPorNombre(data);
                resultado = fun.validarMateria(id);

                if (!resultado)
                {
                    MessageBox.Show("El nombre no corresponde a ninguna materia");
                    return;
                }

                fun.borrarAlumno(id);
            }

            MessageBox.Show("Borrados Correctamente");
            this.Close();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
