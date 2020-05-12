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
    public partial class frm_pontuacao : Form
    {
        public frm_pontuacao()
        {
            InitializeComponent();
        }

        private void btn_vamos_Click(object sender, EventArgs e)
        {
            frm_Perg1 q1 = new frm_Perg1();
            q1.Show();
            this.Close();
        }
    }
}
