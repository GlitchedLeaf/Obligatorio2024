using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAP3
{
    public class Local
    {
        public int ID {  get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Responsable Responsable { get; set; }
        public Maquinas Maquina { get; set; }

        public Local(int id, string nombre, string ciudad, string direccion, string telefono, Responsable responsable, Maquinas maquina)
        {
            ID = id;
            Nombre = nombre;
            Ciudad = ciudad;
            Direccion = direccion;
            Telefono = telefono;
            Responsable = responsable;
            Maquina = maquina;
        }
    }
}
