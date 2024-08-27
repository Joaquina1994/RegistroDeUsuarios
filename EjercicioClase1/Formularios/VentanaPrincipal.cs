using EjercicioClase1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase1.Formularios
{
    public partial class VentanaPrincipal : Form
    {
        Usuario usuario = new Usuario();
        public VentanaPrincipal()
        {
            InitializeComponent();

            List<string> roles = new List<string>()
            {
                "Admin", "Usuario", "Invitado"
            };
            foreach (var rol in roles)
            {
                comboBoxRol.Items.Add(rol);
            }
        }


        private void btngGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtApellido.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text))
                {
                    throw new Exception("Verifique que todos los campos estén completos.");
                }
                if(numericEdad.Value == 0)
                {
                    throw new Exception("Ingrese una edad correcta.");
                }
                if(comboBoxRol.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar un rol de usuario.");
                }
                if (checkBoxTel.Checked && string.IsNullOrEmpty(txtTelefono.Text))
                {
                    throw new Exception("Ingresar número de teléfono.");
                }

                else
                {
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Edad = numericEdad.Value;
                    usuario.FechaDeNacimiento = dateTimeFechaNac.Value;
                    usuario.Email = txtEmail.Text;
                    usuario.Telefono = txtTelefono.Text;
                    usuario.IdRol = comboBoxRol.SelectedIndex;

                    
                    /*if (string.IsNullOrEmpty(txtTelefono.Text))
                    {
                        MessageBox.Show($"DATOS GUARDADOS:\n" +
                        $"Nombre: {usuario.Nombre}\n" +
                        $"Apellido: {usuario.Apellido}\n" +
                        $"Edad: {usuario.Edad}\n" +
                        $"Fecha de Nacimiento: {usuario.FechaDeNacimiento}\n" +
                        $"Email: {usuario.Email}\n" +
                        $"Rol: {usuario.Rol}");

                    } else
                    {
                        MessageBox.Show($"DATOS GUARDADOS:\n" +
                        $"Nombre: {usuario.Nombre}\n" +
                        $"Apellido: {usuario.Apellido}\n" +
                        $"Edad: {usuario.Edad}\n" +
                        $"Fecha de Nacimiento: {usuario.FechaDeNacimiento}\n" +
                        $"Email: {usuario.Email}\n" +
                        $"Teléfono: {usuario.Telefono}\n" +
                        $"Rol: {usuario.Rol}");
                    }*/

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBoxTel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTel.Checked)
            {
                txtTelefono.Enabled = true;
                txtTelefono.Visible = true;
                labelTel.Enabled = true;
                labelTel.Visible = true;
            }
            else 
            {
                txtTelefono.Enabled = false;
                txtTelefono.Visible = false;
                labelTel.Enabled = false;
                labelTel.Visible = false;
            }
        }
    }
}
