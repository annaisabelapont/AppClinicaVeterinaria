namespace AppFormsVeterinario.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Genero { get; set; }
        public int IdTutorFk { get; set; }
    }
}
