using Controlador;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Modelo;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = iTextSharp.text.Font;

namespace Vista
{
    public partial class home : Form
    {
        private DataTable tablaVentaModel = new DataTable();
        List<Producto> listaProductos = new List<Producto>();
        List<VentaDetalle> listaVenta = new List<VentaDetalle>();

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
            if (txtCodigo.Text == "CODIGO DE BARRAS")
            {
                txtCodigo.Text = "";
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
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
            tablaVentaModel.Columns.Add("Precio");
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
            if (codigoBarras != "")
            {
                Producto producto = listaProductos.FirstOrDefault(p => p.getCodigo() == codigoBarras);

                if (producto != null)
                {
                    VentaDetalle ventaExistente = listaVenta.FirstOrDefault(v => v.getProducto().getCodigo() == codigoBarras);

                    if (ventaExistente != null)
                    {
                        ventaExistente.setCantidad(ventaExistente.getCantidad() + 1);
                        ventaExistente.setSubTotal();
                        ActualizarFilaTablaVenta(ventaExistente);
                    }
                    else
                    {
                        VentaDetalle nuevaVenta = new VentaDetalle(producto, 1);
                        listaVenta.Add(nuevaVenta);
                        tablaVentaModel.Rows.Add(
                            producto.getId(),
                            producto.getNombre(),
                            nuevaVenta.getCantidad(),
                            producto.getPrecio(),
                            nuevaVenta.getSubTotal());
                    }

                    ActualizarTotal();
                }
            }
            else
            {
                txtCodigo.Text = "CODIGO DE BARRAS";
            }
        }

        private void ActualizarFilaTablaVenta(VentaDetalle ventaDetalle)
        {
            foreach (DataGridViewRow row in tablaVentas.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["ID"].Value);
                if (ventaDetalle.getProducto().getId() == idProducto)
                {
                    row.Cells["Cantidad"].Value = ventaDetalle.getCantidad();
                    row.Cells["Subtotal"].Value = ventaDetalle.getSubTotal();
                    break;
                }
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (tablaVentas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablaVentas.SelectedRows[0];
                int idProducto = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                VentaDetalle ventaDetalle = listaVenta.FirstOrDefault(v => v.getProducto().getId() == idProducto);
                if (ventaDetalle != null)
                {
                    ventaDetalle.setCantidad(ventaDetalle.getCantidad() + 1);
                    ventaDetalle.setSubTotal();

                    selectedRow.Cells["Cantidad"].Value = ventaDetalle.getCantidad();
                    selectedRow.Cells["Subtotal"].Value = ventaDetalle.getSubTotal();
                    ActualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila de la tabla.");
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (tablaVentas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablaVentas.SelectedRows[0];
                int idProducto = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                VentaDetalle ventaDetalle = listaVenta.FirstOrDefault(v => v.getProducto().getId() == idProducto);
                if (ventaDetalle != null)
                {
                    if (ventaDetalle.getCantidad() > 1)
                    {
                        ventaDetalle.setCantidad(ventaDetalle.getCantidad() - 1);
                        ventaDetalle.setSubTotal();

                        selectedRow.Cells["Cantidad"].Value = ventaDetalle.getCantidad();
                        selectedRow.Cells["Subtotal"].Value = ventaDetalle.getSubTotal();
                        ActualizarTotal();
                    }
                    else
                    {
                        listaVenta.Remove(ventaDetalle);
                        tablaVentas.Rows.Remove(selectedRow);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila de la tabla.");
            }
        }

        private void ActualizarTotal()
        {
            float total = listaVenta.Sum(v => v.getSubTotal());
            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tablaVentas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablaVentas.SelectedRows[0];
                int idProducto = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                VentaDetalle ventaDetalle = listaVenta.FirstOrDefault(v => v.getProducto().getId() == idProducto);
                if (ventaDetalle != null)
                {
                    listaVenta.Remove(ventaDetalle);

                    DataRowView selectedDataRowView = (DataRowView)selectedRow.DataBoundItem;
                    DataRow selectedDataRow = selectedDataRowView.Row;
                    tablaVentaModel.Rows.Remove(selectedDataRow);

                    ActualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila de la tabla.");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (listaVenta.Count > 0)
            {
                float total = listaVenta.Sum(v => v.getSubTotal());
                Pago vVenta = new Pago(total);
                DialogResult result = vVenta.ShowDialog();
                if (result == DialogResult.OK)
                {
                    GenerarVenta();
                } else
                {
                    MessageBox.Show("Se canceló el pago del carrito.", "Pago cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Agrega productos al carrito.");
            }
        }

        private void GenerarVenta()
        {
            float total = listaVenta.Sum(v => v.getSubTotal());
            DataSet venta = new DataSet();
            string insertQuery = string.Format("INSERT INTO Ventas (FechaVenta, Total) VALUES (GETDATE(), {0}); SELECT SCOPE_IDENTITY() as IDNUEVO;", total);
            venta = Conector.herramientas(insertQuery);

            int newID = Convert.ToInt32(venta.Tables[0].Rows[0]["IDNUEVO"]);

            foreach (VentaDetalle detalle in listaVenta)
            {
                string query = string.Format("INSERT INTO DetalleVenta (ventaId, productoId, cantidad, precio) VALUES ({0}, {1}, {2}, {3});",
                    newID, 
                    detalle.getProducto().getId(),
                    detalle.getCantidad(),
                    detalle.getProducto().getPrecio());
                venta = Conector.herramientas(insertQuery);
            }

            GenerarTicketVenta();
            LimpiarCarrito();
        }

        private void GenerarTicketVenta()
        {
            // Crear documento PDF
            Document document = new Document();

            // Crear un escritor de PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("TicketVenta.pdf", FileMode.Create));

            // Abrir el documento
            document.Open();

            // Agregar contenido al documento
            // ...

            // Agregar encabezado
            Paragraph encabezado = new Paragraph("Ticket de Venta");
            encabezado.Alignment = Element.ALIGN_CENTER;
            document.Add(encabezado);

            // Agregar información de la venta

            DateTime fechaVentaA = DateTime.Now;
            Paragraph fechaVenta = new Paragraph($"Fecha: {fechaVentaA}");
            document.Add(fechaVenta);

            float total = listaVenta.Sum(v => v.getSubTotal());
            Paragraph totalVenta = new Paragraph($"Total: {total}");
            document.Add(totalVenta);

            // Agregar lista de productos
            PdfPTable tablaProductos = new PdfPTable(3); // 3 columnas: Nombre, Cantidad, Subtotal
            tablaProductos.WidthPercentage = 100;

            // Encabezados de la tabla
            tablaProductos.AddCell("Nombre");
            tablaProductos.AddCell("Cantidad");
            tablaProductos.AddCell("Subtotal");

            // Detalles de la venta
            foreach (VentaDetalle detalle in listaVenta)
            {
                tablaProductos.AddCell(detalle.getProducto().getNombre());
                tablaProductos.AddCell(detalle.getCantidad().ToString());
                tablaProductos.AddCell(detalle.getSubTotal().ToString());
            }

            // Agregar tabla al documento
            document.Add(tablaProductos);

            // Cerrar el documento
            document.Close();

            // Abrir el archivo PDF generado
            System.Diagnostics.Process.Start("TicketVenta.pdf");
        }

        private void LimpiarCarrito()
        {
            tablaVentaModel.Rows.Clear();
            listaVenta.Clear();
        }

        private void smVentas_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            // Crear documento PDF
            Document document = new Document();

            // Crear un escritor de PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("InformeVentas.pdf", FileMode.Create));

            // Abrir el documento
            document.Open();

            // Agregar contenido al documento
            // ...

            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Agregar encabezado con la fecha actual
            Paragraph encabezado = new Paragraph($"Informe de Ventas - {fechaActual.ToString("dd/MM/yyyy")}");
            encabezado.Alignment = Element.ALIGN_CENTER;
            document.Add(encabezado);

            // Obtener la cantidad de ventas
            int cantidadVentas = ObtenerCantidadVentas(); // Método para obtener la cantidad de ventas desde tu lógica de negocio

            // Agregar cantidad de ventas al informe
            Paragraph cantidadVentasParrafo = new Paragraph($"Cantidad de Ventas: {cantidadVentas}");
            document.Add(cantidadVentasParrafo);

            // Obtener el total de ingresos por ventas
            float totalIngresos = ObtenerTotalIngresosVentas(); // Método para obtener el total de ingresos desde tu lógica de negocio

            // Agregar total de ingresos por ventas al informe
            Paragraph totalIngresosParrafo = new Paragraph($"Total de Ingresos: {totalIngresos.ToString("C")}");
            document.Add(totalIngresosParrafo);

            // Agregar total de ingresos por ventas al informe
            Paragraph espaciador = new Paragraph($"INVENTARIO DE PRODUCTOS");
            document.Add(espaciador);
            Paragraph espaciador2 = new Paragraph($"\n");
            document.Add(espaciador2);

            // Obtener el listado de productos en stock
            List<Producto> productosEnStock = GetproductosEnStock(); // Método para obtener el listado de productos en stock desde tu lógica de negocio

            // Crear la tabla de productos en stock
            PdfPTable tablaProductos = new PdfPTable(5); // 4 columnas: ID, Nombre, Stock, Precio
            tablaProductos.WidthPercentage = 100;

            // Encabezados de la tabla
            tablaProductos.AddCell("ID");
            tablaProductos.AddCell("Nombre");
            tablaProductos.AddCell("Stock");
            tablaProductos.AddCell("Precio");
            tablaProductos.AddCell("Código Barras");

            // Detalles de los productos en stock
            foreach (Producto producto in productosEnStock)
            {
                tablaProductos.AddCell(producto.getId().ToString());
                tablaProductos.AddCell(producto.getNombre());
                tablaProductos.AddCell(producto.getStock().ToString());
                tablaProductos.AddCell(producto.getPrecio().ToString("C"));
                tablaProductos.AddCell(producto.getCodigo().ToString());
            }

            // Agregar tabla al informe
            document.Add(tablaProductos);

            // Cerrar el documento
            document.Close();

            // Abrir el archivo PDF generado
            System.Diagnostics.Process.Start("InformeVentas.pdf");
        }


        private int ObtenerCantidadVentas()
        {
            string str = "SELECT COUNT(*) as CANTIDAD FROM Ventas;";
            DataSet venta = new DataSet();
            venta = Conector.herramientas(str);
            return Convert.ToInt32(venta.Tables[0].Rows[0]["CANTIDAD"]);
        }

        private float ObtenerTotalIngresosVentas()
        {
            string str = "SELECT SUM(Total) as SUMA FROM Ventas";
            DataSet venta = new DataSet();
            venta = Conector.herramientas(str);
            return float.Parse(venta.Tables[0].Rows[0]["SUMA"].ToString());
        }

        private List<Producto> GetproductosEnStock() {

            DataSet productos = new DataSet();
            List<Producto> productosStock = new List<Producto>();
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

                productosStock.Add(new Producto(id, nombre, descripcion, precio, stock, codigo));
            }
            return productosStock;
        }
    }

}
