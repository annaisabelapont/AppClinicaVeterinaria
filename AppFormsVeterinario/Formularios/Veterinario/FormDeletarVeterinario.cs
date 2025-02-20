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
    public partial class FormDeletarVeterinario : Form
    {
        int contExc = 0;
        List<Veterinario> ListaVeterinarios = new List<Veterinario>();

        public FormDeletarVeterinario()
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
            if (linhaSelec > -1 && contExc > 0)
            {
                var veterinarioSelec = ListaVeterinarios[linhaSelec];
                txtNome.Text = veterinarioSelec.Nome;
                txtCpf.Text = veterinarioSelec.Cpf;
                txtCRMV.Text = veterinarioSelec.CRMV;
                txtEspecializacao.Text = veterinarioSelec.Especializacao;
            }

            else
            {
                txtCpf.Clear(); txtCRMV.Clear(); txtNome.Clear(); txtEspecializacao.Clear();
            }
            contExc++;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var veterinarioSelec = ListaVeterinarios[linhaSelec];
                txtCpf.Text = veterinarioSelec.Cpf;
                txtCRMV.Text = veterinarioSelec.CRMV;
                txtNome.Text = veterinarioSelec.Nome;
                txtEspecializacao.Text = veterinarioSelec.Especializacao;

                VeterinarioContext context = new VeterinarioContext();
                context.DeletarVeterinario(veterinarioSelec);

                txtCpf.Clear(); txtCRMV.Clear(); txtNome.Clear(); txtEspecializacao.Clear();
            }
        }
    }
}
