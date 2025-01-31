using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploCadastro.Models; //ter acesso a classe pessoa
using AppExemploCadastro.Contexto; //para ter acesso a classe dos dados (Context)

namespace AppExemploCadastro.Formulario
{
    public partial class FormCadastroVeterinarios : Form
    {
        public FormCadastroVeterinarios()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Nome = txtNome.Text;
            veterinario.Cpf = txtCpf.Text;
            veterinario.CRMV = txtCRMV.Text;
            veterinario.Especializacao = txtEspecializacao.Text;   
            PessoaContext context = new PessoaContext();
            context.InserirVeterinario(veterinario);
            MessageBox.Show("SALVO COM SUCESSO!","2ºA INF",MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Clear(); txtCpf.Clear();txtEspecializacao.Clear();txtCRMV.Clear();
            txtNome.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); txtCpf.Clear(); txtEspecializacao.Clear(); txtCRMV.Clear();
            txtNome.Select();
        }
    }
}
