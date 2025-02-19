using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFormsVeterinario.Contexto;

namespace AppFormsVeterinario.Formularios.AnimalForm
{
    public partial class FormListarAnimais : Form
    {
        public FormListarAnimais()
        {
            InitializeComponent();
            AnimalContext context = new AnimalContext();//prepara a conexão com o banco
            dtTabela.DataSource = context.ListarAnimais();//busca no banco e colocar os dados no grid
        }
    }
}
