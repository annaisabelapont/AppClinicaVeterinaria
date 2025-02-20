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
    public partial class FormAtualizarAnimal : Form
    {    
        int contExc = 0;
        List<Animal> ListaAnimais = new List<Animal>();
        public FormAtualizarAnimal()
        {
            InitializeComponent();
            AnimalContext context = new AnimalContext();
            ListaAnimais = context.ListarAnimais();
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

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var animalSelec = ListaAnimais[linhaSelec];
                animalSelec.Nome = txtNome.Text;
                animalSelec.Genero = txtGenero.Text;
                animalSelec.Especie = txtEspecie.Text;
                animalSelec.Raca = txtRaca.Text;

                AnimalContext context = new AnimalContext();
                context.AtualizarAnimal(animalSelec);
                MessageBox.Show($"ID:{(animalSelec.Id).ToString()} " + "ATUALIZADO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtGenero.Clear(); txtRaca.Clear(); txtEspecie.Clear(); txtNome.Select();
            }
        }
    }
}
