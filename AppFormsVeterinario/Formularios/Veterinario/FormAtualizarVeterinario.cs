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
using static AppFormsVeterinario.Contexto.VeterinarioContext;

namespace AppFormsVeterinario.Formularios
{
    public partial class FormAtualizarVeterinario : Form
    {
        List<Veterinario> ListaVeterinarios = new List<Veterinario>();

        public FormAtualizarVeterinario()
        {
            InitializeComponent();
            VeterinarioContext context = new VeterinarioContext();
            ListaVeterinarios = context.ListarVeterinarios();
            comboBox1.DataSource = ListaVeterinarios.ToList();
            comboBox1.DisplayMember = "Nome";
            comboBox1.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1)
            {
                var pessoaSelec = ListaVeterinarios[linhaSelec];
                txtNome.Text = pessoaSelec.Nome;
                txtCpf.Text = pessoaSelec.Cpf;
                txtCRMV.Text = pessoaSelec.CRMV;
                txtEspecializacao.Text = pessoaSelec.Especializacao;
            }
            else
            {
                txtNome.Clear(); txtCpf.Clear(); txtEspecializacao.Clear(); txtCRMV.Clear();
                txtNome.Select();
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1)
            {
                var pessoaSelec = ListaVeterinarios[linhaSelec];
                pessoaSelec.Nome = txtNome.Text;
                pessoaSelec.Cpf = txtCpf.Text;
                pessoaSelec.CRMV = txtCRMV.Text;
                pessoaSelec.Especializacao = txtEspecializacao.Text;

                VeterinarioContext context = new VeterinarioContext();
                context.AtualizarVeterinario(pessoaSelec);

                txtNome.Clear(); txtCpf.Clear(); txtEspecializacao.Clear(); txtCRMV.Clear(); comboBox1.SelectedIndex = -1;
                txtNome.Select();
            }
        }
    }
}
