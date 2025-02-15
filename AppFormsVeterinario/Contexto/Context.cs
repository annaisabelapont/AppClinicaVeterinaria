using AppFormsVeterinario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFormsVeterinario.Contexto
{
    public class Context
    {
        public static List<Veterinario> ListaVeterinarios { get; set; } = new List<Veterinario>();
    }
}
