using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _usuario;
        private string _password;

        public Empleado(int id, string nombre, string apellido, string usuario, string password)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._usuario = usuario;
            this._password = password;
        }

        public int getId() { return _id; }
        public string getNombre() { return _nombre; }
        public string getApellido() { return _apellido; }
        public string getUsuario() { return _usuario; }
        public string getPassword() { return _password; }

        public void setId(int id) { _id = id; }
        public void setNombre(string nombre) { _nombre = nombre; }
        public void setApellido(string apellido) { _apellido = apellido; }
        public void setUsuario(string usuario) { _usuario = usuario; }
        public void setPassword(string password) { _password = password; }

        public override string ToString()
        {
            return "ID: " + this._id +
                "\nNombre: " + this._nombre +
                "\nApellido: " + this._apellido +
                "\nUsuario: " + this._usuario;
        }
    }

}
