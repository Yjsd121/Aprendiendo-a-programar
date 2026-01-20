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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto1clase
{
    public partial class frmAsigatura : Form
    {
        List<Asignatura> asignaturas=new List<Asignatura>();
        private bool isEditing = false;
        private Asignatura AsignaturaActual;
        List<Asignatura> asignaturaFiltradas=new List<Asignatura>();
        public frmAsigatura()
        {
            InitializeComponent();
        }
        private void frmAsigatura_Load(object sender, EventArgs e)
        {

            Activarcontroles(false);
            limpiarcontroles();

            actualizarstatusstrip();
        }

        private void actualizarstatusstrip()
        {
            toolStripStatusLabel1.Text = $"total de alumnos: {dataGridView1.Rows.Count}";
        }

        private void AgregarAsignatura_Click(object sender, EventArgs e)
        {
            isEditing = false;
            AsignaturaActual = null;
            Activarcontroles(true);
            
        }
        private void GuardarAsignatura_Click(object sender, EventArgs e)
        {
            if (!EstancompletosLosCamposObligatorios())
            {
                return;
            }

            string nombre = txtNombreAsig.Text;
            string creditos = txtCreditos.Text;
            string prerequi = txtPreAsig.Text;

            if (isEditing)
            {
                if (AsignaturaActual != null)
                {
                    AsignaturaActual.Nombre = nombre;
                    AsignaturaActual.Creditos = creditos;
                    AsignaturaActual.Prerequisito = prerequi;
                    actualizarDGV();
                    limpiarcontroles();
                    Activarcontroles(false);
                    MessageBox.Show("Datos de asignatura actualizados ", "siga 3.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
            }
            AsignaturaActual = asignaturas.FirstOrDefault(a => a.Id_Asignatura == txtIdAsig.Text);

            if (AsignaturaActual != null)
            {
                errorProvider1.SetError(txtIdAsig, "No se admiten carnets duplicados...");
                txtIdAsig.Focus();
                return;
            }
            errorProvider1.SetError(txtIdAsig, "");

            Asignatura nuevaasignatura = new Asignatura(nombre, creditos, prerequi);
            asignaturas.Add(nuevaasignatura);

            actualizarDGV();
            Activarcontroles(false);
            limpiarcontroles();

        }

        private bool EstancompletosLosCamposObligatorios()
        {
           
            if (!validartxtbox(txtNombreAsig, "El campo es obligatorio"))
                return false;
            if (!validartxtbox(txtPreAsig, "El campo es obligatorio"))
                return false;
            if (!validartxtbox(txtCreditos, "El campo es obligatorio"))
                return false;

            return true;
        }

        private bool validartxtbox(System.Windows.Forms.TextBox txtbox, string errormessage)
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

        private void actualizarDGV(List<Asignatura>listaa=null)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaa ?? asignaturas;
            actualizarstatusstrip();
        }

        private void limpiarcontroles()
        {
            txtIdAsig.Clear();
            txtCreditos.Clear();
            txtNombreAsig.Clear();
            txtPreAsig.Clear();

            GuardarAsignatura.Enabled = false;
            LimpiarAsignatura.Enabled = false;
            CancelarAsignatura.Enabled = false;
        }

        private void Activarcontroles(bool v)
        {
            GuardarAsignatura.Enabled= v;
            LimpiarAsignatura.Enabled= v;
            CancelarAsignatura.Enabled = v;

            txtIdAsig.ReadOnly = v;
            txtCreditos.Enabled = v;
            txtNombreAsig.Enabled = v;
            txtPreAsig.Enabled = v;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarAsignatura_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        private void CancelarAsignatura_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
            Activarcontroles(false);
        }

        private void EditarAsignatura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell firstselectedcell = dataGridView1.SelectedCells[0];

                DataGridViewCell firstselectedRow = dataGridView1.Rows[firstselectedcell.RowIndex].Cells[0];

                MessageBox.Show($"Valor de la primera celda en la primera columna seleccionada : {firstselectedRow.Value}");
                string id = firstselectedRow.Value.ToString();
                AsignaturaActual = asignaturas.FirstOrDefault(a => a.Id_Asignatura == id);

                if (AsignaturaActual!= null)
                {
                    isEditing = true;
                    CargarDatosenformulario(AsignaturaActual);
                    Activarcontroles(true);
                    txtIdAsig.Enabled = false;
                }

            }
        }

        private void CargarDatosenformulario(Asignatura asignaturaActual)
        {
            txtIdAsig.Text = asignaturaActual.Id_Asignatura;
            txtNombreAsig.Text = asignaturaActual.Nombre;
            txtPreAsig.Text=asignaturaActual.Prerequisito;
            txtCreditos.Text = asignaturaActual.Creditos;
            
        }

        private void EliminarAsignatura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells == null)
            {
                MessageBox.Show("Seleccione un alumno a eliminar.");
                return;
            }

            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = dataGridView1.Rows[selectedRowIndex];

            string id = Convert.ToString(SelectedRow.Cells["Id_Asignatura"].Value);

            Asignatura asignaturaEliminar = asignaturas.FirstOrDefault(al => al.Id_Asignatura == id);

            if (asignaturaEliminar == null)
            {
                MessageBox.Show("Alumno no encontrado.");
                return;
            }
            DialogResult result = MessageBox.Show($" ¿Está seguro que desea eliminar al alumno {id}? ", "Confirmacion de Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result != DialogResult.Yes)
            {
                return;
            }

            asignaturas.Remove(asignaturaEliminar);
            actualizarDGV();
        }


        private void BuscarAsig_Click(object sender, EventArgs e)
        {
            if (txtBuscarAsig.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el texto a buscar (carnet o nombre)...", "SIGA 3.0", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtBuscarAsig.Focus();
            }
            string criterioBusqueda = txtBuscarAsig.Text.ToUpper();

            //Filtrar la lista de alumnos basada en criterios de buqueda
            asignaturaFiltradas = asignaturas.Where(a => a.Nombre.ToUpper().Contains(criterioBusqueda) || a.Id_Asignatura.ToUpper().Contains(criterioBusqueda)).ToList();

            //Actualizar el data grid view con la lista filtrada
            actualizarDGV(asignaturaFiltradas);
            CancelarAsignatura.Enabled = true;
        }
    }
}
