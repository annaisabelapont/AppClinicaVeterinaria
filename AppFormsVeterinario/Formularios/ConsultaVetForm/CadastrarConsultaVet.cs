using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            cbAnimal.SelectedIndex = -1;

            VeterinarioContext veterinarioContext = new VeterinarioContext();
            listaVeterinarios = veterinarioContext.ListarVeterinarios();

            cbVeterinario.DataSource = listaVeterinarios;
            cbVeterinario.DisplayMember = "Nome";
            cbVeterinario.ValueMember = "Id";
            cbVeterinario.SelectedIndex = -1;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();

            consulta.Tipo = txtTipo.Text;
            consulta.DataConsulta = Convert.ToDateTime(txtData.Text);
            consulta.IdVeterinarioFk = idVeterinarioSelecionado;
            consulta.IdAnimalFk = idAnimalSelecionado;


            ConsultaVetContext context = new ConsultaVetContext();
            context.InserirConsulta(consulta);

            txtCpf.Clear(); txtCRMV.Clear(); txtData.Clear(); txtTipo.Clear(); cbVeterinario.SelectedIndex = -1;
            txtNomeTutor.Clear(); txtNomeAnimal.Clear(); txtEspecie.Clear(); txtNomeVet.Clear(); cbAnimal.SelectedIndex = -1;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtCpf.Clear(); txtCRMV.Clear(); txtData.Clear(); txtTipo.Clear(); cbVeterinario.SelectedIndex = -1;
            txtNomeTutor.Clear(); txtNomeAnimal.Clear(); txtEspecie.Clear(); txtNomeVet.Clear(); cbAnimal.SelectedIndex = -1;
        }

        private void cbVeterinario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVeterinario.SelectedIndex > -1)
            {
                Veterinario veterinario = listaVeterinarios[cbVeterinario.SelectedIndex];
                idVeterinarioSelecionado = veterinario.Id;
                txtNomeVet.Text = veterinario.Nome;
                txtCRMV.Text = veterinario.CRMV;
            }
            else
            {
                txtNomeVet.Clear(); txtCRMV.Clear();
            }
        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimal.SelectedIndex > -1)
            {
                var animal = listaAnimais[cbAnimal.SelectedIndex];
                idAnimalSelecionado = animal.Id;
                txtNomeAnimal.Text = animal.Nome;
                txtEspecie.Text = animal.Especie;

                TutorContext tutorContext = new TutorContext();
                var tutor = tutorContext.
                    ListarTutores().
                    FirstOrDefault(v => v.Id == animal.IdTutorFk);
                if (tutor != null)
                {
                    txtNomeTutor.Text = tutor.Nome;
                    txtCpf.Text = tutor.Cpf;
                }
            }
            else
            {
                txtNomeAnimal.Clear(); txtEspecie.Clear();
                txtNomeTutor.Clear(); txtCpf.Clear();
            }
        }
    }
}
