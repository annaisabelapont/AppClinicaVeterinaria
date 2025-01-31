using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploCadastro.Formulario; 

namespace AppExemploCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarVeterinario_Click(object sender, EventArgs e)
        {
            FormCadastroVeterinarios form = new FormCadastroVeterinarios();
            form.ShowDialog();
        }

        private void btConsultarVeterinario_Click(object sender, EventArgs e)
        {
            FormConsultaVeterinarios form = new FormConsultaVeterinarios();
            form.ShowDialog();
        }

        private void btAtualizarVeterinario_Click(object sender, EventArgs e)
        {
            FormAtualizarVeterinarios form = new FormAtualizarVeterinarios();
            form.ShowDialog();
        }

        private void btListarVeterinarios_Click(object sender, EventArgs e)
        {
            FormListarVeterinarios form = new FormListarVeterinarios();
            form.ShowDialog();
        }
    }
}
