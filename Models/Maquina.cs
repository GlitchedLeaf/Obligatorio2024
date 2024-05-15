using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioAP3
{
    public class Maquinas
    {
        public int ID { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal PrecioCompra { get; set; }
        public int VidaUtil { get; set; }
        public string Tipo { get; set; }
        public bool Disponible { get; set; }

        public Maquinas(int id, DateTime fechaCompra, decimal precioCompra, int vidaUtil, string tipo)
        {
            ID = id;
            FechaCompra = fechaCompra;
            PrecioCompra = precioCompra;
            VidaUtil = vidaUtil;
            Tipo = tipo;
            Disponible = true;
        }
    }
}
