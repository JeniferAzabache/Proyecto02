using System;

namespace ProyClase02.Controllers
{
    internal class ContactoClienteBEAN
    {
        public object idContactibilidad { get; set; }
        public int idColaborador { get; set; }
        public string NombreColaborador { get; set; }
        public DateTime fechaContactoCliente { get; internal set; }
        public int idCliente { get; internal set; }
        public string NombreCliente { get; internal set; }
        public object NombreProducto { get; internal set; }
    }
}