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

namespace AppFormsVeterinario.Formularios.ConsultaVetForm
{
    public partial class CadastrarConsultaVet : Form
    {
        private List<Animal> listaAnimais = new List<Animal>();
        private List<Veterinario> listaVeterinarios = new List<Veterinario>();

        private int idAnimalSelecionado;
        private int idVeterinarioSelecionado;

        public CadastrarConsultaVet()
        {
            InitializeComponent();

            AnimalContext animalContext = new AnimalContext();
            listaAnimais = animalContext.ListarAnimais();

            cbAnimal.DataSource = listaAnimais;
            cbAnimal.DisplayMember = "Nome";
            cbAnimal.ValueMember = "Id";

            VeterinarioContext veterinarioContext = new VeterinarioContext();
            listaVeterinarios = veterinarioContext.ListarVeterinarios();

            cbVeterinario.DataSource = listaVeterinarios;
            cbVeterinario.DisplayMember = "Nome";
            cbVeterinario.ValueMember = "Id";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();

            consulta.Tipo = txtTipo.Text;
            consulta.DataConsulta = Convert.ToDateTime(txtData.Text);


            ConsultaVetContext context = new ConsultaVetContext();
            context.InserirConsulta(consulta);
            MessageBox.Show(" CONSULTA CADASTRADA COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtCpf.Clear(); txtCRMV.Clear(); txtData.Clear(); txtTipo.Clear();
            txtNomeTutor.Clear(); txtNomeAnimal.Clear(); txtEspecie.Clear();
        }

        private void cbVeterinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVeterinario.SelectedIndex > -1)
            {
                var veterinarioSelecionado = listaVeterinarios[cbVeterinario.SelectedIndex];
                idVeterinarioSelecionado = veterinarioSelecionado.Id;
                txtNomeVet.Text = veterinarioSelecionado.Nome;
                txtCRMV.Text = veterinarioSelecionado.CRMV;
            }
        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimal.SelectedIndex > -1)
            {
                var animalSelecionado = listaAnimais[cbAnimal.SelectedIndex];
                idAnimalSelecionado = animalSelecionado.Id;
                txtNomeAnimal.Text = animalSelecionado.Nome;
                txtEspecie.Text = animalSelecionado.Especie;

                TutorContext tutorContext = new TutorContext();
                var tutor = tutorContext.
                    ListarTutores().
                    FirstOrDefault(v => v.Id == animalSelecionado.IdTutorFk);
                if (tutor != null)
                {
                    txtNomeTutor.Text = tutor.Nome;
                    txtCpf.Text = tutor.Cpf;
                }
            }
        }
    }
}
