using AppFormsVeterinario.Contexto;
using AppFormsVeterinario.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppFormsVeterinario.Formularios.ConsultaVetForm
{
    public partial class FormAtualizarConsultaVet : Form
    {
        ConsultaVetContext consultaContext = new ConsultaVetContext();
        Consulta consultaSelecionada = new Consulta();

        public FormAtualizarConsultaVet()
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

                txtTipo.Text = consulta.Tipo;
                txtData.Text = consulta.DataConsulta.ToString();
                txtIdAnimal.Text = consulta.IdAnimalFk.ToString();
                txtIdVeterinário.Text = consulta.IdVeterinarioFk.ToString();

                consultaSelecionada = consulta;
            }
            else
            {
                txtTipo.Clear(); txtData.Clear(); txtIdAnimal.Clear(); txtIdVeterinário.Clear();
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            consultaSelecionada.Tipo = txtTipo.Text;
            consultaSelecionada.DataConsulta = Convert.ToDateTime(txtData.Text);
            consultaSelecionada.IdAnimalFk = Convert.ToInt32(txtIdAnimal.Text);
            consultaSelecionada.IdVeterinarioFk = Convert.ToInt32(txtIdVeterinário.Text);

            consultaContext.AtualizarConsulta(consultaSelecionada);

            txtTipo.Clear(); txtData.Clear(); txtIdAnimal.Clear(); txtIdVeterinário.Clear(); cbConsulta.SelectedIndex = -1;
        }
    }
}
