using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAP3
{
    public class Responsable : Persona
    {
        public int ID { get; set; }
        public Responsable(string nombre, string teléfono, int id) : base(nombre, teléfono)
        {
            ID = id;
        }
    }
}
