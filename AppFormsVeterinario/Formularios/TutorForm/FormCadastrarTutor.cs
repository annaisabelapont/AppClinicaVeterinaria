using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;
using System;
using System.Windows.Forms;

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
            tutor.Cpf = txtCpf.Text;
            tutor.Cep = txtCEP.Text;
            tutor.Telefone = txtTelefone.Text;

            TutorContext context = new TutorContext();
            context.InserirTutor(tutor);

            txtNome.Clear(); txtCpf.Clear(); txtCEP.Clear(); txtTelefone.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); txtCpf.Clear(); txtCEP.Clear(); txtTelefone.Clear();
        }
    }
}
