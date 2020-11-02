using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Logica
{
    class Instruccion
    {

        string instruccion;
        public DataTable vistatabla()
        {
            instruccion = "select * from Registro;";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, Datos.Conexion.strCONEXION);
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
            return consulta;


        }
    }
}
