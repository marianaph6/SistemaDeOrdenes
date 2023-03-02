using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeOrdenes.Models
{
    public class Solicitud
    {

        public Solicitud(string _usuario, string _password)
        {
            usuario = _usuario;
            password = _password;
        }

        public string usuario { get; set; }

        public string password { get; set; }

        public void registrarSolicitud(string usuario, string password)
        {
            //Crear la solicitud/Registrar la solicitud
        }

    }

   

}
