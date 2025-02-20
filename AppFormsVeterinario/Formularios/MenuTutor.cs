using AppFormsVeterinario.Formularios.TutorForm;
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
    public partial class MenuTutor: Form
    {
        public MenuTutor()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            new FormCadastrarTutor().ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            new FormConsultarTutor().ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            new FormAtualizarTutor().ShowDialog();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            new FormDeletarTutor().ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            new FormListarTutor().ShowDialog();
        }
    }
}
