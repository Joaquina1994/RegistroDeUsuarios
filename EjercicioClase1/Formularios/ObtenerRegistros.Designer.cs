namespace EjercicioClase1.Formularios
{
    partial class ObtenerRegistros
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
            btnObtener = new Button();
            dataGridTabla = new DataGridView();
            columnNombre = new DataGridViewTextBoxColumn();
            columnApellido = new DataGridViewTextBoxColumn();
            columnEdad = new DataGridViewTextBoxColumn();
            columnFechaDeNacimiento = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            columnTelefono = new DataGridViewTextBoxColumn();
            columnRol = new DataGridViewTextBoxColumn();
            labelIdUsuario = new Label();
            numericIdUsuario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridTabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnObtener
            // 
            btnObtener.Location = new Point(55, 28);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(219, 34);
            btnObtener.TabIndex = 0;
            btnObtener.Text = "Obtener Registros";
            btnObtener.UseVisualStyleBackColor = true;
            btnObtener.Click += btnObtener_Click;
            // 
            // dataGridTabla
            // 
            dataGridTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTabla.Columns.AddRange(new DataGridViewColumn[] { columnNombre, columnApellido, columnEdad, columnFechaDeNacimiento, columnEmail, columnTelefono, columnRol });
            dataGridTabla.Location = new Point(55, 142);
            dataGridTabla.Name = "dataGridTabla";
            dataGridTabla.RowHeadersWidth = 62;
            dataGridTabla.Size = new Size(1114, 340);
            dataGridTabla.TabIndex = 1;
            // 
            // columnNombre
            // 
            columnNombre.HeaderText = "Nombre";
            columnNombre.MinimumWidth = 8;
            columnNombre.Name = "columnNombre";
            columnNombre.Width = 150;
            // 
            // columnApellido
            // 
            columnApellido.HeaderText = "Apellido";
            columnApellido.MinimumWidth = 8;
            columnApellido.Name = "columnApellido";
            columnApellido.Width = 150;
            // 
            // columnEdad
            // 
            columnEdad.HeaderText = "Edad";
            columnEdad.MinimumWidth = 8;
            columnEdad.Name = "columnEdad";
            columnEdad.Width = 150;
            // 
            // columnFechaDeNacimiento
            // 
            columnFechaDeNacimiento.HeaderText = "Fecha de nacimiento";
            columnFechaDeNacimiento.MinimumWidth = 8;
            columnFechaDeNacimiento.Name = "columnFechaDeNacimiento";
            columnFechaDeNacimiento.Width = 150;
            // 
            // columnEmail
            // 
            columnEmail.HeaderText = "Email";
            columnEmail.MinimumWidth = 8;
            columnEmail.Name = "columnEmail";
            columnEmail.Width = 150;
            // 
            // columnTelefono
            // 
            columnTelefono.HeaderText = "Teléfono";
            columnTelefono.MinimumWidth = 8;
            columnTelefono.Name = "columnTelefono";
            columnTelefono.Width = 150;
            // 
            // columnRol
            // 
            columnRol.HeaderText = "Rol";
            columnRol.MinimumWidth = 8;
            columnRol.Name = "columnRol";
            columnRol.Width = 150;
            // 
            // labelIdUsuario
            // 
            labelIdUsuario.AutoSize = true;
            labelIdUsuario.Location = new Point(55, 84);
            labelIdUsuario.Name = "labelIdUsuario";
            labelIdUsuario.Size = new Size(95, 25);
            labelIdUsuario.TabIndex = 2;
            labelIdUsuario.Text = "ID Usuario";
            // 
            // numericIdUsuario
            // 
            numericIdUsuario.Location = new Point(156, 78);
            numericIdUsuario.Name = "numericIdUsuario";
            numericIdUsuario.Size = new Size(76, 31);
            numericIdUsuario.TabIndex = 3;
            // 
            // ObtenerRegistros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 551);
            Controls.Add(numericIdUsuario);
            Controls.Add(labelIdUsuario);
            Controls.Add(dataGridTabla);
            Controls.Add(btnObtener);
            Name = "ObtenerRegistros";
            Text = "ObtenerRegistros";
            ((System.ComponentModel.ISupportInitialize)dataGridTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObtener;
        private DataGridView dataGridTabla;
        private DataGridViewTextBoxColumn columnNombre;
        private DataGridViewTextBoxColumn columnApellido;
        private DataGridViewTextBoxColumn columnEdad;
        private DataGridViewTextBoxColumn columnFechaDeNacimiento;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnTelefono;
        private DataGridViewTextBoxColumn columnRol;
        private Label labelIdUsuario;
        private NumericUpDown numericIdUsuario;
    }
}