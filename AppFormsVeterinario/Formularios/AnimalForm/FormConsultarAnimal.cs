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
    public partial class FormConsultarAnimal : Form
    {

        List<Animal> ListaAnimais = new List<Animal>();
        List<Tutor> ListaTutores = new List<Tutor>();

        public FormConsultarAnimal()
        {
            InitializeComponent();
            AnimalContext contextA = new AnimalContext();//preparou a conexão
            ListaAnimais = contextA.ListarAnimais(); //conectou e buscou no banco

            TutorContext contextT = new TutorContext();//preparou a conexão
            ListaTutores = contextT.ListarTutores(); //conectou e buscou no banco
        }

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {

            var animal = ListaAnimais.Where(p => p.Nome.Contains(txtNome.Text)).FirstOrDefault();

            // realacionar o tutor ao animal consultado
            var TutorVinculado = ListaTutores.Where(m => m.Id == animal.IdTutorFk).FirstOrDefault();
            txtTutor.Text = TutorVinculado.Nome;

            //dados do aninal
            txtGenero.Text = animal.Genero;
            txtEspecie.Text = animal.Especie;
            txtRaca.Text = animal.Raca;
        }
    }
}
