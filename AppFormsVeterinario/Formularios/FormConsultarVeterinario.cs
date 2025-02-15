using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormsVeterinario.Formularios
{
    public partial class FormConsultarVeterinario : Form
    {
        List<Veterinario> ListaVeterinarios = new List<Veterinario>();

        public FormConsultarVeterinario()
        {
            InitializeComponent();
            VeterinarioContext context = new VeterinarioContext();//preparou a conexão
            ListaVeterinarios = context.ListarVeterinarios(); //conectou e buscou no banco
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var selecao = ListaVeterinarios.Where(p => p.Nome.Contains(txtNome.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
