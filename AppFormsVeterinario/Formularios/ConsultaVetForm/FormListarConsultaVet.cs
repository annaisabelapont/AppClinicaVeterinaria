﻿using AppFormsVeterinario.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormsVeterinario.Formularios.ConsultaVetForm
{
    public partial class FormListarConsultaVet : Form
    {
        public FormListarConsultaVet()
        {
            InitializeComponent();

            ConsultaVetContext consultaContext = new ConsultaVetContext();
            dtTabela.DataSource = consultaContext.ListarConsultas().ToList();
        }
    }
}
