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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var tutorSelec = ListaTutores[linhaSelec];
                tutorSelec.Nome = txtNome.Text;
                tutorSelec.Telefone = txtTelefone.Text;
                tutorSelec.Cpf = txtCpf.Text;
                tutorSelec.Cep = txtCep.Text;
            }
            contExc++;
        }     
        
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var tutorSelec = ListaTutores[linhaSelec];
                tutorSelec.Nome = txtNome.Text;
                tutorSelec.Telefone = txtTelefone.Text;
                tutorSelec.Cpf = txtCpf.Text;
                tutorSelec.Cep = txtCep.Text;

                TutorContext context = new TutorContext();
                context.AtualizarTutor(tutorSelec);
                MessageBox.Show($"ID:{(tutorSelec.Id).ToString()} " + "ATUALIZADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtTelefone.Clear(); txtCpf.Clear(); txtCep.Clear(); txtNome.Select();

            }
        }


    }
}
