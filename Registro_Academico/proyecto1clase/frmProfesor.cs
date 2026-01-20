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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace proyecto1clase
{
    public partial class Profesores : Form
    {
        List<Profesor> profesores = new List<Profesor>();
        private bool isEditing = false;
        private Profesor profesoractual;
        List<Profesor> profefiltrados = new List<Profesor>();
        public Profesores()
        {
            InitializeComponent();
        }
        private void Profesores_Load(object sender, EventArgs e)
        {
            Profesor profesor1 = new Profesor("Yader Jose Saenz Delgado", new DateTime(2002, 1, 25), "M", "Ingeniero mecatronico", Carreras.IMS, Tipocontract.Planta);
            Profesor profesor2 = new Profesor("Yader Jose Saenz Delgado", new DateTime(2002, 1, 25), "M", "Ingeniero mecatronico", Carreras.IMS, Tipocontract.Planta);
            Profesor profesor3 = new Profesor("Yader Jose Saenz Delgado", new DateTime(2002, 1, 25), "M", "Ingeniero mecatronico", Carreras.IMS, Tipocontract.Planta);




            profesores.Add(profesor1);
            profesores.Add(profesor2);
            profesores.Add(profesor3);

            DGVPROFESOR.DataSource = profesores;
            actualizarstatusstrip();
            Activarcontroles(false);
            LlenarComboCarreras();
            LLnearComboTipocontrato();

        }

        private void actualizarstatusstrip()
        {
            toolStripStatusLabel1.Text = $"total de profesores: {DGVPROFESOR.Rows.Count}";
        }

        private void Activarcontroles(bool v)
        {
            txtSnombreProfesor.Enabled = v;
            TxtIdprofesor.Enabled = v;
            txtNombreProfesor.Enabled = v;
            txtPapellido.Enabled = v;
            txtSapellido.Enabled = v;
            DTTfechaProfesor.Enabled = v;
            txtedadProfesor.Enabled = v;
            Grupo1sex.Enabled= v;
            txtTituloProfe.Enabled = v;

            comboBox1.Enabled = v;
            ComboBoxContrato.Enabled = v;
            Guardarprofesor.Enabled = v;
            CancelarPorfesor.Enabled = v;
            LimpiarProfesor.Enabled = v;


        }
        private void limpiarcontroles()
        {
            txtNombreProfesor.Clear();
            txtedadProfesor.Clear();
            txtSnombreProfesor.Clear();
            txtPapellido.Clear();
            txtSapellido.Clear();
            txtTituloProfe.Clear();

            comboBox1.SelectedIndex = -1;
            ComboBoxContrato.SelectedIndex = -1;

            DTTfechaProfesor.Value = DateTime.Now;
            RbMasculinoP.Checked = false;
            RbFemeninoP.Checked = false;

        }

        private void Agregarprofesor_Click(object sender, EventArgs e)
        {
            isEditing = false;
            profesoractual = null;
            Activarcontroles(true);

        }
        private void Guardarprofesor_Click(object sender, EventArgs e)
        {

            if (!EstancompletosLosCamposObligatorios())
            {
                return;
            }
            string nombre = construirnombre();
            DateTime fechanacimiento = DTTfechaProfesor.Value.Date;
            string Sexo = getsexo();
            string TituloProfe = txtTituloProfe.Text;

            if (isEditing)
            {
                if (profesoractual != null)
                {
                    profesoractual.Nombre = nombre;
                    profesoractual.Fecha_nacimiento = fechanacimiento;
                    profesoractual.Jefatura = ObtenerJeft();
                    profesoractual.Sexo = Sexo;
                    profesoractual.Titulo = TituloProfe;
                    profesoractual.Contrato = ObtenertipoContrato();
                    actualizarDTV();
                    limpiarcontroles();
                    Activarcontroles(false);
                    MessageBox.Show("Datos del alumno actualizados correctamenete.", "siga 3.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
            }
            profesoractual = profesores.FirstOrDefault(a => a.ID_Profesor == TxtIdprofesor.Text);

            if (profesoractual != null)
            {
                errorProvider1.SetError(TxtIdprofesor, "No se admiten carnets duplicados...");
                TxtIdprofesor.Focus();
                return;
            }
            errorProvider1.SetError(TxtIdprofesor, "");

            Profesor profesor = new Profesor(nombre, fechanacimiento, Sexo, TituloProfe, ObtenerJeft(), ObtenertipoContrato());
            profesores.Add(profesor);
            actualizarDTV();
            limpiarcontroles();
            Activarcontroles(false);

            MessageBox.Show($"Agregado correctamente, Hola {nombre}", "siga 3.0", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void EsitarProfesor_Click(object sender, EventArgs e)
        {
            if (DGVPROFESOR.SelectedCells.Count > 0)
            {
                DataGridViewCell firstselectedcell = DGVPROFESOR.SelectedCells[0];

                DataGridViewCell firstCellInRow = DGVPROFESOR.Rows[firstselectedcell.RowIndex].Cells[0];

                MessageBox.Show($"Valor de la primera celda en la primera columna seleccionada : {firstCellInRow.Value}");
                string id = firstCellInRow.Value.ToString();
                profesoractual = profesores.FirstOrDefault(a => a.ID_Profesor == id);

                if (profesoractual != null)
                {
                    isEditing = true;
                    CargarDatosenformulario(profesoractual);
                    Activarcontroles(true);
                    TxtIdprofesor.Enabled = false;
                }

            }
        }

        private void CargarDatosenformulario(Profesor profesoractual)
        {
            TxtIdprofesor.Text = profesoractual.ID_Profesor;
            separarNombrecompleto(profesoractual);
            DTTfechaProfesor.Value = profesoractual.Fecha_nacimiento;
            setSexo(profesoractual.Sexo);
            txtTituloProfe.Text = profesoractual.Titulo;
            
        }

        private void setSexo(string sexo)
        {
            if (sexo == "M")
                RbMasculinoP.Checked = true;
            if (sexo == "F")
                RbFemeninoP.Checked = true;
        }

        private void separarNombrecompleto(Profesor profesoractual)
        {
            var partes = profesoractual.Nombre.Split(' ');

            if (partes.Length >= 4)
            {
                txtNombreProfesor.Text = partes[0];
                txtSnombreProfesor.Text = partes[1];
                txtPapellido.Text = partes[2];
                txtSapellido.Text = partes[3];

            }
            else
            {
                txtNombreProfesor.Text = partes.Length > 0 ? partes[0] : string.Empty;
                txtSnombreProfesor.Text = partes.Length > 1 ? partes[1] : string.Empty;
                txtPapellido.Text = partes.Length > 2 ? partes[2] : string.Empty;
                txtSapellido.Text = partes.Length > 3 ? partes[3] : string.Empty;
            }
        }

        private bool EstancompletosLosCamposObligatorios()
        {
            if (!Validartxtbox(txtNombreProfesor, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtSnombreProfesor, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtPapellido, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtSapellido, "El campo es obligatorio"))
                return false;
            if (!Validartxtbox(txtTituloProfe, "El campo es obligatorio"))
                return false;

            if (Int32.Parse(txtedadProfesor.Text) < 15)
            {
                errorProvider1.SetError(txtedadProfesor, "La edad debe de ser mayor de 15 años...");
                DTTfechaProfesor.Focus();
                return false;
            }
            errorProvider1.SetError(txtedadProfesor, "");

            if (getsexo() == string.Empty)
            {
                errorProvider1.SetError(Grupo1sex, "Seleccione un sexo...");
                Grupo1sex.Focus();
                return false;
            }
            errorProvider1.SetError(Grupo1sex, "");

            if (comboBox1.Text == string.Empty)
            {
                errorProvider1.SetError(comboBox1, "Seleccione carrera");
                comboBox1.Focus();
                return false;
            }
            if (ComboBoxContrato.Text == string.Empty)
            {
                errorProvider1.SetError(ComboBoxContrato, "Seleccione carrera");
                ComboBoxContrato.Focus();
                return false;
            }
            errorProvider1.SetError(ComboBoxContrato, "");
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

        private void actualizarDTV(List<Profesor> lista = null)
        {
            DGVPROFESOR.DataSource = null;
            DGVPROFESOR.DataSource = lista ?? profesores;
            actualizarstatusstrip();
        }

        private string getsexo()
        {
            if (RbMasculinoP.Checked)
                return "M";
            if (RbFemeninoP.Checked)
                return "F";

            return string.Empty;
        }

        private string construirnombre()
        {
            return txtNombreProfesor.Text + " " + txtSnombreProfesor.Text + " " + txtPapellido.Text + " " + txtSapellido.Text;
        }
        private Carreras ObtenerJeft()
        {
            string JefaturaSeleccionada = comboBox1.SelectedItem.ToString();
            Carreras carreras;
            if (Enum.TryParse(JefaturaSeleccionada, out carreras))
            {
                return carreras;
            }
            throw new Exception("Carrera selecionada no valida");
        }


        private void LlenarComboCarreras()
        {
            var carreras = CarrerasHelperP.ObtenerCarreras();
            comboBox1.DataSource = carreras;
            comboBox1.Text = string.Empty;
        }
        private Tipocontract ObtenertipoContrato()
        {
            string tipoCon = ComboBoxContrato.SelectedItem.ToString();
            Tipocontract contrato;
            if (Enum.TryParse(tipoCon, out contrato))
            {
                return contrato;
            }
            throw new Exception("Tipo de contrato selecionado no valido");
        }
        private void LLnearComboTipocontrato()
        {
            var tipocontrato = TipoContratoHelper.ObtenerContrato();
            ComboBoxContrato.DataSource = tipocontrato;
            ComboBoxContrato.Text = string.Empty;
        }

        private void EliminarProfesor_Click(object sender, EventArgs e)
        {
            if (DGVPROFESOR.SelectedCells == null)
            {
                MessageBox.Show("Seleccione un alumno a eliminar.");
                return;
            }

            int selectedRowIndex = DGVPROFESOR.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = DGVPROFESOR.Rows[selectedRowIndex];

            string id = Convert.ToString(SelectedRow.Cells["ID_Profesor"].Value);

            Profesor profesorEliminar = profesores.FirstOrDefault(al => al.ID_Profesor == id);

            if (profesorEliminar == null)
            {
                MessageBox.Show("Alumno no encontrado.");
                return;
            }
            DialogResult result = MessageBox.Show($" ¿Está seguro que desea eliminar al alumno {id}? ", "Confirmacion de Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result != DialogResult.Yes)
            {
                return;
            }

            profesores.Remove(profesorEliminar);
            actualizarDTV();
        }
        
        private void CancelarPorfesor_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
            Activarcontroles(false);
        }
        private void btBuscarprofesor_Click(object sender, EventArgs e)
        {
            if (txtbuscarprofesor.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el texto a buscar (carnet o nombre)...", "SIGA 3.0", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtbuscarprofesor.Focus();
            }
            string criterioBusqueda = txtbuscarprofesor.Text.ToUpper();

            //Filtrar la lista de alumnos basada en criterios de buqueda
            profefiltrados = profesores.Where(a => a.Nombre.ToUpper().Contains(criterioBusqueda) || a.ID_Profesor.ToUpper().Contains(criterioBusqueda)).ToList();

            //Actualizar el data grid view con la lista filtrada
            actualizarDTV(profefiltrados);
            CancelarPorfesor.Enabled = true;
        }

        private void DTTfechaProfesor_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DTTfechaProfesor.Value;
            int age = CalculateAge(selectedDate);
            if (age <= 0)
                txtedadProfesor.Text = String.Empty;
            txtedadProfesor.Text = age.ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RbMasculinoP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarProfesor_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        
    }
}
