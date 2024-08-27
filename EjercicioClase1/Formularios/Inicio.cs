using EjercicioClase1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeUsuarios.Formularios
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnFormObtenerRegistros_Click(object sender, EventArgs e)
        {
            ObtenerRegistros obtenerRegistrosForm = new ObtenerRegistros();
            obtenerRegistrosForm.Show();
        }

        private void btnFormAlta_Click(object sender, EventArgs e)
        {
            Alta ventanaPrincipalForm = new Alta();
            ventanaPrincipalForm.Show();    
        }
    }
}
