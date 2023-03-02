using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeOrdenes.Models
{
    public class OrdenCreacion : Orden
    {
        public OrdenCreacion(string _nombre, string _descripcion) : base(_nombre, _descripcion)
        {
        }

        public void crearOrden(string _nombre, string _descipcion)
        {
            //Realizar la creacion de la orden
        }
    }
}
