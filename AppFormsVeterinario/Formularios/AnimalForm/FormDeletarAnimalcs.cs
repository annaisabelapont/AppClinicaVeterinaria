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
using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;

namespace AppFormsVeterinario.Formularios.AnimalForm
{
    public partial class FormDeletarAnimalcs : Form
    {
<<<<<<< HEAD
        int contExc = 0;
        List<Animal> ListaAnimais = new List<Animal>();

=======
        List<Animal> ListaAnimais = new List<Animal>();
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
        public FormDeletarAnimalcs()
        {
            InitializeComponent();
            AnimalContext context = new AnimalContext();
            ListaAnimais = context.ListarAnimais();
<<<<<<< HEAD
            comboBox1.DataSource = ListaAnimais.ToList();
            comboBox1.DisplayMember = "Nome";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var pessoaSelec = ListaAnimais[linhaSelec];
                txtNome.Text = pessoaSelec.Nome;
                txtGenero.Text = pessoaSelec.Genero;
                txtEspecie.Text = pessoaSelec.Especie;
                txtRaca.Text = pessoaSelec.Raca;
            }
            contExc++;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var animalSelec = ListaAnimais[linhaSelec];
                animalSelec.Nome = txtNome.Text;
                animalSelec.Genero = txtGenero.Text;
                animalSelec.Especie = txtEspecie.Text;
=======
            cbTutor.DataSource = ListaAnimais.ToList();
            cbTutor.DisplayMember = "Nome";
            cbTutor.SelectedIndex = -1;
        }


        private void cbTutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTutor.SelectedIndex > -1)
            {
                var animalSelec = ListaAnimais[cbTutor.SelectedIndex];

                txtEspecie.Text = animalSelec.Especie;
                txtGenero.Text = animalSelec.Genero;
                txtNome.Text = animalSelec.Nome;
                txtRaca.Text = animalSelec.Raca;

                TutorContext tutorContext = new TutorContext();
                var tutor = tutorContext.
                    ListarTutores().
                    FirstOrDefault(v => v.Id == animalSelec.IdTutorFk);

                if (tutor != null)
                {
                    txtCEP.Text = tutor.Cep;
                    txtCPF.Text = tutor.Cpf;
                    txtNomeTutor.Text = tutor.Nome;
                    txtTelefone.Text = tutor.Telefone;
                }
                else
                {
                    txtCEP.Clear();
                    txtNomeTutor.Clear();
                    txtCPF.Clear();
                    txtTelefone.Clear();
                }
            }
            else
            {
                txtEspecie.Clear();
                txtGenero.Clear();
                txtRaca.Clear();
                txtNome.Clear();
                txtCEP.Clear();
                txtNomeTutor.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (cbTutor.SelectedIndex > -1)
            {
                int idAnimalSelec = (int)cbTutor.SelectedValue;
                var animalSelec = ListaAnimais.
                    FirstOrDefault(m => m.Id == idAnimalSelec);
                animalSelec.Especie = txtEspecie.Text;
                animalSelec.Genero = txtGenero.Text;
                animalSelec.Nome = txtNome.Text;
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
                animalSelec.Raca = txtRaca.Text;

                AnimalContext context = new AnimalContext();
                context.DeletarAnimal(animalSelec);
<<<<<<< HEAD
                MessageBox.Show($"ID:{(animalSelec.Id).ToString()} " + "ATUALIZADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtGenero.Clear(); txtRaca.Clear(); txtEspecie.Clear(); txtNome.Select();
=======

                MessageBox.Show($"ID:{animalSelec.Id} ATUALIZADO COM SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbTutor.SelectedIndex = -1;
                txtEspecie.Clear();
                txtGenero.Clear();
                txtRaca.Clear();
                txtNome.Clear();
                txtCEP.Clear();
                txtNomeTutor.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
            }
        }
    }
}
