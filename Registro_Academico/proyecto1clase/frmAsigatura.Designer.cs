namespace proyecto1clase
{
    partial class frmAsigatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsigatura));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarAsignatura = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditarAsignatura = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GuardarAsignatura = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarAsignatura = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.LimpiarAsignatura = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelarAsignatura = new System.Windows.Forms.ToolStripButton();
            this.txtBuscarAsig = new System.Windows.Forms.ToolStripTextBox();
            this.BuscarAsig = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdAsig = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtNombreAsig = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreAsig = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarAsignatura,
            this.toolStripSeparator1,
            this.EditarAsignatura,
            this.toolStripSeparator2,
            this.GuardarAsignatura,
            this.toolStripSeparator3,
            this.EliminarAsignatura,
            this.toolStripSeparator4,
            this.LimpiarAsignatura,
            this.toolStripSeparator5,
            this.CancelarAsignatura,
            this.txtBuscarAsig,
            this.BuscarAsig});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1005, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarAsignatura
            // 
            this.AgregarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("AgregarAsignatura.Image")));
            this.AgregarAsignatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarAsignatura.Name = "AgregarAsignatura";
            this.AgregarAsignatura.Size = new System.Drawing.Size(87, 24);
            this.AgregarAsignatura.Text = "Agregar";
            this.AgregarAsignatura.Click += new System.EventHandler(this.AgregarAsignatura_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // EditarAsignatura
            // 
            this.EditarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("EditarAsignatura.Image")));
            this.EditarAsignatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarAsignatura.Name = "EditarAsignatura";
            this.EditarAsignatura.Size = new System.Drawing.Size(72, 24);
            this.EditarAsignatura.Text = "Editar";
            this.EditarAsignatura.Click += new System.EventHandler(this.EditarAsignatura_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // GuardarAsignatura
            // 
            this.GuardarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("GuardarAsignatura.Image")));
            this.GuardarAsignatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarAsignatura.Name = "GuardarAsignatura";
            this.GuardarAsignatura.Size = new System.Drawing.Size(86, 24);
            this.GuardarAsignatura.Text = "Guardar";
            this.GuardarAsignatura.Click += new System.EventHandler(this.GuardarAsignatura_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // EliminarAsignatura
            // 
            this.EliminarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("EliminarAsignatura.Image")));
            this.EliminarAsignatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarAsignatura.Name = "EliminarAsignatura";
            this.EliminarAsignatura.Size = new System.Drawing.Size(87, 24);
            this.EliminarAsignatura.Text = "Eliminar";
            this.EliminarAsignatura.Click += new System.EventHandler(this.EliminarAsignatura_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // LimpiarAsignatura
            // 
            this.LimpiarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarAsignatura.Image")));
            this.LimpiarAsignatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimpiarAsignatura.Name = "LimpiarAsignatura";
            this.LimpiarAsignatura.Size = new System.Drawing.Size(83, 24);
            this.LimpiarAsignatura.Text = "Limpiar";
            this.LimpiarAsignatura.Click += new System.EventHandler(this.LimpiarAsignatura_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // CancelarAsignatura
            // 
            this.CancelarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("CancelarAsignatura.Image")));
            this.CancelarAsignatura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelarAsignatura.Name = "CancelarAsignatura";
            this.CancelarAsignatura.Size = new System.Drawing.Size(90, 24);
            this.CancelarAsignatura.Text = "Cancelar";
            this.CancelarAsignatura.Click += new System.EventHandler(this.CancelarAsignatura_Click);
            // 
            // txtBuscarAsig
            // 
            this.txtBuscarAsig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarAsig.Name = "txtBuscarAsig";
            this.txtBuscarAsig.Size = new System.Drawing.Size(100, 27);
            // 
            // BuscarAsig
            // 
            this.BuscarAsig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarAsig.Image = ((System.Drawing.Image)(resources.GetObject("BuscarAsig.Image")));
            this.BuscarAsig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarAsig.Name = "BuscarAsig";
            this.BuscarAsig.Size = new System.Drawing.Size(29, 24);
            this.BuscarAsig.Text = "toolStripButton1";
            this.BuscarAsig.Click += new System.EventHandler(this.BuscarAsig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id_Asignatura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creditos";
            // 
            // txtIdAsig
            // 
            this.txtIdAsig.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdAsig.Location = new System.Drawing.Point(107, 35);
            this.txtIdAsig.Name = "txtIdAsig";
            this.txtIdAsig.Size = new System.Drawing.Size(176, 22);
            this.txtIdAsig.TabIndex = 4;
            // 
            // txtCreditos
            // 
            this.txtCreditos.BackColor = System.Drawing.SystemColors.Info;
            this.txtCreditos.Location = new System.Drawing.Point(378, 63);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(176, 22);
            this.txtCreditos.TabIndex = 5;
            // 
            // txtNombreAsig
            // 
            this.txtNombreAsig.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreAsig.Location = new System.Drawing.Point(106, 63);
            this.txtNombreAsig.Name = "txtNombreAsig";
            this.txtNombreAsig.Size = new System.Drawing.Size(176, 22);
            this.txtNombreAsig.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(978, 430);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prerrequisito";
            // 
            // txtPreAsig
            // 
            this.txtPreAsig.BackColor = System.Drawing.SystemColors.Info;
            this.txtPreAsig.Location = new System.Drawing.Point(378, 38);
            this.txtPreAsig.Name = "txtPreAsig";
            this.txtPreAsig.Size = new System.Drawing.Size(176, 22);
            this.txtPreAsig.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1005, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabel1.Text = "Listo";
            // 
            // frmAsigatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1005, 536);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtPreAsig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombreAsig);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtIdAsig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsigatura";
            this.Text = "Asignatura";
            this.Load += new System.EventHandler(this.frmAsigatura_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AgregarAsignatura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditarAsignatura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton GuardarAsignatura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton EliminarAsignatura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton LimpiarAsignatura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton CancelarAsignatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdAsig;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtNombreAsig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreAsig;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripTextBox txtBuscarAsig;
        private System.Windows.Forms.ToolStripButton BuscarAsig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}