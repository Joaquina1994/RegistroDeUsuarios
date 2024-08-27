namespace RegistroDeUsuarios.Formularios
{
    partial class Inicio
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
            btnFormObtenerRegistros = new Button();
            btnFormAlta = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnFormObtenerRegistros
            // 
            btnFormObtenerRegistros.Location = new Point(297, 52);
            btnFormObtenerRegistros.Name = "btnFormObtenerRegistros";
            btnFormObtenerRegistros.Size = new Size(202, 34);
            btnFormObtenerRegistros.TabIndex = 0;
            btnFormObtenerRegistros.Text = "Registros";
            btnFormObtenerRegistros.UseVisualStyleBackColor = true;
            btnFormObtenerRegistros.Click += btnFormObtenerRegistros_Click;
            // 
            // btnFormAlta
            // 
            btnFormAlta.Location = new Point(297, 164);
            btnFormAlta.Name = "btnFormAlta";
            btnFormAlta.Size = new Size(202, 34);
            btnFormAlta.TabIndex = 1;
            btnFormAlta.Text = "Alta de Usuarios";
            btnFormAlta.UseVisualStyleBackColor = true;
            btnFormAlta.Click += btnFormAlta_Click;
            // 
            // button3
            // 
            button3.Location = new Point(338, 257);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(338, 355);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnFormAlta);
            Controls.Add(btnFormObtenerRegistros);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFormObtenerRegistros;
        private Button btnFormAlta;
        private Button button3;
        private Button button4;
    }
}