using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeOrdenes.Models
{
    public class Verificacion
    {
        public string tipo { get; set; }

        public Verificacion(string _tipo)
        {
            tipo = _tipo;
        }

        public void registrarVerificacion(string tipo) { }
    }
}
