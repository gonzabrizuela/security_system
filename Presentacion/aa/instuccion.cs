using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Presentacion.aa
{
    class instuccion
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
        string instruccion2;
        public DataTable vistatabla2()
        {
            instruccion2 = "select * from Aperturas;";
            MySqlDataAdapter adps = new MySqlDataAdapter(instruccion2, Datos.Conexion.strCONEXION);
            DataTable consultar = new DataTable();
            adps.Fill(consultar);
            return consultar;


        }
    }
}
