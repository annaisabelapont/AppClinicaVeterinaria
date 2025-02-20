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

namespace AppFormsVeterinario.Formularios.TutorForm
{
    public partial class FormAtualizarTutor : Form
    {
        int contExc = 0;
        List<Tutor> ListaTutores = new List<Tutor>();

        public FormAtualizarTutor()
        {
            InitializeComponent();
            TutorContext context = new TutorContext();
            ListaTutores = context.ListarTutores();
            comboBox1.DataSource = ListaTutores.ToList();
            comboBox1.DisplayMember = "Nome";
            comboBox1.SelectedIndex = -1;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var tutorSelec = ListaTutores[linhaSelec];
                txtNome.Text = tutorSelec.Nome;
                txtCpf.Text = tutorSelec.Cpf;
                txtTelefone.Text = tutorSelec.Telefone;
                txtCEP.Text = tutorSelec.Cep;

                TutorContext context = new TutorContext();
                context.AtualizarTutor(tutorSelec);
                MessageBox.Show($"ID:{(tutorSelec.Id).ToString()} " + "ATUALIZADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtCpf.Clear(); txtTelefone.Clear(); txtCEP.Clear();
                txtNome.Select();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var tutorSelec = ListaTutores[linhaSelec];
                txtNome.Text = tutorSelec.Nome;
                txtCpf.Text = tutorSelec.Cpf;
                txtTelefone.Text = tutorSelec.Telefone;
                txtCEP.Text = tutorSelec.Cep;
            }
            contExc++;
        }
    }
}
