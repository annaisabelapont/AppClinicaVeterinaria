namespace AppFormsVeterinario.Formularios
{
    partial class MenuAnimal
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
            this.btDeletar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.White;
            this.btDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDeletar.ForeColor = System.Drawing.Color.Indigo;
            this.btDeletar.Location = new System.Drawing.Point(415, 226);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(274, 55);
            this.btDeletar.TabIndex = 42;
            this.btDeletar.Text = "Deletar Animal";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.White;
            this.btListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btListar.ForeColor = System.Drawing.Color.Indigo;
            this.btListar.Location = new System.Drawing.Point(267, 310);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(274, 55);
            this.btListar.TabIndex = 41;
            this.btListar.Text = "Listar Animais";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.White;
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAtualizar.ForeColor = System.Drawing.Color.Indigo;
            this.btAtualizar.Location = new System.Drawing.Point(415, 145);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(274, 55);
            this.btAtualizar.TabIndex = 40;
            this.btAtualizar.Text = "Atualizar Animal";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.White;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCadastrar.ForeColor = System.Drawing.Color.Indigo;
            this.btCadastrar.Location = new System.Drawing.Point(112, 146);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(274, 55);
            this.btCadastrar.TabIndex = 39;
            this.btCadastrar.Text = "Cadastrar Animal";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.White;
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btConsultar.ForeColor = System.Drawing.Color.Indigo;
            this.btConsultar.Location = new System.Drawing.Point(112, 226);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(274, 55);
            this.btConsultar.TabIndex = 38;
            this.btConsultar.Text = "Consultar Animal";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(789, 57);
            this.label5.TabIndex = 62;
            this.label5.Text = "GERIR ANIMAIS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btConsultar);
            this.Name = "MenuAnimal";
            this.Text = "MenuAnimal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label label5;
    }
}