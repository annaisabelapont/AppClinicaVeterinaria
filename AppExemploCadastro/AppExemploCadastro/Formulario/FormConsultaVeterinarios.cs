using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploCadastro.Models;
using AppExemploCadastro.Contexto;

namespace AppExemploCadastro.Formulario
{
    public partial class FormConsultaVeterinarios : Form
    {
        List<Veterinario> ListaPessoas = new List<Veterinario>(); 
        public FormConsultaVeterinarios()
        {
            InitializeComponent();
            PessoaContext context = new PessoaContext();
            ListaPessoas = context.ListarVeterinarios(); 
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var selecao = ListaPessoas.Where(p => p.Nome.Contains(txtNome.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
