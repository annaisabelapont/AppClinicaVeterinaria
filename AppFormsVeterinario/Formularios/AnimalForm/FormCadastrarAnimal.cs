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
    public partial class FormCadastrarAnimal : Form
    {
        public FormCadastrarAnimal()
        {
            InitializeComponent();
        }
    private void btSalvar_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();

            animal.Nome = txtNome.Text;
            animal.Genero = txtGenero.Text;
            animal.Especie = txtEspecie.Text;
            animal.Raca = txtRaca.Text;

            AnimalContext context = new AnimalContext();
            context.InserirAnimal(animal);
            MessageBox.Show("   ANIMAL CADASTRADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear(); txtGenero.Clear(); txtRaca.Clear(); txtEspecie.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); txtGenero.Clear(); txtRaca.Clear(); txtEspecie.Clear(); txtNome.Select();
        }
    }
}
