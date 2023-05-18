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
    public partial class empleadoView : Form
    {
        private DataTable tablaModelo = new DataTable();
        List<Empleado> listaEmpleados = new List<Empleado>();
        int lastIDp = 0, editando = 0;
        public empleadoView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void empleadoView_Load(object sender, EventArgs e)
        {
            loadTableColumns();
        }

        private void loadTableColumns()
        {
            tablaModelo.Columns.Clear();
            tablaModelo.Rows.Clear();

            tablaModelo.Columns.Add("ID");
            tablaModelo.Columns.Add("Nombre");
            tablaModelo.Columns.Add("Apellido");
            tablaModelo.Columns.Add("Usuario");

            loadTableRows();

            tablaEmpleados.DataSource = tablaModelo;
        }

        public void loadTableRows()
        {
            loadProductos();

            for(int i = 0; i < listaEmpleados.Count; i++)
            {
                tablaModelo.Rows.Add(listaEmpleados.ElementAt(i).getId(),
                    listaEmpleados.ElementAt(i).getNombre(),
                    listaEmpleados.ElementAt(i).getApellido(),
                    listaEmpleados.ElementAt(i).getUsuario());
            }
        }

        private void loadProductos() {
            DataSet empleados = new DataSet();
            listaEmpleados.Clear();

            empleados = Conector.herramientas("SELECT * FROM Empleado");
            int id = 0;
            string nombre = "", apellido = "", usuario = "", password = "";

            for(int i = 0; i < empleados.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(empleados.Tables[0].Rows[i]["id"].ToString().Trim());

                nombre = empleados.Tables[0].Rows[i]["nombre"].ToString().Trim();
                apellido = empleados.Tables[0].Rows[i]["apellido"].ToString().Trim();
                usuario = empleados.Tables[0].Rows[i]["usuario"].ToString().Trim();
                password = empleados.Tables[0].Rows[i]["password"].ToString().Trim();

                listaEmpleados.Add(new Empleado(id, nombre, apellido, usuario, password));
                lastIDp = id + 1;
            }
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = listaEmpleados.ElementAt(e.RowIndex).getNombre();
            txtApellido.Text = "" + listaEmpleados.ElementAt(e.RowIndex).getApellido();
            txtUsuario.Text = listaEmpleados.ElementAt(e.RowIndex).getUsuario();
            txtPassword.Text = "" + listaEmpleados.ElementAt(e.RowIndex).getPassword();
            editando = listaEmpleados.ElementAt(e.RowIndex).getId();
            btnEliminar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editando == 0)
            {
                string query = "";
                query = "INSERT INTO Empleado (id, nombre, apellido, usuario, password) VALUES (" + 
                    lastIDp+ ",'" + txtNombre.Text + "','" + txtApellido.Text +
                    "','" + txtUsuario.Text + "','" +txtPassword.Text + ");";
                Conector.herramientas(query);

                loadTableColumns();
                editando = -1;

            } else if (editando > 0)
            {
                string query = "";
                query = "UPDATE Empleado SET id=" +
                    lastIDp + ", nombre='" + txtNombre.Text +"', apellido='" + txtApellido.Text + "',usuario='" + 
                    txtUsuario.Text + "', password='" + txtPassword.Text + "' where id=" + editando + ";";
                Conector.herramientas(query);

                loadTableColumns();
                editando = -1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query = "";
            query = "DELETE FROM Empleado Where id = " + editando + ";";
            Conector.herramientas(query);

            loadTableColumns();
            editando = -1;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPassword.Text = "";
            txtUsuario.Text = "";
            editando = -1;
            btnEliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            editando = -1;
            btnEliminar.Enabled = false;
        }
    }
}
