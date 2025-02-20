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
using AppFormsVeterinario.Formularios.TutorForm;
using AppFormsVeterinario.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppFormsVeterinario.Formularios.AnimalForm
{
    public partial class FormAtualizarAnimal : Form
    {    
        List<Animal> ListaAnimais = new List<Animal>();

        Animal animalSelecionado = new Animal();

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
            animalSelecionado.Especie = txtEspecie.Text;
            animalSelecionado.Genero = txtGenero.Text;
            animalSelecionado.Nome = txtNome.Text;
            animalSelecionado.Raca = txtRaca.Text;

            AnimalContext context = new AnimalContext();

            context.AtualizarAnimal(animalSelecionado);

            cbTutor.SelectedIndex = -1;
            txtEspecie.Clear();
            txtGenero.Clear();
            txtRaca.Clear();
            txtNome.Clear();
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

                animalSelecionado = animalSelec;
            }
            else
            {
                txtEspecie.Clear();
                txtGenero.Clear();
                txtRaca.Clear();
                txtNome.Clear();
            }
        }
    }
}
