﻿using System;
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
    public partial class frm_Perg6 : Form
    {
        public frm_Perg6()
        {
            InitializeComponent();
        }

        private void btn_Perg6_Click(object sender, EventArgs e)
        {
            if (rdb_Perg6Resp4.Checked)
            {
                Dados.Acertou();
                Dados.PontAcertou();
            }
            else
            {
                Dados.Errou();
                Dados.PontErrou();
            }

            frm_Perg7 q8 = new frm_Perg7();
            q8.Show();
            this.Hide();

        }
    }
}
