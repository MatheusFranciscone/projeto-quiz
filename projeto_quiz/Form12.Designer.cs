namespace projeto_quiz
{
    partial class frm_Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Resultado));
            this.rtb_Resultado = new System.Windows.Forms.RichTextBox();
            this.btn_Refazer = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_Resultado
            // 
            this.rtb_Resultado.BackColor = System.Drawing.Color.White;
            this.rtb_Resultado.Enabled = false;
            this.rtb_Resultado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Resultado.ForeColor = System.Drawing.Color.Indigo;
            this.rtb_Resultado.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.rtb_Resultado.Location = new System.Drawing.Point(0, 0);
            this.rtb_Resultado.Name = "rtb_Resultado";
            this.rtb_Resultado.Size = new System.Drawing.Size(374, 179);
            this.rtb_Resultado.TabIndex = 0;
            this.rtb_Resultado.Text = "";
            // 
            // btn_Refazer
            // 
            this.btn_Refazer.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refazer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refazer.ForeColor = System.Drawing.Color.White;
            this.btn_Refazer.Location = new System.Drawing.Point(12, 185);
            this.btn_Refazer.Name = "btn_Refazer";
            this.btn_Refazer.Size = new System.Drawing.Size(121, 50);
            this.btn_Refazer.TabIndex = 1;
            this.btn_Refazer.Text = "Refazer!";
            this.btn_Refazer.UseVisualStyleBackColor = false;
            this.btn_Refazer.Click += new System.EventHandler(this.btn_Refazer_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Indigo;
            this.btn_Sair.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(242, 185);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(121, 50);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Fechar";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 238);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Refazer);
            this.Controls.Add(this.rtb_Resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.frm_Resultado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Resultado;
        private System.Windows.Forms.Button btn_Refazer;
        private System.Windows.Forms.Button btn_Sair;
    }
}