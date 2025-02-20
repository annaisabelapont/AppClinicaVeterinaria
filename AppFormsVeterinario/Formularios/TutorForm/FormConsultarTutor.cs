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

namespace AppFormsVeterinario.Formularios.TutorForm
{
    public partial class FormConsultarTutor : Form
    {
        List<Tutor> ListaTutores = new List<Tutor>();

        public FormConsultarTutor()
        {
            InitializeComponent();
            TutorContext context = new TutorContext();//preparou a conexão
            ListaTutores = context.ListarTutores(); //conectou e buscou no banco
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var selecao = ListaTutores.Where(p => p.Nome.Contains(txtNome.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
