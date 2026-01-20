using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto1clase.Properties;

namespace proyecto1clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " Bienvenido Yader Saenz " + DateTime.Now.ToString();
            Alumno alumno = new Alumno("Emilio Flores", DateTime.Now,"M",Carrera.IMS);
            Alumno alumno1 = new Alumno("Emilio Flores", DateTime.Now,"M",Carrera.IMS);
            Alumno alumno2 = new Alumno("Emilio Flores", DateTime.Now,"M",Carrera.IMS);
       
         

            Asignatura asignatura = new Asignatura( "Lenguaje de programacion 3", "4","Matematica");
            Profesor profersor = new Profesor("Aaron Cisnero", DateTime.Now,"M", "Ingeniero en sistemas", Carreras.ICE,Tipocontract.Planta);
            Curso curso = new Curso("C1", "IIC2024", ModalidadCurso.Diraio, profersor, asignatura);

            curso.AgregarAlumno(alumno);
            curso.AgregarAlumno(alumno1);
            curso.AgregarAlumno(alumno2);

            curso.RegistrarNota(alumno, 85);
            curso.RegistrarNota(alumno1, 90);
            curso.RegistrarNota(alumno2, 75);



           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAlumno frmalumno= new frmAlumno();
            frmalumno.ShowDialog();
        }
        private void bttProferores_Click(object sender, EventArgs e)
        {
            Profesores frmprofesor = new Profesores();
            frmprofesor.ShowDialog();
        }
        private void BttAsignatura_Click(object sender, EventArgs e)
        {
            frmAsigatura frmasignatura= new frmAsigatura();
            frmasignatura.ShowDialog();

        }
        private void BttCursos_Click(object sender, EventArgs e)
        {
            frmCruso frmcursos= new frmCruso();
            frmcursos.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }


    }
}
