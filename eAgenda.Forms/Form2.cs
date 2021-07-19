using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eAgenda.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Finalizado!");
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = new Compromisso();

            compromisso.Assunto = textBox1.Text;

            compromisso.Local = textBox2.Text;

            compromisso.Hora = textBox3.Text;

            compromisso.Data = dateTimePicker1.Value;

            listBox1.Items.Add(compromisso);
            
        }

        public class Compromisso
        {
            public int Id { get; set; }
            public string Assunto { get; set; }
            public string Local { get; set; }
            public string Hora { get; set; }
            public DateTime Data { get; set; }

            public override string ToString()
            {
                return Assunto + ", " + Local + ", " + Hora
                    + ", " + Data.ToShortDateString();
            }
        }
    }
}
