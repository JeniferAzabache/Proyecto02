using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyClase02.Models.BEAN
{
    public class ContactoClienteBEAN
    {

        public int idContactabilidad { get; set; }
        public int idColaborador { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }
        public System.DateTime fechaContactoCliente { get; set; }
        public string comentarioContactoCliente { get; set; }
        public string estadoContactoCliente { get; set; }
        public string NombreColaborador { get; set; }
        public string NombreCliente { get; set; }
        public string NombreProducto{ get; set; }

    }
}