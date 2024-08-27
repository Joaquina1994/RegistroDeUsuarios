namespace EjercicioClase1.Formularios
{
    partial class Alta
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericEdad = new NumericUpDown();
            dateTimeFechaNac = new DateTimePicker();
            label6 = new Label();
            checkBoxTel = new CheckBox();
            txtTelefono = new TextBox();
            comboBoxRol = new ComboBox();
            btngGuardar = new Button();
            label7 = new Label();
            txtEmail = new TextBox();
            labelTel = new Label();
            labelRol = new Label();
            ((System.ComponentModel.ISupportInitialize)numericEdad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 71);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtNombre.Location = new Point(122, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 24);
            label2.Name = "label2";
            label2.Size = new Size(216, 25);
            label2.TabIndex = 2;
            label2.Text = "REGISTRO DE USUARIO";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.GradientInactiveCaption;
            txtApellido.Location = new Point(122, 116);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 119);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 166);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 5;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 208);
            label5.Name = "label5";
            label5.Size = new Size(190, 25);
            label5.TabIndex = 6;
            label5.Text = "Fecha de Nacimiento";
            // 
            // numericEdad
            // 
            numericEdad.BackColor = SystemColors.GradientInactiveCaption;
            numericEdad.Location = new Point(122, 164);
            numericEdad.Name = "numericEdad";
            numericEdad.Size = new Size(68, 31);
            numericEdad.TabIndex = 7;
            // 
            // dateTimeFechaNac
            // 
            dateTimeFechaNac.CalendarMonthBackground = SystemColors.GradientInactiveCaption;
            dateTimeFechaNac.Format = DateTimePickerFormat.Short;
            dateTimeFechaNac.Location = new Point(234, 202);
            dateTimeFechaNac.Name = "dateTimeFechaNac";
            dateTimeFechaNac.Size = new Size(122, 31);
            dateTimeFechaNac.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 310);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 9;
            label6.Text = "Teléfono";
            // 
            // checkBoxTel
            // 
            checkBoxTel.AutoSize = true;
            checkBoxTel.Location = new Point(127, 314);
            checkBoxTel.Name = "checkBoxTel";
            checkBoxTel.Size = new Size(22, 21);
            checkBoxTel.TabIndex = 10;
            checkBoxTel.UseVisualStyleBackColor = true;
            checkBoxTel.CheckedChanged += checkBoxTel_CheckedChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.GradientInactiveCaption;
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(349, 304);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 11;
            txtTelefono.Visible = false;
            // 
            // comboBoxRol
            // 
            comboBoxRol.BackColor = SystemColors.GradientInactiveCaption;
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(187, 357);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(182, 33);
            comboBoxRol.TabIndex = 12;
            // 
            // btngGuardar
            // 
            btngGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btngGuardar.Location = new Point(257, 438);
            btngGuardar.Name = "btngGuardar";
            btngGuardar.Size = new Size(112, 34);
            btngGuardar.TabIndex = 13;
            btngGuardar.Text = "Registrar";
            btngGuardar.UseVisualStyleBackColor = true;
            btngGuardar.Click += btngGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 259);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.GradientInactiveCaption;
            txtEmail.Location = new Point(98, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 15;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Enabled = false;
            labelTel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTel.Location = new Point(176, 310);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(181, 25);
            labelTel.TabIndex = 16;
            labelTel.Text = "Ingrese un Teléfono";
            labelTel.Visible = false;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRol.Location = new Point(38, 360);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(153, 25);
            labelRol.TabIndex = 17;
            labelRol.Text = "Elige una opción";
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(653, 508);
            Controls.Add(labelRol);
            Controls.Add(labelTel);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(btngGuardar);
            Controls.Add(comboBoxRol);
            Controls.Add(txtTelefono);
            Controls.Add(checkBoxTel);
            Controls.Add(label6);
            Controls.Add(dateTimeFechaNac);
            Controls.Add(numericEdad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "VentanaPrincipal";
            Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)numericEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericEdad;
        private DateTimePicker dateTimeFechaNac;
        private Label label6;
        private CheckBox checkBoxTel;
        private TextBox txtTelefono;
        private ComboBox comboBoxRol;
        private Button btngGuardar;
        private Label label7;
        private TextBox txtEmail;
        private Label labelTel;
        private Label labelRol;
    }
}