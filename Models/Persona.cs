using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAP3
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Teléfono { get; set; }

        public Persona(string nombre, string teléfono)
        {
            Nombre = nombre;
            Teléfono = teléfono;
        }
    }
}
