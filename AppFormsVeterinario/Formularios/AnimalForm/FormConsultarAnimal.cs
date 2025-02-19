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

        public FormConsultarAnimal()
        {
            InitializeComponent();
            AnimalContext context = new AnimalContext();//preparou a conexão
            ListaAnimais = context.ListarAnimais(); //conectou e buscou no banco
        }

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {
            var selecao = ListaAnimais.Where(p => p.Nome.Contains(txtNome.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
