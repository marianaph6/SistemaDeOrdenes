using SistemaDeOrdenes.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeOrdenes.Models
{
    public class Orden
    {
        private Autenticacion autenticacion;

        public Orden(string _nombre, string _descripcion)
        {
            nombre = _nombre;
            descripcion= _descripcion;
        }
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public bool verificarRolUsuario() 
        {
            bool result = autenticacion.validarCredenciales();
            return result;
        }
    }
}
