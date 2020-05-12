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
    public partial class frm_Perg2 : Form
    {
        public frm_Perg2()
        {
            InitializeComponent();
        }

        private void btn_Perg2_Click(object sender, EventArgs e)
        {
            if (rdb_Perg2Resp3.Checked)
            {
                Dados.Acertou();
                Dados.PontAcertou();
            }
            else
            {
                Dados.Errou();
                Dados.PontErrou();
            }

            frm_Perg3 q4 = new frm_Perg3();
            q4.Show();
            this.Hide();

        }
    }
}
