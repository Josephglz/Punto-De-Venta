using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            DataSet user = new DataSet();
            string str = "SELECT * FROM Empleado where usuario='" +txtUsuario.Text + "' and password='" + txtPassword.Text + "';";
            user = Conector.herramientas(str);

            if (user.Tables[0].Rows.Count  > 0 )
            {
                MessageBox.Show("Bienvenido " + user.Tables[0].Rows[0]["nombre"], "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                home viewHome = new home();
                viewHome.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Las credenciales son incorrectas", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
