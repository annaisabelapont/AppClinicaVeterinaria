using AppFormsVeterinario.Contexto;
using System;
using System.Linq;
using System.Windows.Forms;
using AppFormsVeterinario.Models;

namespace AppFormsVeterinario.Formularios.ConsultaVetForm
{
    public partial class FormDeletarConsultaVet : Form
    {
        ConsultaVetContext consultaContext = new ConsultaVetContext();
        Consulta consultaSelecionada = new Consulta();
        public FormDeletarConsultaVet()
        {
            InitializeComponent();
            cbConsulta.DataSource = consultaContext.ListarConsultas().ToList();
            cbConsulta.DisplayMember = "Tipo";
            cbConsulta.SelectedIndex = -1;
        }

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelec = cbConsulta.SelectedIndex;
            if (indexSelec > -1)
            {
                Consulta consulta = consultaContext.ListarConsultas()[indexSelec];

                VeterinarioContext veterinarioContext = new VeterinarioContext();
                Veterinario veterinario = veterinarioContext.ListarVeterinarios().FirstOrDefault(vet => vet.Id == consulta.IdVeterinarioFk);

                AnimalContext animalContext = new AnimalContext();
                Animal animal = animalContext.ListarAnimais().FirstOrDefault(an => an.Id == consulta.IdAnimalFk);

                TutorContext tutorContext = new TutorContext();
                var tutor = tutorContext
                    .ListarTutores()
                    .FirstOrDefault(t => t.Id == animal.IdTutorFk);

                if (tutor != null)
                {
                    txtNomeTutor.Text = tutor.Nome;
                    txtCpf.Text = tutor.Cpf;
                }

                txtNomeVet.Text = veterinario.Nome;
                txtCRMV.Text = veterinario.CRMV;

                txtNomeAnimal.Text = animal.Nome;
                txtEspecie.Text = animal.Especie;

                txtTipo.Text = consulta.Tipo;
                txtData.Text = consulta.DataConsulta.ToString();

                consultaSelecionada = consulta;
            }
            else
            {
                txtNomeVet.Clear(); txtCRMV.Clear(); txtNomeAnimal.Clear(); txtEspecie.Clear(); txtNomeTutor.Clear(); txtCpf.Clear(); txtTipo.Clear(); txtData.Clear();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            consultaContext.DeletarConsulta(consultaSelecionada);

            txtNomeVet.Clear(); txtCRMV.Clear(); txtNomeAnimal.Clear(); txtEspecie.Clear(); txtNomeTutor.Clear(); txtCpf.Clear(); txtTipo.Clear(); txtData.Clear(); cbConsulta.SelectedIndex = -1;
        }
    }
}
