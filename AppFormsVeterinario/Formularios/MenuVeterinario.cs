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
    public partial class MenuVeterinario: Form
    {
        public MenuVeterinario()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            new FormCadastrarVeterinario().ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            new FormAtualizarVeterinario().ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            new FormConsultarVeterinario().ShowDialog();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            new FormDeletarVeterinario().ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            new FormListarVeterinario().ShowDialog();
        }
    }
}
