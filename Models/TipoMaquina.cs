namespace Obligatorio2024.Models
{
    public class TipoMaquina
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public TipoMaquina(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
    }
}
