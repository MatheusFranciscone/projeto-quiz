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
    public partial class frm_Perg9 : Form
    {
        public frm_Perg9()
        {
            InitializeComponent();
        }

        private void btn_Perg9_Click(object sender, EventArgs e)
        {
            if (rdb_Perg9Resp4.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            frm_Perg10 q11 = new frm_Perg10();
            q11.Show();
            this.Hide();

        }
    }
}
