using System;

namespace AppFormsVeterinario.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime DataConsulta { get; set; }
        public int IdVeterinarioFk { get; set; }
        public int IdAnimalFk { get; set; }
    }
}
