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
    public partial class FormCadastrarVeterinario : Form
    {
        public FormCadastrarVeterinario()
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

            VeterinarioContext context = new VeterinarioContext();
            context.InserirVeterinario(veterinario);
            MessageBox.Show(" VETERINÁRIO CADASTRADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear(); txtCpf.Clear(); txtEspecializacao.Clear(); txtCRMV.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); txtCpf.Clear(); txtEspecializacao.Clear(); txtCRMV.Clear(); txtNome.Select();
        }

    }
}
