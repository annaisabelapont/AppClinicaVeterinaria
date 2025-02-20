﻿using AppFormsVeterinario.Contexto;
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

        Tutor tutorSelecionado = new Tutor();

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
            tutorSelecionado.Nome = txtNome.Text;
            tutorSelecionado.Cpf = txtCpf.Text;
            tutorSelecionado.Cep = txtCEP.Text;
            tutorSelecionado.Telefone = txtTelefone.Text;

            TutorContext context = new TutorContext();
            context.AtualizarTutor(tutorSelecionado);

            txtNome.Clear(); txtCpf.Clear(); txtTelefone.Clear(); txtCEP.Clear(); comboBox1.SelectedIndex = -1;
            txtNome.Select(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1)
            {
                var tutorSelec = ListaTutores[linhaSelec];
                txtNome.Text = tutorSelec.Nome;
                txtCpf.Text = tutorSelec.Cpf;
                txtTelefone.Text = tutorSelec.Telefone;
                txtCEP.Text = tutorSelec.Cep;

                tutorSelecionado = tutorSelec;
            }
            else
            {
                txtNome.Clear(); txtCpf.Clear(); txtTelefone.Clear(); txtCEP.Clear();
            }
        }
    }
}
