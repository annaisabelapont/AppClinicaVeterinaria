<<<<<<< HEAD
﻿using System;
=======
﻿using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;
using System;
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;
=======
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f

namespace AppFormsVeterinario.Formularios.TutorForm
{
    public partial class FormDeletarTutor : Form
    {
        int contExc = 0;
        List<Tutor> ListaTutores = new List<Tutor>();
<<<<<<< HEAD
=======

>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
        public FormDeletarTutor()
        {
            InitializeComponent();
            TutorContext context = new TutorContext();
            ListaTutores = context.ListarTutores();
            comboBox1.DataSource = ListaTutores.ToList();
            comboBox1.DisplayMember = "Nome";
            comboBox1.SelectedIndex = -1;
        }

<<<<<<< HEAD
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

=======
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
        private void btExcluir_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var tutorSelec = ListaTutores[linhaSelec];
<<<<<<< HEAD
                tutorSelec.Nome = txtNome.Text;
                tutorSelec.Telefone = txtTelefone.Text;
                tutorSelec.Cpf = txtCpf.Text;
                tutorSelec.Cep = txtCep.Text;

                TutorContext context = new TutorContext();
                context.DeletarTutor(tutorSelec);
                MessageBox.Show($"ID:{(tutorSelec.Id).ToString()} " + "DELETADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtTelefone.Clear(); txtCpf.Clear(); txtCep.Clear(); txtNome.Select();

            }
        }
    
=======
                txtNome.Text = tutorSelec.Nome;
                txtCpf.Text = tutorSelec.Cpf;
                txtTelefone.Text = tutorSelec.Telefone;
                txtCEP.Text = tutorSelec.Cep;

                TutorContext context = new TutorContext();
                context.DeletarTutor(tutorSelec);
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
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
    }
}
