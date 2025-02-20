using AppFormsVeterinario.Formularios.AnimalForm;
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
    public partial class MenuAnimal: Form
    {
        public MenuAnimal()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            new FormCadastrarAnimal().ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            new FormAtualizarAnimal().ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            new FormConsultarAnimal().ShowDialog();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            new FormDeletarAnimalcs().ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            new FormListarAnimais().ShowDialog();
        }
    }
}
