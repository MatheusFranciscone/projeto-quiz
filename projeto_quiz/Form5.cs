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
    public partial class frm_Perg4 : Form
    {
        public frm_Perg4()
        {
            InitializeComponent();
        }

        private void btn_Perg4_Click(object sender, EventArgs e)
        {
            if (rdb_Perg4Resp2.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            frm_Perg5 q6 = new frm_Perg5();
            q6.Show();
            this.Hide();

        }
    }
}
