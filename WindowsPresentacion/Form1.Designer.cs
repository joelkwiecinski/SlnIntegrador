namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.btnVerMedicos = new System.Windows.Forms.Button();
            this.btnVerPacientes = new System.Windows.Forms.Button();
            this.lstMedicosClinicos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(12, 99);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowHeadersWidth = 72;
            this.gridDatos.RowTemplate.Height = 31;
            this.gridDatos.Size = new System.Drawing.Size(737, 535);
            this.gridDatos.TabIndex = 0;
            // 
            // btnVerMedicos
            // 
            this.btnVerMedicos.Location = new System.Drawing.Point(159, 21);
            this.btnVerMedicos.Name = "btnVerMedicos";
            this.btnVerMedicos.Size = new System.Drawing.Size(217, 59);
            this.btnVerMedicos.TabIndex = 1;
            this.btnVerMedicos.Text = "Cargar médicos";
            this.btnVerMedicos.UseVisualStyleBackColor = true;
            this.btnVerMedicos.Click += new System.EventHandler(this.btnVerMedicos_Click);
            // 
            // btnVerPacientes
            // 
            this.btnVerPacientes.Location = new System.Drawing.Point(382, 21);
            this.btnVerPacientes.Name = "btnVerPacientes";
            this.btnVerPacientes.Size = new System.Drawing.Size(217, 59);
            this.btnVerPacientes.TabIndex = 2;
            this.btnVerPacientes.Text = "Cargar pacientes";
            this.btnVerPacientes.UseVisualStyleBackColor = true;
            this.btnVerPacientes.Click += new System.EventHandler(this.btnVerPacientes_Click);
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.FormattingEnabled = true;
            this.lstMedicosClinicos.ItemHeight = 24;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(785, 99);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(310, 532);
            this.lstMedicosClinicos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Médicos clínicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1118, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Habitaciones";
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.ItemHeight = 24;
            this.lstHabitaciones.Location = new System.Drawing.Point(1123, 99);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(310, 532);
            this.lstHabitaciones.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.btnVerPacientes);
            this.Controls.Add(this.btnVerMedicos);
            this.Controls.Add(this.gridDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.Button btnVerMedicos;
        private System.Windows.Forms.Button btnVerPacientes;
        private System.Windows.Forms.ListBox lstMedicosClinicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstHabitaciones;
    }
}

