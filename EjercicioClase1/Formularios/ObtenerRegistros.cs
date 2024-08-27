using EjercicioClase1.Modelos;
using Microsoft.IdentityModel.Tokens;
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
    public partial class ObtenerRegistros : Form
    {
        public ObtenerRegistros()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();    
        private void btnObtener_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
            
        }

        private void GuardarUsuario()
        {
            dataGridTabla.Rows.Clear();

            if(numericIdUsuario.Value == 0 )
            {
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = usuario.TraerUsuarios();

                foreach (var usuario in usuarios)
                {
                    dataGridTabla.Rows.Add(usuario.Nombre, usuario.Apellido, usuario.Edad, usuario.FechaDeNacimiento, usuario.Email, usuario.Telefono, usuario.IdRol);
                }

            }
            else
            {
                int idUsuario = Convert.ToInt32(numericIdUsuario.Value);
                Usuario nuevoUsuario = new Usuario();   
                nuevoUsuario = nuevoUsuario.TraerUsuarioPorId(idUsuario);

                dataGridTabla.Rows.Add(nuevoUsuario.Nombre, nuevoUsuario.Apellido, nuevoUsuario.Edad, nuevoUsuario.FechaDeNacimiento, nuevoUsuario.Email, nuevoUsuario.Telefono, nuevoUsuario.IdRol);   


            }

           

        }
    }
}
