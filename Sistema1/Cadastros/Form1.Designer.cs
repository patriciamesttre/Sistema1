namespace Cadastros
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
            this.btnsair = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnfuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Image = global::Cadastros.Properties.Resources.iconfinder_icons_exit2_1564506;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(175, 214);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(123, 60);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Image = global::Cadastros.Properties.Resources.iconfinder_154_man_office_worker_2_3099407;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(175, 51);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(123, 62);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnfuncionarios
            // 
            this.btnfuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfuncionarios.Image = global::Cadastros.Properties.Resources.iconfinder_156_woman_office_worker_2_3099409;
            this.btnfuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfuncionarios.Location = new System.Drawing.Point(28, 51);
            this.btnfuncionarios.Name = "btnfuncionarios";
            this.btnfuncionarios.Size = new System.Drawing.Size(123, 62);
            this.btnfuncionarios.TabIndex = 0;
            this.btnfuncionarios.Text = "Funcionários";
            this.btnfuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfuncionarios.UseVisualStyleBackColor = true;
            this.btnfuncionarios.Click += new System.EventHandler(this.btnfuncionarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 286);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.btnfuncionarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfuncionarios;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnsair;
    }
}

