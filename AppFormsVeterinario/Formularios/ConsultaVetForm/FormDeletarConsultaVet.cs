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
                //preencher txts
                consultaSelecionada = consulta;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            consultaContext.DeletarConsulta(consultaSelecionada);
            //limpar txts e cb
        }
    }
}
