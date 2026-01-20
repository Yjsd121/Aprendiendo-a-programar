namespace proyecto1clase
{
    partial class frmAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AgregarAlumno = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditarAlumno = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GuardarAlumno = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarAlumno = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.LimpiarAlumno = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelarAlumno = new System.Windows.Forms.ToolStripButton();
            this.TxtBuscaralumno = new System.Windows.Forms.ToolStripTextBox();
            this.BuscarAlumno = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtPnombre = new System.Windows.Forms.TextBox();
            this.txtSnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPapellido = new System.Windows.Forms.TextBox();
            this.txtSapellido = new System.Windows.Forms.TextBox();
            this.DTTfechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbttFemenino = new System.Windows.Forms.RadioButton();
            this.RbttMasculido = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.AgregarAlumno,
            this.toolStripSeparator2,
            this.EditarAlumno,
            this.toolStripSeparator3,
            this.GuardarAlumno,
            this.toolStripSeparator4,
            this.EliminarAlumno,
            this.toolStripSeparator5,
            this.LimpiarAlumno,
            this.toolStripButton6,
            this.CancelarAlumno,
            this.TxtBuscaralumno,
            this.BuscarAlumno});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1224, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // AgregarAlumno
            // 
            this.AgregarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("AgregarAlumno.Image")));
            this.AgregarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarAlumno.Name = "AgregarAlumno";
            this.AgregarAlumno.Size = new System.Drawing.Size(76, 24);
            this.AgregarAlumno.Text = "Nuevo";
            this.AgregarAlumno.Click += new System.EventHandler(this.AgregarAlumno_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // EditarAlumno
            // 
            this.EditarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("EditarAlumno.Image")));
            this.EditarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarAlumno.Name = "EditarAlumno";
            this.EditarAlumno.Size = new System.Drawing.Size(72, 24);
            this.EditarAlumno.Text = "Editar";
            this.EditarAlumno.Click += new System.EventHandler(this.EditarAlumno_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // GuardarAlumno
            // 
            this.GuardarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("GuardarAlumno.Image")));
            this.GuardarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarAlumno.Name = "GuardarAlumno";
            this.GuardarAlumno.Size = new System.Drawing.Size(86, 24);
            this.GuardarAlumno.Text = "Guardar";
            this.GuardarAlumno.Click += new System.EventHandler(this.GuardarAlumno_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // EliminarAlumno
            // 
            this.EliminarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("EliminarAlumno.Image")));
            this.EliminarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarAlumno.Name = "EliminarAlumno";
            this.EliminarAlumno.Size = new System.Drawing.Size(87, 24);
            this.EliminarAlumno.Text = "Eliminar";
            this.EliminarAlumno.Click += new System.EventHandler(this.EliminarAlumno_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // LimpiarAlumno
            // 
            this.LimpiarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarAlumno.Image")));
            this.LimpiarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimpiarAlumno.Name = "LimpiarAlumno";
            this.LimpiarAlumno.Size = new System.Drawing.Size(83, 24);
            this.LimpiarAlumno.Text = "Limpiar";
            this.LimpiarAlumno.Click += new System.EventHandler(this.LimpiarAlumno_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(6, 27);
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // CancelarAlumno
            // 
            this.CancelarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("CancelarAlumno.Image")));
            this.CancelarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarAlumno.Name = "CancelarAlumno";
            this.CancelarAlumno.Size = new System.Drawing.Size(90, 24);
            this.CancelarAlumno.Text = "Cancelar";
            this.CancelarAlumno.Click += new System.EventHandler(this.CancelarAlumno_Click);
            // 
            // TxtBuscaralumno
            // 
            this.TxtBuscaralumno.Name = "TxtBuscaralumno";
            this.TxtBuscaralumno.Size = new System.Drawing.Size(100, 27);
            this.TxtBuscaralumno.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // BuscarAlumno
            // 
            this.BuscarAlumno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("BuscarAlumno.Image")));
            this.BuscarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarAlumno.Name = "BuscarAlumno";
            this.BuscarAlumno.Size = new System.Drawing.Size(29, 24);
            this.BuscarAlumno.Text = "Buscar";
            this.BuscarAlumno.Click += new System.EventHandler(this.BuscarAlumno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundo Nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCarnet
            // 
            this.txtCarnet.BackColor = System.Drawing.SystemColors.Window;
            this.txtCarnet.Location = new System.Drawing.Point(143, 40);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.ReadOnly = true;
            this.txtCarnet.Size = new System.Drawing.Size(172, 22);
            this.txtCarnet.TabIndex = 4;
            this.txtCarnet.TextChanged += new System.EventHandler(this.txtCarnet_TextChanged);
            // 
            // txtPnombre
            // 
            this.txtPnombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtPnombre.Location = new System.Drawing.Point(143, 98);
            this.txtPnombre.Name = "txtPnombre";
            this.txtPnombre.Size = new System.Drawing.Size(172, 22);
            this.txtPnombre.TabIndex = 5;
            this.txtPnombre.TextChanged += new System.EventHandler(this.txtPnombre_TextChanged);
            // 
            // txtSnombre
            // 
            this.txtSnombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtSnombre.Location = new System.Drawing.Point(143, 126);
            this.txtSnombre.Name = "txtSnombre";
            this.txtSnombre.Size = new System.Drawing.Size(172, 22);
            this.txtSnombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Primer Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Segundo apelldio:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPapellido
            // 
            this.txtPapellido.BackColor = System.Drawing.SystemColors.Info;
            this.txtPapellido.Location = new System.Drawing.Point(524, 95);
            this.txtPapellido.Name = "txtPapellido";
            this.txtPapellido.Size = new System.Drawing.Size(204, 22);
            this.txtPapellido.TabIndex = 10;
            // 
            // txtSapellido
            // 
            this.txtSapellido.BackColor = System.Drawing.SystemColors.Info;
            this.txtSapellido.Location = new System.Drawing.Point(524, 126);
            this.txtSapellido.Name = "txtSapellido";
            this.txtSapellido.Size = new System.Drawing.Size(204, 22);
            this.txtSapellido.TabIndex = 11;
            // 
            // DTTfechanacimiento
            // 
            this.DTTfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTTfechanacimiento.Location = new System.Drawing.Point(524, 41);
            this.DTTfechanacimiento.Name = "DTTfechanacimiento";
            this.DTTfechanacimiento.Size = new System.Drawing.Size(204, 22);
            this.DTTfechanacimiento.TabIndex = 12;
            this.DTTfechanacimiento.ValueChanged += new System.EventHandler(this.DTTfechanacimiento_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbttFemenino);
            this.groupBox1.Controls.Add(this.RbttMasculido);
            this.groupBox1.Location = new System.Drawing.Point(769, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 79);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // RbttFemenino
            // 
            this.RbttFemenino.AutoSize = true;
            this.RbttFemenino.Location = new System.Drawing.Point(97, 32);
            this.RbttFemenino.Name = "RbttFemenino";
            this.RbttFemenino.Size = new System.Drawing.Size(36, 20);
            this.RbttFemenino.TabIndex = 17;
            this.RbttFemenino.TabStop = true;
            this.RbttFemenino.Text = "F";
            this.RbttFemenino.UseVisualStyleBackColor = true;
            // 
            // RbttMasculido
            // 
            this.RbttMasculido.AutoSize = true;
            this.RbttMasculido.Location = new System.Drawing.Point(19, 33);
            this.RbttMasculido.Name = "RbttMasculido";
            this.RbttMasculido.Size = new System.Drawing.Size(39, 20);
            this.RbttMasculido.TabIndex = 0;
            this.RbttMasculido.TabStop = true;
            this.RbttMasculido.Text = "M";
            this.RbttMasculido.UseVisualStyleBackColor = true;
            this.RbttMasculido.CheckedChanged += new System.EventHandler(this.RbttMasculido_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Edad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(524, 68);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(204, 22);
            this.txtEdad.TabIndex = 16;
            // 
            // dataGridview1
            // 
            this.dataGridview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridview1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview1.Location = new System.Drawing.Point(12, 154);
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.RowHeadersWidth = 51;
            this.dataGridview1.RowTemplate.Height = 24;
            this.dataGridview1.Size = new System.Drawing.Size(1200, 377);
            this.dataGridview1.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Carrera:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1224, 26);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabelCount.Text = "Listo";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel1.Text = "Nota:";
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1224, 564);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridview1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTTfechanacimiento);
            this.Controls.Add(this.txtSapellido);
            this.Controls.Add(this.txtPapellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSnombre);
            this.Controls.Add(this.txtPnombre);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AgregarAlumno;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EditarAlumno;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton GuardarAlumno;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton EliminarAlumno;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton LimpiarAlumno;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.ToolStripButton CancelarAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtPnombre;
        private System.Windows.Forms.TextBox txtSnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPapellido;
        private System.Windows.Forms.TextBox txtSapellido;
        private System.Windows.Forms.DateTimePicker DTTfechanacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RbttFemenino;
        private System.Windows.Forms.RadioButton RbttMasculido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridView dataGridview1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripTextBox TxtBuscaralumno;
        private System.Windows.Forms.ToolStripButton BuscarAlumno;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}