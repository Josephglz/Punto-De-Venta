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
    public partial class home : Form
    {
        private DataTable tablaVentaModel = new DataTable();
        List<Producto> listaProductos = new List<Producto>();
        List<>
        public home()
        {
            InitializeComponent();
        }

        private void mSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void smProductos_Click(object sender, EventArgs e)
        {
            productView _productView = new productView();
            _productView.ShowDialog();
        }

        private void smEmpleados_Click(object sender, EventArgs e)
        {
            empleadoView _empleadoView = new empleadoView();
            _empleadoView.ShowDialog();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "CODIGO DE BARRAS")
            {
                txtCodigo.Text = "";
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if( txtCodigo.Text == "")
            {
                txtCodigo.Text = "CODIGO DE BARRAS";
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AddProduct();
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            loadProductos();
            loadTableData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void loadTableData()
        {
            tablaVentaModel.Columns.Clear();
            tablaVentaModel.Rows.Clear();

            tablaVentaModel.Columns.Add("ID");
            tablaVentaModel.Columns.Add("Producto");
            tablaVentaModel.Columns.Add("Cantidad");
            tablaVentaModel.Columns.Add("Subtotal");


            tablaVentas.DataSource = tablaVentaModel;
        }

        private void loadProductos()
        {
            DataSet productos = new DataSet();
            listaProductos.Clear();

            productos = Conector.herramientas("SELECT * FROM Productos");
            int id = 0, stock = 0;
            string nombre = "", descripcion = "", codigo = "";
            float precio = 0.0f;

            for (int i = 0; i < productos.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(productos.Tables[0].Rows[i]["id"].ToString().Trim());
                stock = Convert.ToInt32(productos.Tables[0].Rows[i]["stock"].ToString().Trim());

                nombre = productos.Tables[0].Rows[i]["nombre"].ToString().Trim();
                descripcion = productos.Tables[0].Rows[i]["descripcion"].ToString().Trim();
                codigo = productos.Tables[0].Rows[i]["codigo"].ToString().Trim();

                precio = float.Parse(productos.Tables[0].Rows[i]["precio"].ToString().Trim());

                listaProductos.Add(new Producto(id, nombre, descripcion, precio, stock, codigo));
            }
        }

        private void AddProduct()
        {
            string codigoBarras = txtCodigo.Text.Trim();
            if(codigoBarras != "")
            {
                Producto producto = listaProductos.FirstOrDefault(p => p.getCodigo() == codigoBarras);

                if(producto != null)
                {
                    tablaVentaModel.Rows.Add(producto.getId(), producto.getNombre(), );
                }
            } else
            {
                txtCodigo.Text = "CODIGO DE BARRAS";
            }
        }
    }
}
