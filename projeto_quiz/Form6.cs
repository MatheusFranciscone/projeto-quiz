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
    public partial class frm_Perg5 : Form
    {
        public frm_Perg5()
        {
            InitializeComponent();
        }

        private void btn_Perg5_Click(object sender, EventArgs e)
        {
            if (rdb_Perg5Resp3.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            frm_Perg6 q7 = new frm_Perg6();
            q7.Show();
            this.Hide();

        }
    }
}
