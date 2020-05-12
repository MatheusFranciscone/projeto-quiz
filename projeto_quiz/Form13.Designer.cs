namespace projeto_quiz
{
    partial class frm_pontuacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pontuacao));
            this.lbl_quiz = new System.Windows.Forms.Label();
            this.lbl_acertos = new System.Windows.Forms.Label();
            this.lbl_erros = new System.Windows.Forms.Label();
            this.btn_vamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_quiz
            // 
            this.lbl_quiz.AutoSize = true;
            this.lbl_quiz.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quiz.Location = new System.Drawing.Point(81, 38);
            this.lbl_quiz.Name = "lbl_quiz";
            this.lbl_quiz.Size = new System.Drawing.Size(282, 23);
            this.lbl_quiz.TabIndex = 0;
            this.lbl_quiz.Text = "Será um quiz de 10 questões";
            // 
            // lbl_acertos
            // 
            this.lbl_acertos.AutoSize = true;
            this.lbl_acertos.Location = new System.Drawing.Point(117, 84);
            this.lbl_acertos.Name = "lbl_acertos";
            this.lbl_acertos.Size = new System.Drawing.Size(201, 17);
            this.lbl_acertos.TabIndex = 1;
            this.lbl_acertos.Text = "Para cada acerto: 10 pontos";
            // 
            // lbl_erros
            // 
            this.lbl_erros.AutoSize = true;
            this.lbl_erros.Location = new System.Drawing.Point(126, 110);
            this.lbl_erros.Name = "lbl_erros";
            this.lbl_erros.Size = new System.Drawing.Size(183, 17);
            this.lbl_erros.TabIndex = 2;
            this.lbl_erros.Text = "Para cada erro: -5 pontos";
            // 
            // btn_vamos
            // 
            this.btn_vamos.BackColor = System.Drawing.Color.Indigo;
            this.btn_vamos.ForeColor = System.Drawing.Color.White;
            this.btn_vamos.Location = new System.Drawing.Point(154, 152);
            this.btn_vamos.Name = "btn_vamos";
            this.btn_vamos.Size = new System.Drawing.Size(132, 42);
            this.btn_vamos.TabIndex = 3;
            this.btn_vamos.Text = "Vamos lá!";
            this.btn_vamos.UseVisualStyleBackColor = false;
            this.btn_vamos.Click += new System.EventHandler(this.btn_vamos_Click);
            // 
            // frm_pontuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 215);
            this.Controls.Add(this.btn_vamos);
            this.Controls.Add(this.lbl_erros);
            this.Controls.Add(this.lbl_acertos);
            this.Controls.Add(this.lbl_quiz);
            this.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_pontuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_quiz;
        private System.Windows.Forms.Label lbl_acertos;
        private System.Windows.Forms.Label lbl_erros;
        private System.Windows.Forms.Button btn_vamos;
    }
}