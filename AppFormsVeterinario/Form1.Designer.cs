namespace AppFormsVeterinario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btListarVeterinarios = new System.Windows.Forms.Button();
            this.btAtualizarVeterinario = new System.Windows.Forms.Button();
            this.btCadastrarVeterinario = new System.Windows.Forms.Button();
            this.btConsultarVeterinario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btDeletarVeterinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btListarVeterinarios
            // 
            this.btListarVeterinarios.BackColor = System.Drawing.Color.White;
            this.btListarVeterinarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btListarVeterinarios.ForeColor = System.Drawing.Color.Indigo;
            this.btListarVeterinarios.Location = new System.Drawing.Point(12, 296);
            this.btListarVeterinarios.Name = "btListarVeterinarios";
            this.btListarVeterinarios.Size = new System.Drawing.Size(785, 44);
            this.btListarVeterinarios.TabIndex = 36;
            this.btListarVeterinarios.Text = "Listar Veterinários";
            this.btListarVeterinarios.UseVisualStyleBackColor = false;
            this.btListarVeterinarios.Click += new System.EventHandler(this.btListarVeterinarios_Click);
            // 
            // btAtualizarVeterinario
            // 
            this.btAtualizarVeterinario.BackColor = System.Drawing.Color.White;
            this.btAtualizarVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAtualizarVeterinario.ForeColor = System.Drawing.Color.Indigo;
            this.btAtualizarVeterinario.Location = new System.Drawing.Point(12, 196);
            this.btAtualizarVeterinario.Name = "btAtualizarVeterinario";
            this.btAtualizarVeterinario.Size = new System.Drawing.Size(785, 44);
            this.btAtualizarVeterinario.TabIndex = 35;
            this.btAtualizarVeterinario.Text = "Atualizar Veterinário";
            this.btAtualizarVeterinario.UseVisualStyleBackColor = false;
            this.btAtualizarVeterinario.Click += new System.EventHandler(this.btAtualizarVeterinario_Click);
            // 
            // btCadastrarVeterinario
            // 
            this.btCadastrarVeterinario.BackColor = System.Drawing.Color.White;
            this.btCadastrarVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCadastrarVeterinario.ForeColor = System.Drawing.Color.Indigo;
            this.btCadastrarVeterinario.Location = new System.Drawing.Point(12, 96);
            this.btCadastrarVeterinario.Name = "btCadastrarVeterinario";
            this.btCadastrarVeterinario.Size = new System.Drawing.Size(785, 44);
            this.btCadastrarVeterinario.TabIndex = 34;
            this.btCadastrarVeterinario.Text = "Cadastrar Veterinário";
            this.btCadastrarVeterinario.UseVisualStyleBackColor = false;
            this.btCadastrarVeterinario.Click += new System.EventHandler(this.btCadastrarVeterinario_Click);
            // 
            // btConsultarVeterinario
            // 
            this.btConsultarVeterinario.BackColor = System.Drawing.Color.White;
            this.btConsultarVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btConsultarVeterinario.ForeColor = System.Drawing.Color.Indigo;
            this.btConsultarVeterinario.Location = new System.Drawing.Point(12, 146);
            this.btConsultarVeterinario.Name = "btConsultarVeterinario";
            this.btConsultarVeterinario.Size = new System.Drawing.Size(785, 44);
            this.btConsultarVeterinario.TabIndex = 33;
            this.btConsultarVeterinario.Text = "Consultar Veterinário";
            this.btConsultarVeterinario.UseVisualStyleBackColor = false;
            this.btConsultarVeterinario.Click += new System.EventHandler(this.btConsultarVeterinario_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(-4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "GESTÃO DE CLÍNICA VETERINÁRIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btDeletarVeterinario
            // 
            this.btDeletarVeterinario.BackColor = System.Drawing.Color.White;
            this.btDeletarVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDeletarVeterinario.ForeColor = System.Drawing.Color.Indigo;
            this.btDeletarVeterinario.Location = new System.Drawing.Point(14, 246);
            this.btDeletarVeterinario.Name = "btDeletarVeterinario";
            this.btDeletarVeterinario.Size = new System.Drawing.Size(785, 44);
            this.btDeletarVeterinario.TabIndex = 37;
            this.btDeletarVeterinario.Text = "Deletar Veterinário";
            this.btDeletarVeterinario.UseVisualStyleBackColor = false;
            this.btDeletarVeterinario.Click += new System.EventHandler(this.btDeletarVeterinario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 382);
            this.Controls.Add(this.btDeletarVeterinario);
            this.Controls.Add(this.btListarVeterinarios);
            this.Controls.Add(this.btAtualizarVeterinario);
            this.Controls.Add(this.btCadastrarVeterinario);
            this.Controls.Add(this.btConsultarVeterinario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListarVeterinarios;
        private System.Windows.Forms.Button btAtualizarVeterinario;
        private System.Windows.Forms.Button btCadastrarVeterinario;
        private System.Windows.Forms.Button btConsultarVeterinario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeletarVeterinario;
    }
}

