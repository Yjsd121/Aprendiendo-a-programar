using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto1clase.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace proyecto1clase
{
    public partial class frmAlumno : Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        private bool isEditing = false;
        private Alumno alumnoActual;
        private List<Alumno> alumnosFiltrados;
        public frmAlumno()
        {
            InitializeComponent();
            alumnosFiltrados = new List<Alumno>();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno("Yader Jose Saenz Delgado", new DateTime(2002, 1, 25), "M", Carrera.IMS);
            Alumno alumno1 = new Alumno("Nemman Zuniga", new DateTime(2002, 4, 23), "M", Carrera.IMS);
            Alumno alumno2 = new Alumno("Joel Urcuyo", new DateTime(2002, 6, 25), "M", Carrera.IMS);



            alumnos.Add(alumno);
            alumnos.Add(alumno1);
            alumnos.Add(alumno2);

            dataGridview1.DataSource = alumnos;
            ActualizarStatusSTrip();
            Activarcontroles(false);
            LlenarComboCarrera();
        }

        private void ActualizarStatusSTrip()
        {
            toolStripStatusLabel1.Text = $"total de alumnos: {dataGridview1.Rows.Count}";
        }

        private void LlenarComboCarrera()
        {
            var carreras = CarreraHelper.ObtenerCarreras();
            comboBox1.DataSource = carreras;
            comboBox1.Text = string.Empty;
        }

        private void Activarcontroles(bool v)
        {
            txtCarnet.Enabled = v;
            txtEdad.Enabled = v;
            txtPapellido.Enabled = v;
            txtPnombre.Enabled = v;
            txtSapellido.Enabled = v;
            txtSnombre.Enabled = v;
            DTTfechanacimiento.Enabled = v;
            groupBox1.Enabled = v;

            comboBox1.Enabled = v;
            GuardarAlumno.Enabled = v;
            CancelarAlumno.Enabled = v;
            LimpiarAlumno.Enabled = v;

        }
        private void EditarAlumno_Click(object sender, EventArgs e)
        {
            if (dataGridview1.SelectedCells.Count > 0)
            {
                DataGridViewCell firstselectedcell = dataGridview1.SelectedCells[0];

                DataGridViewCell firstCellInRow = dataGridview1.Rows[firstselectedcell.RowIndex].Cells[0];

                MessageBox.Show($"Valor de la primera celda en la primera columna seleccionada : {firstCellInRow.Value}");
                string carnet = firstCellInRow.Value.ToString();
                alumnoActual = alumnos.FirstOrDefault(a => a.Carnet == carnet);

                if (alumnoActual != null)
                {
                    isEditing = true;
                    CargarDatosenformulario(alumnoActual);
                    Activarcontroles(true);
                    txtCarnet.Enabled = false;
                }

            }
        }

        private void CargarDatosenformulario(Alumno alumnoActual)
        {
            txtCarnet.Text = alumnoActual.Carnet;
            separarNombrecompleto(alumnoActual);
            DTTfechanacimiento.Value = alumnoActual.Fecha_nacimiento;
            setSexo(alumnoActual.Sexo);

        }

        private void separarNombrecompleto(Alumno alumnoActual)
        {
            var partes = alumnoActual.Nombre.Split(' ');

            if (partes.Length >= 4)
            {
                txtPnombre.Text = partes[0];
                txtSnombre.Text = partes[1];
                txtPapellido.Text = partes[2];
                txtSapellido.Text = partes[3];

            }
            else
            {
                txtPnombre.Text = partes.Length > 0 ? partes[0] : string.Empty;
                txtSnombre.Text = partes.Length > 1 ? partes[1] : string.Empty;
                txtPapellido.Text = partes.Length > 2 ? partes[2] : string.Empty;
                txtSapellido.Text = partes.Length > 3 ? partes[3] : string.Empty;
            }
        }
        private void EliminarAlumno_Click(object sender, EventArgs e)
        {
            if (dataGridview1.SelectedCells == null)
            {
                MessageBox.Show("Seleccione un alumno a eliminar.");
                return;
            }

            int selectedRowIndex = dataGridview1.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dataGridview1.Rows[selectedRowIndex];

            string carnet = Convert.ToString(SelectedRow.Cells["Carnet"].Value);

            Alumno alumnoAEliminar = alumnos.FirstOrDefault(al => al.Carnet == carnet);

            if (alumnoAEliminar == null)
            {
                MessageBox.Show("Alumno no encontrado.");
                return;
            }
            DialogResult result = MessageBox.Show($" ¿Está seguro que desea eliminar al alumno {carnet}? ", "Confirmacion de Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result != DialogResult.Yes)
            {
                return;
            }

            alumnos.Remove(alumnoAEliminar);
            actualizarDTV();
        }
        private void LimpiarAlumno_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
        }

        private void AgregarAlumno_Click(object sender, EventArgs e)
        {
            isEditing = false;
            alumnoActual = null;
            Activarcontroles(true);
        }
        private void CancelarAlumno_Click(object sender, EventArgs e)
        {
            Limpiarcontroles();
            Activarcontroles(false);
        }


        private void GuardarAlumno_Click(object sender, EventArgs e)
        {

            if (!EstancompletosLosCamposObligatorios())
            {
                return;
            }

            string nombre = ConstruirNombre();
            string carrera = comboBox1.Text.ToUpper();
            DateTime fechanacimiento = DTTfechanacimiento.Value.Date;
            string sexo = getsexo();

            if (isEditing)
            {
                if (alumnoActual != null)
                {
                    alumnoActual.Nombre = nombre;
                    alumnoActual.Fecha_nacimiento = fechanacimiento;
                    alumnoActual.Carrera = ObtenerCarreraSelecionada();
                    alumnoActual.Sexo = sexo;
                    actualizarDTV();
                    Limpiarcontroles();
                    Activarcontroles(false);
                    MessageBox.Show("Datos del alumno actualizados correctamenete.", "siga 3.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
            }
            alumnoActual = alumnos.FirstOrDefault(a => a.Carnet == txtCarnet.Text);

            if (alumnoActual != null)
            {
                errorProvider1.SetError(txtCarnet, "No se admiten carnets duplicados...");
                txtCarnet.Focus();
                return;
            }
            errorProvider1.SetError(txtCarnet, "");

            Alumno nuevoalumno = new Alumno(nombre, fechanacimiento, sexo, ObtenerCarreraSelecionada());
            alumnos.Add(nuevoalumno);
            actualizarDTV();
            Limpiarcontroles();
            Activarcontroles(false);
            MessageBox.Show($"Se agrego al alumnno correctamente, Hola {nombre}", "siga 3.0", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private Carrera ObtenerCarreraSelecionada()
        {
            string carreraSeleccionada = comboBox1.SelectedItem.ToString();
            Carrera carrera;
            if (Enum.TryParse(carreraSeleccionada, out carrera))
            {
                return carrera;

            }
            throw new Exception("Carrara no valida seleccionada");
        }

        private void actualizarDTV(List<Alumno>lista=null)
        {
            dataGridview1.DataSource = null;
            dataGridview1.DataSource = lista ?? alumnos;
            ActualizarStatusSTrip();
        }

        private string ConstruirNombre()
        {
            return txtPnombre.Text + " " + txtSnombre.Text + " " + txtPapellido.Text + " " + txtSapellido.Text;
        }

        private string getsexo()
        {
            if (RbttMasculido.Checked)
                return "M";
            if (RbttFemenino.Checked)
                return "F";
            return string.Empty;
        }
        private void setSexo(string sexo)
        {
            if (sexo == "M")
                RbttMasculido.Checked = true;
            if (sexo == "F")
                RbttFemenino.Checked = true;
        }
        private bool EstancompletosLosCamposObligatorios()
        {
            if (!Validartxtbox(txtPnombre, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtSnombre, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtPapellido, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtSapellido, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtEdad, "El campo es obligatorio"))
                return false;

            if (Int32.Parse(txtEdad.Text) < 15)
            {
                errorProvider1.SetError(txtEdad, "La edad debe de ser mayor de 15 años...");
                DTTfechanacimiento.Focus();
                return false;
            }
            errorProvider1.SetError(txtEdad, "");

            if (getsexo() == string.Empty)
            {
                errorProvider1.SetError(groupBox1, "Seleccione un sexo...");
                groupBox1.Focus();
                return false;
            }
            errorProvider1.SetError(groupBox1, "");

            if (comboBox1.Text == string.Empty)
            {
                errorProvider1.SetError(comboBox1, "Seleccione carrera");
                comboBox1.Focus();
                return false;
            }
            errorProvider1.SetError(comboBox1, "");
            return true;
        }

        private bool Validartxtbox(System.Windows.Forms.TextBox txtbox, string errormessage)
        {
            if (txtbox.Text == string.Empty)
            {
                errorProvider1.SetError(txtbox, errormessage);
                txtbox.Focus();
                return false;
            }
            else
            {
                errorProvider1.SetError(txtbox, "");
                return true;
            }
        }

        private void Limpiarcontroles()
        {
            txtCarnet.Clear();
            txtPapellido.Clear();
            txtSapellido.Clear();
            txtPnombre.Clear();
            txtSnombre.Clear();
            txtEdad.Clear();
            DTTfechanacimiento.Value = DateTime.Now;
            RbttFemenino.Checked = false;
            RbttMasculido.Checked = false;

            comboBox1.SelectedIndex = -1;
        }

        private void DTTfechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DTTfechanacimiento.Value;
            int age = CalculateAge(selectedDate);
            if (age <= 0)
                txtEdad.Text = String.Empty;
            txtEdad.Text = age.ToString();
        }

        private int CalculateAge(DateTime selectedDate)
        {
            DateTime Today = DateTime.Today;
            int age = Today.Year - selectedDate.Year;

            if (selectedDate > Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        private void BuscarAlumno_Click(object sender, EventArgs e)
        {
            if (TxtBuscaralumno.Text==string.Empty)
            {
                MessageBox.Show("Ingrese el texto a buscar (carnet o nombre)...","SIGA 3.0",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TxtBuscaralumno.Focus();
            }  
            string criterioBusqueda=TxtBuscaralumno.Text.ToUpper();

            //Filtrar la lista de alumnos basada en criterios de buqueda
            alumnosFiltrados = alumnos.Where(a => a.Nombre.ToUpper().Contains(criterioBusqueda)|| a.Carnet.ToUpper().Contains(criterioBusqueda)).ToList();

            //Actualizar el data grid view con la lista filtrada
            actualizarDTV(alumnosFiltrados);
            CancelarAlumno.Enabled = true;

        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
        private void RbttMasculido_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)///Txt buscar
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
