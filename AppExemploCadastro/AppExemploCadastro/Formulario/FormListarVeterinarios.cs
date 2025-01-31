using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploCadastro.Models;
using AppExemploCadastro.Contexto; 

namespace AppExemploCadastro.Formulario
{
    public partial class FormListarVeterinarios : Form
    {
        public FormListarVeterinarios()
        {
            InitializeComponent();
            PessoaContext context = new PessoaContext();
            dtTabela.DataSource = context.ListarVeterinarios();
        }
    }
}
