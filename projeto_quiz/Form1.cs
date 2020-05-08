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
    public partial class frm_BemVindo : Form
    {
        public frm_BemVindo()
        {
            InitializeComponent();
        }

        private void btn_Nao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Sim_Click(object sender, EventArgs e)
        {
            frm_Perg1 q2 = new frm_Perg1();
            q2.Show();
            this.Hide();
        }
    }
}
