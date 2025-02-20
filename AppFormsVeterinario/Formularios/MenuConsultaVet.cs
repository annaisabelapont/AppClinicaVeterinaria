using AppFormsVeterinario.Formularios.ConsultaVetForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormsVeterinario.Formularios
{
    public partial class MenuConsultaVet: Form
    {
        public MenuConsultaVet()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            new CadastrarConsultaVet().ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            new FormAtualizarConsultaVet().ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            new FormConsultarConsultaVet().ShowDialog();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            new FormDeletarConsultaVet().ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            new FormListarConsultaVet().ShowDialog();
        }
    }
}
