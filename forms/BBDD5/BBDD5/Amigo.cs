using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD5
{
    internal class Amigo
    {
        private int _id;
        private string _nombre;
        private string _email;

        public int Id { get => _id; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Email { get => _email; set => _email = value; }

        public Amigo(int id, string nombre, string email)
        {
            this._id = id;
            this._nombre = nombre;
            this._email = email;
        }

        public Amigo()
        {
        }

        

        public override string ToString()
        {
            return $"{_id}.\t {_nombre}, email:\t {_email}";
        }
    }
}
