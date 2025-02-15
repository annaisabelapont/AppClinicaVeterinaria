using AppFormsVeterinario.Contexto;
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
    public partial class FormListarVeterinario : Form
    {
        public FormListarVeterinario()
        {
            InitializeComponent();
            VeterinarioContext context = new VeterinarioContext();//prepara a conexão com o banco
            dtTabela.DataSource = context.ListarVeterinarios();//busca no banco e colocar os dados no grid
        }
    }
}
