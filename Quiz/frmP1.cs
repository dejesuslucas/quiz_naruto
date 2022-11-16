using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class frmP1 : Form
    {
        public frmP1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerto.Checked == true)
            {
                MessageBox.Show("RESPOSTA CERTA ", "QUIZ");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
                this.Dispose();
            }
            else if(radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("RESPOSTA ERRADA ", "QUIZ");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ESCOLHA UMA ALTERNATIVA");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCerto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
