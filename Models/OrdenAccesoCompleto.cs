using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeOrdenes.Models
{
    public class OrdenAccesoCompleto : Orden
    {
        public OrdenAccesoCompleto(string _nombre, string _descripcion) : base(_nombre, _descripcion)
        {
        }

        public void crearOrden(string _nombre, string _descipcion)
        {
            //Realizar la creacion de la orden
        }

        public void actualizarOrden(string _nombre, string _descipcion)
        {
            //Realizar la actualización de la orden
        }
        public void eliminarOrden(string _nombre, string _descipcion)
        {
            //Realizar la eliminación de la orden
        }
    }
}
