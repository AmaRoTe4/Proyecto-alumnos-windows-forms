using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosTrabajoIrina
{
    public partial class Listar : Form
    {
        Funciones fun = new Funciones();

        public Listar(int action)
        {
            InitializeComponent();

            if (action == 1)
            {
                boxText.Text = "Alumnos";
                gridData.DataSource = fun.TodosLosAlumnos();
                return;
            }
            else if (action == 2)
            {
                boxText.Text = "Profesores";
                gridData.DataSource = fun.TodosLosProfesores();
                return;
            }

            gridData.DataSource = fun.TodosLosMaterias();
            boxText.Text = "Materias";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
