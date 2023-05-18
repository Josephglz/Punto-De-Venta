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
    public partial class Pago : Form
    {
        private float total;
        public Pago(float total)
        {
            this.total = total;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            float pago = float.Parse(txtPago.Text);
            if(pago >= total)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("El pago es menor al total de la compra.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void txtPago_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtPago.Text, out float pago) && pago >= total)
            {
                float cambio = pago - total;
                txtCambio.Text = "$" + cambio.ToString("0.00");
            }
            else
            {
                txtCambio.Text = string.Empty;
            }
        }
    }
}
