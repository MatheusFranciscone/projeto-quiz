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
    public partial class frm_Perg1 : Form
    {
        public frm_Perg1()
        {
            InitializeComponent();
        }

        private void btn_Perg1_Click(object sender, EventArgs e)
        {
            if (rdb_Perg1Resp4.Checked)
            {
                Dados.Acertou();
                Dados.PontAcertou();
            }
            else
            {
                Dados.Errou();
                Dados.PontErrou();
            }

            frm_Perg2 q3 = new frm_Perg2();
            q3.Show();
            this.Hide();

        }
    }
}
