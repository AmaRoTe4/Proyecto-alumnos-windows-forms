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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear crear = new Crear(1);
            crear.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar(1);
            eliminar.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar(1);
            actualizar.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar(1);
            listar.Show();
        }

        private void agregarNuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Crear crear = new Crear(3);
            crear.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar(3);
            eliminar.Show();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar(3);
            actualizar.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar(3);
            listar.Show();
        }

        private void agregarNuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Crear crear = new Crear(2);
            crear.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar(2);
            eliminar.Show();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar(2);
            actualizar.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar(2);
            listar.Show();
        }
    }
}
