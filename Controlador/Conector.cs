using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class Conector
    {
        public static DataSet herramientas(string cmd)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=puntoventa;Persist Security Info=True;User ID=sa;Password=pruebas");
            conexion.Open();
            DataSet dll = new DataSet();
            try
            {
                SqlDataAdapter dll1 = new SqlDataAdapter(cmd, conexion);
                dll1.Fill(dll);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexion.Close();
            return dll;
        }
    }
}
