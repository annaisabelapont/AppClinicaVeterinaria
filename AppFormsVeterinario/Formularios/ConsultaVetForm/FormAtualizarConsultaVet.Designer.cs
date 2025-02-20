namespace AppFormsVeterinario.Formularios.ConsultaVetForm
{
    partial class FormAtualizarConsultaVet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(140, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 37);
            this.label6.TabIndex = 89;
            this.label6.Text = "PESQUISAR CONSULTA PELO TIPO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbConsulta
            // 
            this.cbConsulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbConsulta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(142, 107);
            this.cbConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(529, 33);
            this.cbConsulta.TabIndex = 88;
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(55, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(703, 57);
            this.label5.TabIndex = 87;
            this.label5.Text = "ATUALIZAR CONSULTA VETERINÁRIA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.Honeydew;
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btAtualizar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btAtualizar.Location = new System.Drawing.Point(501, 583);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAtualizar.Size = new System.Drawing.Size(257, 48);
            this.btAtualizar.TabIndex = 90;
            this.btAtualizar.Text = "ATUALIZAR REGISTRO";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // FormAtualizarConsultaVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.label5);
            this.Name = "FormAtualizarConsultaVet";
            this.Text = "FormAtualizarConsultaVet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAtualizar;
    }
}