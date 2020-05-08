namespace projeto_quiz
{
    partial class frm_BemVindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BemVindo));
            this.lbl_Apresentacao = new System.Windows.Forms.Label();
            this.lbl_Perg0 = new System.Windows.Forms.Label();
            this.btn_Sim = new System.Windows.Forms.Button();
            this.btn_Nao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Apresentacao
            // 
            this.lbl_Apresentacao.AutoSize = true;
            this.lbl_Apresentacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apresentacao.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apresentacao.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Apresentacao.Location = new System.Drawing.Point(45, 59);
            this.lbl_Apresentacao.Name = "lbl_Apresentacao";
            this.lbl_Apresentacao.Size = new System.Drawing.Size(353, 39);
            this.lbl_Apresentacao.TabIndex = 0;
            this.lbl_Apresentacao.Text = "Olá, seja bem-vindo!";
            // 
            // lbl_Perg0
            // 
            this.lbl_Perg0.AutoSize = true;
            this.lbl_Perg0.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Perg0.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Perg0.Location = new System.Drawing.Point(70, 130);
            this.lbl_Perg0.Name = "lbl_Perg0";
            this.lbl_Perg0.Size = new System.Drawing.Size(306, 19);
            this.lbl_Perg0.TabIndex = 1;
            this.lbl_Perg0.Text = "Você gostaria de participar de um quiz? ";
            // 
            // btn_Sim
            // 
            this.btn_Sim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Sim.BackColor = System.Drawing.Color.Indigo;
            this.btn_Sim.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sim.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Sim.Location = new System.Drawing.Point(246, 203);
            this.btn_Sim.Name = "btn_Sim";
            this.btn_Sim.Size = new System.Drawing.Size(152, 37);
            this.btn_Sim.TabIndex = 2;
            this.btn_Sim.Text = "Sim! Vamos lá";
            this.btn_Sim.UseVisualStyleBackColor = false;
            this.btn_Sim.Click += new System.EventHandler(this.btn_Sim_Click);
            // 
            // btn_Nao
            // 
            this.btn_Nao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Nao.BackColor = System.Drawing.Color.Indigo;
            this.btn_Nao.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nao.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Nao.Location = new System.Drawing.Point(40, 203);
            this.btn_Nao.Name = "btn_Nao";
            this.btn_Nao.Size = new System.Drawing.Size(152, 37);
            this.btn_Nao.TabIndex = 3;
            this.btn_Nao.Text = "Não, deixa para próxima...";
            this.btn_Nao.UseVisualStyleBackColor = false;
            this.btn_Nao.Click += new System.EventHandler(this.btn_Nao_Click);
            // 
            // frm_BemVindo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 264);
            this.Controls.Add(this.btn_Nao);
            this.Controls.Add(this.btn_Sim);
            this.Controls.Add(this.lbl_Perg0);
            this.Controls.Add(this.lbl_Apresentacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-vindo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Apresentacao;
        private System.Windows.Forms.Label lbl_Perg0;
        private System.Windows.Forms.Button btn_Sim;
        private System.Windows.Forms.Button btn_Nao;
    }
}

