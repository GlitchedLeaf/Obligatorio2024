using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAP3
{
    public class Socios : Persona
    {
        public string Tipo { get; set; }
        public string Correo { get; set; }
        public Local Local { get; set; }

        public Socios(string nombre, string teléfono, string tipo, string correo, Local local) : base(nombre, teléfono)
        {
            Tipo = tipo;
            Correo = correo;
            Local = local;
        }
    }
}
