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
                //preencher txts
                consultaSelecionada = consulta;
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            //atribuir valores dos txts a consultacontext
            consultaContext.AtualizarConsulta(consultaSelecionada);
            //limpar txts e cb
        }
    }
}
