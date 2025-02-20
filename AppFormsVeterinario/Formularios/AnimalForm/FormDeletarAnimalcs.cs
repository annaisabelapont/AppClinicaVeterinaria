using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppFormsVeterinario.Formularios.AnimalForm
{
    public partial class FormDeletarAnimalcs : Form
    {
        List<Animal> ListaAnimais = new List<Animal>();
        Animal animalSelecionado = new Animal();
        public FormDeletarAnimalcs()
        {
            InitializeComponent();
            AnimalContext context = new AnimalContext();
            ListaAnimais = context.ListarAnimais();
            cbAnimal.DataSource = ListaAnimais.ToList();
            cbAnimal.DisplayMember = "Nome";
            cbAnimal.SelectedIndex = -1;
        }


        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimal.SelectedIndex > -1)
            {
                var animalSelec = ListaAnimais[cbAnimal.SelectedIndex];

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

        private void btDeletar_Click(object sender, EventArgs e)
        {
            AnimalContext context = new AnimalContext();
            context.DeletarAnimal(animalSelecionado);

            txtNome.Clear(); txtGenero.Clear(); txtRaca.Clear(); txtEspecie.Clear(); txtNome.Select(); cbAnimal.SelectedIndex = -1;
        }
    }
}
