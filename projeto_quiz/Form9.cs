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
    public partial class frm_Perg8 : Form
    {
        public frm_Perg8()
        {
            InitializeComponent();
        }

        private void btn_Perg8_Click(object sender, EventArgs e)
        {
            if (rdb_Perg8Resp3.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            frm_Perg9 q10 = new frm_Perg9();
            q10.Show();
            this.Hide();

        }
    }
}
