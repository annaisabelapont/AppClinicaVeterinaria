using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;

namespace AppFormsVeterinario.Formularios.TutorForm
{
    public partial class FormCadastrarTutor : Form
    {
        public FormCadastrarTutor()
        {
            InitializeComponent();
        }
    
        private void btSalvar_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();

            tutor.Nome = txtNome.Text;
            tutor.Telefone = txtTelefone.Text;
            tutor.Cpf = txtCpf.Text;
            tutor.Cep = txtCep.Text;

            TutorContext context = new TutorContext();
            context.InserirTutor(tutor);
            MessageBox.Show("   TUTOR CADASTRADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear(); txtTelefone.Clear(); txtCpf.Clear(); txtCep.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); txtTelefone.Clear(); txtCpf.Clear(); txtCep.Clear(); txtNome.Select();
        }

    }

}
