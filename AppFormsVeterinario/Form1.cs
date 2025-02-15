using AppFormsVeterinario.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormsVeterinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarVeterinario_Click(object sender, EventArgs e)
        {
            FormCadastrarVeterinario form = new FormCadastrarVeterinario();
            form.ShowDialog();
        }

        private void btConsultarVeterinario_Click(object sender, EventArgs e)
        {
            FormConsultarVeterinario form = new FormConsultarVeterinario();
            form.ShowDialog();
        }

        private void btAtualizarVeterinario_Click(object sender, EventArgs e)
        {
            FormAtualizarVeterinario form = new FormAtualizarVeterinario();
            form.ShowDialog();
        }

        private void btListarVeterinarios_Click(object sender, EventArgs e)
        {
            FormListarVeterinario form = new FormListarVeterinario();
            form.ShowDialog();
        }

        private void btDeletarVeterinario_Click(object sender, EventArgs e)
        {
            FormDeletarVeterinario form = new FormDeletarVeterinario();
            form.ShowDialog();
        }
    }
}
