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
    public partial class FormCadastrarTutor : Form
    {
        public FormCadastrarTutor()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
    
=======

>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
        private void btSalvar_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();

            tutor.Nome = txtNome.Text;
<<<<<<< HEAD
            tutor.Telefone = txtTelefone.Text;
            tutor.Cpf = txtCpf.Text;
            tutor.Cep = txtCep.Text;

            TutorContext context = new TutorContext();
            context.InserirTutor(tutor);
            MessageBox.Show("   TUTOR CADASTRADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear(); txtTelefone.Clear(); txtCpf.Clear(); txtCep.Clear();
=======
            tutor.Cpf = txtCpf.Text;
            tutor.Cep = txtCEP.Text;
            tutor.Telefone = txtTelefone.Text;

            TutorContext context = new TutorContext();
            context.InserirTutor(tutor);
            MessageBox.Show(" TUTOR CADASTRADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear(); txtCpf.Clear(); txtCEP.Clear(); txtTelefone.Clear();
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            txtNome.Clear(); txtTelefone.Clear(); txtCpf.Clear(); txtCep.Clear(); txtNome.Select();
        }

    }

=======

            txtNome.Clear(); txtCpf.Clear(); txtCEP.Clear(); txtTelefone.Clear();
        }
    }
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
}
