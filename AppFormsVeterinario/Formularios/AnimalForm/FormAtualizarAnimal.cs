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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppFormsVeterinario.Formularios.AnimalForm
{
    public partial class FormAtualizarAnimal : Form
    {    
        List<Animal> ListaAnimais = new List<Animal>();
        public FormAtualizarAnimal()
        {
            InitializeComponent();
            AnimalContext context = new AnimalContext();
            ListaAnimais = context.ListarAnimais();
            cbTutor.DataSource = ListaAnimais.ToList();
            cbTutor.DisplayMember = "Nome";
            cbTutor.SelectedIndex = -1;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (cbTutor.SelectedIndex > -1)
            {
                int idAnimalSelec = (int)cbTutor.SelectedValue;
                var animalSelec = ListaAnimais.
                    FirstOrDefault(m => m.Id == idAnimalSelec);
                animalSelec.Especie = txtEspecie.Text;
                animalSelec.Genero = txtGenero.Text;
                animalSelec.Nome = txtNome.Text;
                animalSelec.Raca = txtRaca.Text;

                AnimalContext context = new AnimalContext();
                context.AtualizarAnimal(animalSelec);

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
            }
        }
<<<<<<< HEAD
=======


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
>>>>>>> 2b5e118ac87d116ecf75590cfe7658a6f00bdb1f
    }
}
