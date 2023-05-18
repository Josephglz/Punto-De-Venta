using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class VentaDetalle
    {
        private Producto _producto;
        private int _cantidad;
        private float _subTotal;

        public VentaDetalle(Producto producto, int cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
            _subTotal = (producto.getPrecio() * cantidad);
        }

        public void setProducto(Producto producto)
        {
            _producto = producto;
        }

        public Producto getProducto()
        {
            return _producto;
        }

        public int getCantidad()
        {
            return _cantidad;
        }

        public void setCantidad(int cantidad)
        {
            _cantidad = cantidad;
        }

        public float getSubTotal()
        {
            return _subTotal;
        }

        public void setSubTotal()
        {
            _subTotal = this._producto.getPrecio() * _cantidad;
        }


    }


}
