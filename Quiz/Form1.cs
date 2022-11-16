using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iNCIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.Erros = 0;
            VariaveisGlobais.Acertos = 0;
            frmP1 p1 = new frmP1();
            p1.ShowDialog();

        }
    }
}
