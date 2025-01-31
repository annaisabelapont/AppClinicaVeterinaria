using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppExemploCadastro.Models;

namespace AppExemploCadastro.Contexto
{
    public static class Context
    {
        public static List<Veterinario> ListaVeterinarios { get; set; } = new List<Veterinario>();
    }
}
