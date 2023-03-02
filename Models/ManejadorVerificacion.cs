using SistemaDeOrdenes.Interfaces;
using SistemaDeOrdenes.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeOrdenes.Models
{
    public class ManejadorVerificacion : IManejadorVerificacion
    {
        private Autenticacion autenticacion;
        private List<Verificacion> verificacionList;

        public ManejadorVerificacion()
        {
            verificacionList= new List<Verificacion>();
            verificacionList.Add(new VerificacionAdicional("VerificacionCaché"));
            verificacionList.Add(new VerificacionAdicional("VerificacionDatos"));
            verificacionList.Add(new VerificacionAdicional("VerificacionDatosCrudos"));
            verificacionList.Add(new VerificacionAdicional("VerificacionOtros"));
        }
        public Task ordenarVerificaciones()
        {
            if (autenticacion.validarCredenciales())
            {
                //Realiza el proceso para procesar y ordenar las verificaciones
                return Task.CompletedTask;
            }
            throw new NotImplementedException();
        }
    }
}
