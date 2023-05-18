using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private float _precio;
        private int _stock;
        private string _codigo;

        public Producto(int id, string nombre, string descripcion, float precio, int stock, string codigo)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _precio = precio;
            _stock = stock;
            _codigo = codigo;
        }

        public int getId() { return _id; }
        public string getNombre() { return _nombre;}
        public string getDescripcion() {  return _descripcion;}
        public float getPrecio() { return _precio;}
        public int getStock() { return _stock;}
        public string getCodigo() { return _codigo;}

        public void setId(int id) { _id = id; }
        public void setNombre(string nombre) { _nombre = nombre; }
        public void setDescripcion(string descripcion) { _descripcion = descripcion; }
        public void setPrecio(float precio) { _precio = precio; }
        public void setStock(int stock) {  _stock = stock; }
        public void setCodigo(string codigo) { _codigo = codigo; }

        public override string ToString()
        {
            return "ID: " + _id + "\n" +
                "Nombre: " + _nombre + "\n" +
                "Descripción: " + _descripcion + "\n" +
                "Precio: " + _precio + "\n" +
                "Stock: " + _stock + "\n" +
                "Codigo: " + _codigo;
        }
    }
}
