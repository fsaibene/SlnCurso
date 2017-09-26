using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno("Fer", "Saibene", "Lugano", 38324111, "fer@fer.com", 101129);
            Profesor profesor = new Profesor("Octavio", "Villegas", "Avellaneda", 54545454,  "octavio@octavio.com", "Programacion");
            MessageBox.Show(alumno.ToString());
            MessageBox.Show(profesor.ToString());
        }
    }
}
