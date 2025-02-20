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
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdVeterinário = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(134, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 26);
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
            this.cbConsulta.Location = new System.Drawing.Point(133, 101);
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
            this.label5.Location = new System.Drawing.Point(2, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(797, 57);
            this.label5.TabIndex = 87;
            this.label5.Text = "ATUALIZAR CONSULTA VETERINÁRIA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.Honeydew;
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btAtualizar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btAtualizar.Location = new System.Drawing.Point(272, 332);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAtualizar.Size = new System.Drawing.Size(257, 48);
            this.btAtualizar.TabIndex = 90;
            this.btAtualizar.Text = "ATUALIZAR REGISTRO";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label16.ForeColor = System.Drawing.Color.Indigo;
            this.label16.Location = new System.Drawing.Point(410, 162);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 22);
            this.label16.TabIndex = 153;
            this.label16.Text = "DATA:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label17.ForeColor = System.Drawing.Color.Indigo;
            this.label17.Location = new System.Drawing.Point(131, 163);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 22);
            this.label17.TabIndex = 152;
            this.label17.Text = "TIPO:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(407, 188);
            this.txtData.Margin = new System.Windows.Forms.Padding(4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(255, 30);
            this.txtData.TabIndex = 151;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(133, 188);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(253, 30);
            this.txtTipo.TabIndex = 150;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(134, 244);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 144;
            this.label12.Text = "ID ANIMAL";
            // 
            // txtIdAnimal
            // 
            this.txtIdAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAnimal.Location = new System.Drawing.Point(138, 269);
            this.txtIdAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdAnimal.Name = "txtIdAnimal";
            this.txtIdAnimal.Size = new System.Drawing.Size(248, 30);
            this.txtIdAnimal.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(410, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 135;
            this.label1.Text = "ID VETERINÁRIO";
            // 
            // txtIdVeterinário
            // 
            this.txtIdVeterinário.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVeterinário.Location = new System.Drawing.Point(407, 269);
            this.txtIdVeterinário.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdVeterinário.Name = "txtIdVeterinário";
            this.txtIdVeterinário.Size = new System.Drawing.Size(255, 30);
            this.txtIdVeterinário.TabIndex = 133;
            // 
            // FormAtualizarConsultaVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdVeterinário);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.label5);
            this.Name = "FormAtualizarConsultaVet";
            this.Text = "FormAtualizarConsultaVet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdVeterinário;
    }
}