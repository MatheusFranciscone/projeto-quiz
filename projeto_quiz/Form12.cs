using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_quiz
{
    public partial class frm_Resultado : Form
    {
        public frm_Resultado()
        {
            InitializeComponent();
        }

        private void frm_Resultado_Load(object sender, EventArgs e)
        {
            if ((Dados.Acerto >= 4) && (Dados.Acerto <= 7))
            {
                rtb_Resultado.Text = "Acertos: " + Dados.Acerto + "\nErros: " + Dados.Erro + "\nPrecisa melhorar...";
            }
            if ((Dados.Acerto >= 0) && (Dados.Acerto <= 3))
            {
                rtb_Resultado.Text = "Acertos: " + Dados.Acerto + "\nErros: " + Dados.Erro + "\nVocê realmente precisa melhorar...";
            }
            if ((Dados.Acerto >= 7) && (Dados.Acerto <= 9))
            {
                rtb_Resultado.Text = "Acertos: " + Dados.Acerto + "\nErros: " + Dados.Erro + "\nMuito bem, você está em um ótimo nivel!";
            }
            if (Dados.Acerto == 10)
            {
                rtb_Resultado.Text = "Acertos: " + Dados.Acerto + "\nErros: " + Dados.Erro + "\nParabéns, você foi EXCELENTE!";
            }
        }

        private void btn_Refazer_Click(object sender, EventArgs e)
        {
            frm_Perg1 q1 = new frm_Perg1();
            q1.Show();
            this.Hide();
            Dados.Acerto = 0;
            Dados.Erro = 0;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
