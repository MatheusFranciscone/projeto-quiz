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
    public partial class frm_Perg10 : Form
    {
        public frm_Perg10()
        {
            InitializeComponent();
        }

        private void btn_Perg10_Click(object sender, EventArgs e)
        {
            if (rdb_Perg10Resp3.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            frm_Resultado q12 = new frm_Resultado();
            q12.Show();
            this.Close();

        }
    }
}
