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

        private void button1_Click(object sender, EventArgs e)
        {
            MenuVeterinario form = new MenuVeterinario();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuConsultaVet form = new MenuConsultaVet();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuTutor form = new MenuTutor();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAnimal form = new MenuAnimal();
            form.ShowDialog();
        }
    }
}
