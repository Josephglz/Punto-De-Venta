﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Conector
    {
        public static DataSet herramientas(string cmd)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=puntoventa;Persist Security Info=True;User ID=sa;Password=prointernet");
            conexion.Open();

            DataSet dll = new DataSet();
            SqlDataAdapter dll1 = new SqlDataAdapter(cmd, conexion);

            dll1.Fill(dll);

            conexion.Close();
            return dll;
        }
    }
}
