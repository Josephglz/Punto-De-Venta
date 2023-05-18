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
    public partial class productView : Form
    {
        private DataTable tablaModelo = new DataTable();
        List<Producto> listaProductos = new List<Producto>();
        int lastIDp = 0, editando = 0;
        public productView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productView_Load(object sender, EventArgs e)
        {
            loadTableColumns();
        }

        private void loadTableColumns()
        {
            tablaModelo.Columns.Clear();
            tablaModelo.Rows.Clear();

            tablaModelo.Columns.Add("ID");
            tablaModelo.Columns.Add("Nombre");
            tablaModelo.Columns.Add("Precio");
            tablaModelo.Columns.Add("Stock");

            loadTableRows();

            tablaProductos.DataSource = tablaModelo;
        }

        public void loadTableRows()
        {
            loadProductos();

            for(int i = 0; i < listaProductos.Count; i++)
            {
                tablaModelo.Rows.Add(listaProductos.ElementAt(i).getId(),
                    listaProductos.ElementAt(i).getNombre(),
                    listaProductos.ElementAt(i).getPrecio(),
                    listaProductos.ElementAt(i).getStock());
            }
        }

        private void loadProductos() {
            DataSet productos = new DataSet();
            listaProductos.Clear();

            productos = Conector.herramientas("SELECT * FROM Productos");
            int id = 0, stock = 0;
            string nombre = "", descripcion = "", codigo = "";
            float precio = 0.0f;

            for(int i = 0; i < productos.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(productos.Tables[0].Rows[i]["id"].ToString().Trim());
                stock = Convert.ToInt32(productos.Tables[0].Rows[i]["stock"].ToString().Trim());

                nombre = productos.Tables[0].Rows[i]["nombre"].ToString().Trim();
                descripcion = productos.Tables[0].Rows[i]["descripcion"].ToString().Trim();
                codigo = productos.Tables[0].Rows[i]["codigo"].ToString().Trim();

                precio = float.Parse(productos.Tables[0].Rows[i]["precio"].ToString().Trim());

                listaProductos.Add(new Producto(id, nombre, descripcion, precio, stock, codigo));
                lastIDp = id + 1;
            }
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = listaProductos.ElementAt(e.RowIndex).getNombre();
            txtPrecio.Text = "" + listaProductos.ElementAt(e.RowIndex).getPrecio();
            txtDescripcion.Text = listaProductos.ElementAt(e.RowIndex).getDescripcion();
            txtStock.Text = "" + listaProductos.ElementAt(e.RowIndex).getStock();
            txtCodigo.Text = listaProductos.ElementAt(e.RowIndex).getCodigo();
            editando = listaProductos.ElementAt(e.RowIndex).getId();
            btnEliminar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editando == 0)
            {
                string query = "";
                query = "INSERT INTO Productos (id, nombre, descripcion, precio, stock) VALUES (" + 
                    lastIDp+ ",'" + txtNombre.Text + "','" + txtDescripcion.Text +
                    "'," + float.Parse(txtPrecio.Text) + "," + Convert.ToInt32(txtStock.Text) + ");";
                Conector.herramientas(query);

                loadTableColumns();
                editando = -1;

            } else if (editando > 0)
            {
                string query = "";
                query = "UPDATE Productos SET id=" +
                    lastIDp + ", nombre='" + txtNombre.Text +"', descripcion='" + txtDescripcion.Text + "',precio=" + 
                    float.Parse(txtPrecio.Text) + ", stock=" + Convert.ToInt32(txtStock.Text) + " where id=" + listaProductos.ElementAt(editando).getId() + ";";
                Conector.herramientas(query);

                loadTableColumns();
                editando = -1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query = "";
            query = "DELETE FROM Productos Where id = " + editando + ";";
            Conector.herramientas(query);

            loadTableColumns();
            editando = -1;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            editando = -1;
            btnEliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            editando = -1;
            btnEliminar.Enabled = false;
        }
    }
}
