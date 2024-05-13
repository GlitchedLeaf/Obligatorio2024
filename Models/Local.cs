using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAP3
{
    public class Local
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Responsable Responsable { get; set; }

        public Local(string nombre, string ciudad, string direccion, string telefono, Responsable responsable)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            Direccion = direccion;
            Telefono = telefono;
            Responsable = responsable;
        }
    }
}
