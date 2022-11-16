using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class frmP10 : Form
    {
        public frmP10()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerto.Checked == true)
            {
                MessageBox.Show("RESPOSTA CERTA ", "QUIZ");
                //somar na variavel global acertos
                VariaveisGlobais.Acertos += 1;
                frmFinal Final = new frmFinal();
                Final.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("RESPOSTA ERRADA ", "QUIZ");
                //somar na variavel global erros
                VariaveisGlobais.Erros += 1;
                frmFinal Final = new frmFinal();
                Final.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ESCOLHA UMA ALTERNATIVA");
            }
        }
    }
}
