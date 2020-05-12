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
    public partial class frm_Perg3 : Form
    {
        public frm_Perg3()
        {
            InitializeComponent();
        }

        private void btn_Perg3_Click(object sender, EventArgs e)
        {
            if (rdb_Perg3Resp3.Checked)
            {
                Dados.Acertou();
                Dados.PontAcertou();
            }
            else
            {
                Dados.Errou();
                Dados.PontErrou();
            }

            frm_Perg4 q5 = new frm_Perg4();
            q5.Show();
            this.Hide();

        }
    }
}
