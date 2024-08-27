using EjercicioClase1.Modelos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1.Clases
{
    public class ConexionDataBase
    {
        public string ConnectionString()
        {
            string connectionString = "data source=Joaquina\\SQLEXPRESS;initial catalog=RegistroDeUsuarios;trusted_connection=true;TrustServerCertificate=True;";
;

            return connectionString;
        }


    }
}
