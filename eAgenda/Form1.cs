using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Visible = true;
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Visible = true;
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até mais, obrigado por utilizar o e-Agenda");
            Close();
        }
    }
}
