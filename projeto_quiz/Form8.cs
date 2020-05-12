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
    public partial class frm_Perg7 : Form
    {
        public frm_Perg7()
        {
            InitializeComponent();
        }

        private void btn_Perg7_Click(object sender, EventArgs e)
        {
            if (rdb_Perg7Resp5.Checked)
            {
                Dados.Acertou();
                Dados.PontAcertou();
            }
            else
            {
                Dados.Errou();
                Dados.PontErrou();
            }

            frm_Perg8 q9 = new frm_Perg8();
            q9.Show();
            this.Hide();

        }
    }
}
