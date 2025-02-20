namespace AppFormsVeterinario.Formularios.ConsultaVetForm
{
    partial class FormDeletarConsultaVet
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
            this.btExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNomeTutor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCRMV = new System.Windows.Forms.TextBox();
            this.txtNomeVet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btExcluir.ForeColor = System.Drawing.Color.Firebrick;
            this.btExcluir.Location = new System.Drawing.Point(193, 654);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btExcluir.Size = new System.Drawing.Size(294, 48);
            this.btExcluir.TabIndex = 83;
            this.btExcluir.Text = "DELETAR CONSULTA";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(73, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 37);
            this.label6.TabIndex = 86;
            this.label6.Text = "PESQUISAR CONSULTA PELO TIPO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbConsulta
            // 
            this.cbConsulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbConsulta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(68, 124);
            this.cbConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(533, 33);
            this.cbConsulta.TabIndex = 85;
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(0, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(673, 47);
            this.label5.TabIndex = 84;
            this.label5.Text = "DELETAR CONSULTA VETERINÁRIA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(73, 530);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 27);
            this.label2.TabIndex = 154;
            this.label2.Text = "INFORMAÇÕES DA CONSULTA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label16.ForeColor = System.Drawing.Color.Indigo;
            this.label16.Location = new System.Drawing.Point(355, 562);
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
            this.label17.Location = new System.Drawing.Point(66, 562);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 22);
            this.label17.TabIndex = 152;
            this.label17.Text = "TIPO:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(352, 588);
            this.txtData.Margin = new System.Windows.Forms.Padding(4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(255, 30);
            this.txtData.TabIndex = 151;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(68, 587);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(253, 30);
            this.txtTipo.TabIndex = 150;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.ForeColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(70, 504);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 10);
            this.panel3.TabIndex = 138;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(359, 416);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 22);
            this.label14.TabIndex = 149;
            this.label14.Text = "CPF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label15.ForeColor = System.Drawing.Color.Indigo;
            this.label15.Location = new System.Drawing.Point(364, 350);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 22);
            this.label15.TabIndex = 148;
            this.label15.Text = "NOME TUTOR:";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(363, 440);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(234, 30);
            this.txtCpf.TabIndex = 147;
            // 
            // txtNomeTutor
            // 
            this.txtNomeTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTutor.Location = new System.Drawing.Point(364, 374);
            this.txtNomeTutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeTutor.Name = "txtNomeTutor";
            this.txtNomeTutor.Size = new System.Drawing.Size(233, 30);
            this.txtNomeTutor.TabIndex = 146;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.ForeColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(330, 358);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 114);
            this.panel2.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(62, 416);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 145;
            this.label9.Text = "ESPÉCIE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(59, 345);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 22);
            this.label12.TabIndex = 144;
            this.label12.Text = "NOME ANIMAL:";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(66, 440);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(245, 30);
            this.txtEspecie.TabIndex = 143;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAnimal.Location = new System.Drawing.Point(63, 370);
            this.txtNomeAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(248, 30);
            this.txtNomeAnimal.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(70, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(527, 27);
            this.label7.TabIndex = 141;
            this.label7.Text = "ANIMAL:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.ForeColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(67, 287);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 10);
            this.panel1.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(352, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 136;
            this.label3.Text = "CRVM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(66, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 135;
            this.label1.Text = "NOME:";
            // 
            // txtCRMV
            // 
            this.txtCRMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRMV.Location = new System.Drawing.Point(356, 234);
            this.txtCRMV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCRMV.Name = "txtCRMV";
            this.txtCRMV.Size = new System.Drawing.Size(248, 30);
            this.txtCRMV.TabIndex = 134;
            // 
            // txtNomeVet
            // 
            this.txtNomeVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVet.Location = new System.Drawing.Point(70, 234);
            this.txtNomeVet.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeVet.Name = "txtNomeVet";
            this.txtNomeVet.Size = new System.Drawing.Size(248, 30);
            this.txtNomeVet.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(73, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 28);
            this.label4.TabIndex = 132;
            this.label4.Text = "VETERINÁRIO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeletarConsultaVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 738);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNomeTutor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCRMV);
            this.Controls.Add(this.txtNomeVet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btExcluir);
            this.Name = "FormDeletarConsultaVet";
            this.Text = "FormDeletarConsultaVet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomeTutor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCRMV;
        private System.Windows.Forms.TextBox txtNomeVet;
        private System.Windows.Forms.Label label4;
    }
}